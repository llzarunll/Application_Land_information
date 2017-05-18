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
using Application_Form.ApplicationData;
using Application_Service;
using Application_Service.ClassService;

namespace Application_Form
{
    public partial class UserList : BaseListUserControl
    {
        public UserList()
        {
            InitializeComponent();
        }

        #region 
        ApplicationDS tblUser = new ApplicationDS();
        int SelectRowIndex = -1;
        string UserID = string.Empty;
        #endregion

        protected override void DoLoadForm()
        {
            dbConString.Chk_ConnectionState();
            ShowData();
        }

        protected override void DoNew()
        {
            UserInfo frmForm = new UserInfo();
            frmForm.FormState = "new";
            frmForm.ShowDialog();
            btnStatus(true);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvUserList.RowCount > 0)
            {
                UserInfo frmForm = new UserInfo();
                frmForm.FormState = "edit";
                frmForm.UserID = dgvUserList.Rows[SelectRowIndex].Cells[ColUserID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            ShowData();
        }

        protected override void DoDelete()
        {
            if (MessageBox.Show("คุณต้องการลบข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            UserID = dgvUserList.Rows[SelectRowIndex].Cells[ColUserID.Name].Value.ToString();
            
            try
            {
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;
                StringBd.Append("DELETE tbUser WHERE UserID = @UserID;");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = UserID;
                dbConString.Com.ExecuteNonQuery();
                dbConString.Transaction.Commit();
                MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnStatus(true);
                ShowData();
                Utilities.ResetAllControls(this);
            }
            catch
            {
                dbConString.Transaction.Rollback();
            }
        }

        private void ShowData()
        {
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbUser";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblUser.Clear();
                da.Fill(tblUser, "tbUser");
                da.Dispose();
                dgvUserList.DataSource = tblUser.tbUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SelectRowIndex = -1;


        }

        private void dgvUserList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectRowIndex = e.RowIndex;
            btnStatus(false);
        }

        private void dgvUserList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvUserList.RowCount > 0)
            //{
            //    UserInfo frmForm = new UserInfo();
            //    frmForm.FormState = "edit";
            //    frmForm.UserID = dgvUserList.Rows[SelectRowIndex].Cells[ColUserID.Name].Value.ToString();
            //    frmForm.ShowDialog();
            //    btnStatus(true);
            //}
            //ShowData();
        }

        private void dgvUserList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvUserList.RowCount > 0)
            {
                UserInfo frmForm = new UserInfo();
                frmForm.FormState = "edit";
                frmForm.UserID = dgvUserList.Rows[SelectRowIndex].Cells[ColUserID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            ShowData();
        }
    }
}
