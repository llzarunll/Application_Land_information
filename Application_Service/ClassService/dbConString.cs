using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Application_Service.ClassService
{
    public sealed class dbConString
    {
        public static string ServerName = @".\SQL2014";
        public static string DBName = "DB_Dev";
        public static string Sa = "sa";
        public static string SaPassword = "1";
        //public static string ServerName = @".\SQL2014";
        //public static string DBName = "iPOS";
        //public static string Sa = "sa";
        //public static string SaPassword = "1";
        //public static string ServerName = string.Empty;
        //public static string DBName = string.Empty;
        //public static string Sa = string.Empty;
        //public static string SaPassword = string.Empty;
        

        
        //public static string strConn = "Data Source=BEE-PC;Initial Catalog=dbSchoolPOS;User Id=saSchoolPOS;Password=123456;Integrated Security=NO";
        public static string ConnetionString = "Server=" + ServerName + ";Database=" + DBName + ";User ID=" + Sa + ";Password=" + SaPassword + ";Trusted_Connection=False";
        public static SqlConnection mySQLConn = new SqlConnection();
        public static SqlCommand Com = new SqlCommand();
        public static SqlTransaction Transaction;
        public static string UserID = "";
        public static string EmpName = "นาย ทดสอบ ระบบ";
        public static string EmpUserName = "";
        public static string EmpLevel = "";
        public static string EmpCode = "EMP001";
        public static string EmpId = "4fb62f4a-db39-41d9-b32a-b7a086f243ee";
        public static string xMessage = "ข้อความแจ้งเตือน";
        public static string SettingPath = string.Empty;


        public static string OrgName = "";
        public static string TraderName = "";
        public static string Address = "";
        public static string TaxID = "";
        public static double TaxRate = 0.0f;
        public static string Tel = "";
        public static string Fax = "";


        #region TestConnection
        /// <summary>
        /// for test connectionstring
        /// </summary>
        public static void Chk_ConnectionState()
        {
            if (mySQLConn.State != ConnectionState.Open)
            {
                OpenConn();
            }
        }

        public static void OpenConn()
        {
            MergeConnetionString();
            mySQLConn = new SqlConnection(ConnetionString); 
            try 
            {
                mySQLConn.Open(); 
            } 
            catch (Exception ex) 
            { 
                //MessageBox.Show("Can not open connection ! ");
                MessageBox.Show("เกิดข้อผิดพลาด : ไม่สามารถเชือมต่อ Database ได้ โปรดตรวจสอบ", xMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void MergeConnetionString()
        {
            ConnetionString = "Server=" + ServerName + ";Database=" + DBName + ";User ID=" + Sa + ";Password=" + SaPassword + ";Trusted_Connection=False";
        }

        public static bool CheckOpenConn()
        {
            MergeConnetionString();
            mySQLConn = new SqlConnection(ConnetionString);
            try
            {
                mySQLConn.Open();
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
                //MessageBox.Show("เกิดข้อผิดพลาด : " + ex.Message + " โปรดตรวจสอบ", xMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("เกิดข้อผิดพลาด : ไม่สามารถเชือมต่อ Database ได้ โปรดตรวจสอบ", xMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

    }
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                if (control is GroupBox)
                {
                    GroupBoxResetAll((GroupBox)control);
                }
            }
        }

        public static void GroupBoxResetAll(GroupBox gbox)
        {
            foreach (Control ctrl in gbox.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox textBox = (TextBox)ctrl;
                    textBox.Text = null;
                }
                if (ctrl is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                }
                if (ctrl is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)ctrl;
                    checkBox.Checked = false;
                }
                if (ctrl is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)ctrl;
                    radioButton.Checked = false;
                }
                if (ctrl is ListBox)
                {
                    ListBox listBox = (ListBox)ctrl;
                    listBox.ClearSelected();
                }
                if (ctrl is DataGrid)
                {
                    DataGrid DataGrid = (DataGrid)ctrl;
                    //DataGrid.
                }
            }
        }

        public static bool CheckDuplicate(string TableName, string columnName, string Value)
        { 
            bool Duplicate = true;
            int Count = 0;
            SqlDataReader reader;
            try
            {
                string sqlTmp = "";

                sqlTmp = "SELECT COUNT(" + columnName + ") FROM " + TableName + " WHERE " + columnName + " = '" + Value + "'";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                //dr = dbConString.Com.ExecuteReader();
                reader  = dbConString.Com.ExecuteReader();
                while (reader.Read())
                {
                    Count = reader.GetInt32(0);    // Count Found column int
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (Count > 0)
                Duplicate = false;
            return Duplicate;
        }

        public static bool CheckDuplicateNotInOldValues(string TableName, string columnName, string Value, string OldValue)
        {
            bool Duplicate = true;
            int Count = 0;
            SqlDataReader reader;
            try
            {
                string sqlTmp = "";

                sqlTmp = "SELECT COUNT(" + columnName + ") FROM " + TableName + " WHERE " + columnName + " = '" + Value + "' AND " + columnName + " NOT IN ('" + OldValue + "')";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                //dr = dbConString.Com.ExecuteReader();
                reader = dbConString.Com.ExecuteReader();
                while (reader.Read())
                {
                    Count = reader.GetInt32(0);    // Count Found column int
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (Count > 0)
                Duplicate = false;
            return Duplicate;
        }

        public static void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public class FunctionEtc
    {
        public static string CalculateAge(DateTime DatePresentYear)
        { 
            string  Age = string.Empty;
            DateTime dob = DateTime.Today;

            TimeSpan ts = dob - DatePresentYear ;
            Age = (ts.Days / 365).ToString();

            return Age;
        }
    }

   
}
