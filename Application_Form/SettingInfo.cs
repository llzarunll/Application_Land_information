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
using Application_Service.ClassService;

namespace Application_Form
{
    public partial class SettingInfo : Form
    {
        public SettingInfo()
        {
            InitializeComponent();
        }

        SqlDataReader Dr;
        string SettingPathID = string.Empty;
        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new System.Windows.Forms.FolderBrowserDialog();
            // This is what will execute if the user selects a folder and hits OK (File if you change to FileBrowserDialog)
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
            }
            else
            {
                // This prevents a crash when you close out of the window with nothing
            }
        }

        private void SettingInfo_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            DoLoadData();
        }

        private void DoLoadData()
        {
            #region tbSettingPath
            bool Duplicate = true;
            int Count = 0;

            DataSet Ds = new DataSet();
            try
            {
                string sqlTmp = "";

                sqlTmp = "SELECT * FROM tbSettingPath";

                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                Dr = dbConString.Com.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (Dr.HasRows)
            {
                Dr.Read();
                txtPath.Text = Dr.GetString(Dr.GetOrdinal("SettingPath"));
                SettingPathID = Dr.GetString(Dr.GetOrdinal("SettingPathID"));
                Dr.Close();
            }
            else
            {
                txtPath.Text = Application.StartupPath.ToString();
                SettingPathID = string.Empty;
                Dr.Close();
            }

            #endregion
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == string.Empty)
            {
                MessageBox.Show("กรุณาเลือก Path", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPath.Focus();
                return;
            }

            if (MessageBox.Show("คุณต้องการบันทึก Path หรือไม่", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                
                try
                {
                    if (string.IsNullOrEmpty(SettingPathID))
                    {
                        SettingPathID = Guid.NewGuid().ToString();
                        dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBuilder StringBd = new StringBuilder();
                        //dbConString.Transaction = new SqlTransaction();
                        string sqlTmp = string.Empty;
                        StringBd.Append("INSERT INTO tbSettingPath VALUES (@SettingPathID,@SettingPath,@Detail,@CreatedBy,GETDATE())");
                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@SettingPathID", SqlDbType.VarChar).Value = SettingPathID;
                        dbConString.Com.Parameters.Add("@SettingPath", SqlDbType.VarChar).Value = txtPath.Text;
                        dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = string.Empty;
                        dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                        dbConString.Com.ExecuteNonQuery();
                        dbConString.Transaction.Commit();
                    }
                    else
                    {
                        dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                        StringBuilder StringBd = new StringBuilder();
                        //dbConString.Transaction = new SqlTransaction();
                        string sqlTmp = string.Empty;
                        StringBd.Append("UPDATE tbSettingPath SET SettingPath = @SettingPath WHERE SettingPathID = @SettingPathID");
                        sqlTmp = "";
                        sqlTmp = StringBd.ToString();
                        dbConString.Com = new SqlCommand();
                        dbConString.Com.CommandText = sqlTmp;
                        dbConString.Com.CommandType = CommandType.Text;
                        dbConString.Com.Connection = dbConString.mySQLConn;
                        dbConString.Com.Transaction = dbConString.Transaction;
                        dbConString.Com.Parameters.Clear();
                        dbConString.Com.Parameters.Add("@SettingPathID", SqlDbType.VarChar).Value = SettingPathID;
                        dbConString.Com.Parameters.Add("@SettingPath", SqlDbType.VarChar).Value = txtPath.Text;
                        dbConString.Com.ExecuteNonQuery();
                        dbConString.Transaction.Commit();
                    }

                    dbConString.SettingPath = txtPath.Text;
                    MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    dbConString.Transaction.Rollback();
                }
            }

            DoLoadData();
        }


    }
}
