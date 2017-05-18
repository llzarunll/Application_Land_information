using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Service;
using Application_Service.ClassService;
using Application_Form.ApplicationData;

namespace Application_Form
{
    public partial class UserInfo : BaseInfo
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        #region
        public string UserID = string.Empty;
        ApplicationDS tblUser = new ApplicationDS();
        string sqlTmp = string.Empty;
        #endregion

        protected override void DoLoadForm()
        {
            switch (FormState.ToLower())
            {
                case "new":
                    break;
                    UserID = string.Empty;
                case "edit":
                    DoLoadData(UserID);
                    break;
            }
        }

        private void DoLoadData(string UserID)
        {
            #region tbUser
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbUser WHERE UserID = '" + UserID +"'";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblUser.Clear();
                da.Fill(tblUser, "tbUser");
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
            if (tblUser.tbUser.Rows.Count > 0)
            {
                UserID = tblUser.tbUser[0].UserID;
                txtUserName.Text = tblUser.tbUser[0].UserName;
                txtPassword.Text = tblUser.tbUser[0].Password;
                txtDetail.Text = tblUser.tbUser[0].Detail;
                txtConfirm.Text = string.Empty;
            }
        }

        private void DoCheckData()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtConfirm.Text))
            {
                MessageBox.Show("Confirm Password is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtConfirm.Focus();
                return;
            }

            if (txtConfirm.Text != txtPassword.Text)
            {
                MessageBox.Show("Confirm Password incorrect", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtConfirm.Focus();
                return;
            }
        }

        protected override void DoSave()
        {
            Success = true;
            DoCheckData();

            if (!Success)
                return;

            //Check Duplicate
            if (Success == true && tblUser.tbUser.Rows.Count > 0)
            {
                Success = Utilities.CheckDuplicateNotInOldValues(tblUser.tbUser.TableName,
                                                                tblUser.tbUser.UserNameColumn.ColumnName,
                                                                txtUserName.Text,
                                                                tblUser.tbUser[0].UserName);
                if (!Success)
                {
                    MessageBox.Show("UserName is Duplicate", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    return;
                }
            }
            else
            {
                Success = Utilities.CheckDuplicate(tblUser.tbUser.TableName,
                                                  tblUser.tbUser.UserNameColumn.ColumnName,
                                                  txtUserName.Text);
                if (!Success)
                {
                    MessageBox.Show("UserName is Duplicate", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    return;
                }
            }

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            switch (FormState.ToLower())
            {
                case "new":
                    #region Save
                    if (Success)
                    {
                        try
                        {
                            #region tbUser
                            UserID = Guid.NewGuid().ToString();
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tbUser VALUES(@UserID,@UserName,@Password,@Detail,@CreatedBy,GETDATE())");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                            dbConString.Com.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txtUserName.Text;
                            dbConString.Com.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtConfirm.Text;
                            dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = txtDetail.Text;
                            dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                            dbConString.Com.ExecuteNonQuery();
                            dbConString.Transaction.Commit();
                            #endregion
                            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch
                        {
                            dbConString.Transaction.Rollback();
                        }
                    }
                    else
                    {
                        return;
                    }
                    #endregion
                    break;
                case "edit":
                    #region Edit
                    if (Success)
                    {
                        try
                        {
                            #region tbUser
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("UPDATE tbUser SET UserName = @UserName,Password = @Password,Detail = @Detail WHERE UserID = @UserID");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                            dbConString.Com.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txtUserName.Text;
                            dbConString.Com.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtConfirm.Text;
                            dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = txtDetail.Text;
                            dbConString.Com.ExecuteNonQuery();
                            dbConString.Transaction.Commit();
                            #endregion
                            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch(Exception ex)
                        {
                            dbConString.Transaction.Rollback();
                        }
                    }
                    else
                    {
                        return;
                    }
                    #endregion
                    break;
            }
        }
        
    }
}
