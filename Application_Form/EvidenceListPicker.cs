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
using DevComponents.DotNetBar.SuperGrid;
using Application_Service;
using Application_Form.ApplicationData;
using Application_Service.ClassService;

namespace Application_Form
{
    public partial class EvidenceListPicker : Form
    {
        public EvidenceListPicker()
        {
            InitializeComponent();
        }

        #region
        ApplicationDS tblEvidence = new ApplicationDS();
        int SelectRowIndex = -1;
        public ApplicationDS.tbEvidenceRow drEvidence = null;
        #endregion


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
                //dgvEvidenceList.bi = tblEvidence.tbEvidence;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            SelectRowIndex = -1;
        }

        private void EvidenceListPicker_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            ShowData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void dgvEvidenceList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            drEvidence = tblEvidence.tbEvidence.NewtbEvidenceRow();

            drEvidence.EvidenceID = dgvEvidenceList.Rows[e.RowIndex].Cells[colEvidenceID.Name].Value.ToString();
            drEvidence.EvidenceCode = dgvEvidenceList.Rows[e.RowIndex].Cells[colEvidenceCode.Name].Value.ToString();
            drEvidence.EvidenceName = dgvEvidenceList.Rows[e.RowIndex].Cells[colEvidenceName.Name].Value.ToString();
            drEvidence.EvidenceType = dgvEvidenceList.Rows[e.RowIndex].Cells[colEvidenceType.Name].Value.ToString();
            drEvidence.Detail = dgvEvidenceList.Rows[e.RowIndex].Cells[colDetail.Name].Value.ToString();
            drEvidence.Path = dgvEvidenceList.Rows[e.RowIndex].Cells[colPath.Name].Value.ToString();
            this.Close();
        }

        private void DoSearch()
        {
            string Whereclause = string.Empty;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                Whereclause = txtSearch.Text;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
    }
}
