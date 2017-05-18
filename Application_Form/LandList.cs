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
    public partial class LandList : BaseListUserControl
    {
        public LandList()
        {
            InitializeComponent();
        }

        #region
        ApplicationDS tblLand = new ApplicationDS();
        int SelectRowIndex = -1;
        string LandID = string.Empty;
        #endregion

        protected override void DoLoadForm()
        {
            dbConString.Chk_ConnectionState();
            ShowData();
        }

        protected override void DoNew()
        {
            LandInfo frmForm = new LandInfo();
            frmForm.FormState = "new";
            frmForm.ShowDialog();
            btnStatus(true);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvLandList.RowCount > 0)
            {
                LandInfo frmForm = new LandInfo();
                frmForm.FormState = "edit";
                frmForm.LandID = dgvLandList.Rows[SelectRowIndex].Cells[colLandID.Name].Value.ToString();
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

            LandID = dgvLandList.Rows[SelectRowIndex].Cells[colLandID.Name].Value.ToString();

            try
            {
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;
                StringBd.Append(" DELETE DT FROM tbTimeLineDT AS DT  LEFT JOIN tbTimeLineHD AS HD ON DT.TimeLineHDID = HD.TimeLineHDID  WHERE HD.LandID = @LandID;");
                StringBd.Append(" DELETE tbTimeLineHD WHERE LandID = @LandID;");
                StringBd.Append(" DELETE tbLand WHERE LandID = @LandID;");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
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
                sqlTmp = "SELECT * FROM tbLand";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblLand.Clear();
                da.Fill(tblLand, "tbLand");
                da.Dispose();
                dgvLandList.DataSource = tblLand.tbLand;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SelectRowIndex = -1;


        }

        private void dgvLandList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectRowIndex = e.RowIndex;
            btnStatus(false);
        }

        private void dgvLandList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvLandList.RowCount > 0)
            {
                LandInfo frmForm = new LandInfo();
                frmForm.FormState = "edit";
                frmForm.LandID = dgvLandList.Rows[SelectRowIndex].Cells[colLandID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            ShowData();
        }
    }
}
