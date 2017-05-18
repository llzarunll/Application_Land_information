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
        string EvidenceID = string.Empty;
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
                dgvEvidenceList.PrimaryGrid.DataSource = tblEvidence.tbEvidence;
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

        private void dgvEvidenceList_CellDoubleClick(object sender, GridCellDoubleClickEventArgs e)
        {
            drEvidence = tblEvidence.tbEvidence.NewtbEvidenceRow();
            drEvidence.EvidenceID = e.GridCell.GridRow[colEvidenceID].Value.ToString();
            drEvidence.EvidenceCode = e.GridCell.GridRow[colEvidenceCode].Value.ToString();
            drEvidence.EvidenceType = e.GridCell.GridRow[colEvidenceType].Value.ToString();
            drEvidence.Detail = e.GridCell.GridRow[colDetail].Value.ToString();
            drEvidence.Path = e.GridCell.GridRow[colPath].Value.ToString();
            this.Close();
        }
    }
}
