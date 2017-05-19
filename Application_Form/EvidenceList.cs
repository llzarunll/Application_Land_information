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
using Application_Form.ApplicationData;
using Application_Service.ClassService;

namespace Application_Form
{
    public partial class EvidenceList : BaseListUserControl
    {
        public EvidenceList()
        {
            InitializeComponent();
        }

        #region
        ApplicationDS tblEvidence = new ApplicationDS();
        int SelectRowIndex = -1;
        string EvidenceID = string.Empty;
        #endregion

        protected override void DoLoadForm()
        {
            dbConString.Chk_ConnectionState();
            ShowData();
        }

        protected override void DoNew()
        {
            EvidenceInfo frmForm = new EvidenceInfo();
            frmForm.FormState = "new";
            frmForm.ShowDialog();
            btnStatus(true);
            ShowData();
        }

        protected override void DoEdit()
        {
            if (dgvEvidenceList.RowCount > 0)
            {
                EvidenceInfo frmForm = new EvidenceInfo();
                frmForm.FormState = "edit";
                frmForm.EvidenceID = dgvEvidenceList.Rows[SelectRowIndex].Cells[colEvidenceID.Name].Value.ToString();
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

            EvidenceID = dgvEvidenceList.Rows[SelectRowIndex].Cells[colEvidenceID.Name].Value.ToString();

            try
            {
                dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                StringBuilder StringBd = new StringBuilder();
                //dbConString.Transaction = new SqlTransaction();
                string sqlTmp = string.Empty;
                StringBd.Append("DELETE tbEvidence WHERE EvidenceID = @EvidenceID;");
                sqlTmp = "";
                sqlTmp = StringBd.ToString();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Transaction = dbConString.Transaction;
                dbConString.Com.Parameters.Clear();
                dbConString.Com.Parameters.Add("@EvidenceID", SqlDbType.VarChar).Value = EvidenceID;
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
                sqlTmp = "SELECT * FROM tbEvidence";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblEvidence.Clear();
                da.Fill(tblEvidence, "tbEvidence");
                da.Dispose();
                dgvEvidenceList.DataSource = tblEvidence.tbEvidence;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SelectRowIndex = -1;


        }

        private void dgvEvidenceList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEvidenceList.RowCount > 0)
            {
                EvidenceInfo frmForm = new EvidenceInfo();
                frmForm.FormState = "edit";
                frmForm.EvidenceID = dgvEvidenceList.Rows[SelectRowIndex].Cells[colEvidenceID.Name].Value.ToString();
                frmForm.ShowDialog();
                btnStatus(true);
            }
            ShowData();
        }

        private void dgvEvidenceList_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectRowIndex = e.RowIndex;
            btnStatus(false);
        }

        protected override void DoSearch()
        {
            string Whereclause = string.Empty;
            if (!string.IsNullOrEmpty(tsBtuSearch.Text))
            {
                Whereclause = tsBtuSearch.Text;
            }
            else
            {
                Whereclause = string.Empty;
            }

            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbEvidence";
                if (!string.IsNullOrEmpty(Whereclause))
                {
                    sqlTmp += " WHERE EvidenceCode LIKE '%" + Whereclause + "%' OR EvidenceName LIKE '%" + Whereclause + "%' OR EvidenceType LIKE '%" + Whereclause + "%' OR Detail LIKE '%" + Whereclause + "%'";
                }
                sqlTmp += " ORDER BY EvidenceCode";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblEvidence.Clear();
                da.Fill(tblEvidence, "tbEvidence");
                da.Dispose();
                dgvEvidenceList.DataSource = tblEvidence.tbEvidence;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SelectRowIndex = -1;
        }
    }
}
