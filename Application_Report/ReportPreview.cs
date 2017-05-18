using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Service.ClassService;
using Application_Report.Data;
using System.Data.SqlClient;

namespace Application_Report
{
    public partial class ReportPreview : Form
    {
        public ReportPreview()
        {
            InitializeComponent();
        }

        #region Member
        ReportDS tblReport = new ReportDS();
        #endregion Member

        #region Properties
        public ReportDS GetDataSet
        {
            get { return tblReport; }
            set { tblReport = value; }
        }
        #endregion Properties

        private void ReportPreview_Load(object sender, EventArgs e)
        {
            // Copy data to Data Temp
            ReportDS dsTemp = new ReportDS();
            dsTemp.tbLand.ImportRow(tblReport.tbLand[0]);

            // Select data from Database
            dbConString.Chk_ConnectionState();
            
            string sqlTmp = "SELECT * FROM uv_Timeline ORDER BY TimeLineDate, EvidenceCode, EvidenceName";
            TimelineReport fReport = new TimelineReport();
            DataSet Ds = new DataSet();
            dbConString.Com = new SqlCommand();
            dbConString.Com.CommandType = CommandType.Text;
            dbConString.Com.CommandText = sqlTmp;
            dbConString.Com.Connection = dbConString.mySQLConn;
            SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tblReport.Clear();
            
            da.Fill(tblReport, "uv_Timeline");
            da.Dispose();

            //// Import data from Data Temp to main dataset
            //tblReport.tbLand.ImportRow(dsTemp.tbLand[0]);

            fReport.SetDataSource(tblReport);
            fReport.SetParameterValue("VillageNo", dsTemp.tbLand[0].VillageNo.ToString());
            fReport.SetParameterValue("VillageName", dsTemp.tbLand[0].VillageName.ToString());
            fReport.SetParameterValue("SubDistrict", dsTemp.tbLand[0].SubDistrict.ToString());
            fReport.SetParameterValue("District", dsTemp.tbLand[0].District.ToString());
            fReport.SetParameterValue("Province", dsTemp.tbLand[0].Province.ToString());
            crvTimeline.ReportSource = fReport;
        }
    }
}
