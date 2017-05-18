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
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;
using Application_Service;
using Application_Form.ApplicationData;
using Application_Service.ClassService;
using Application_Report;
using Application_Report.Data;


namespace Application_Form
{
    public partial class LandInfo : BaseInfo
    {
        public LandInfo()
        {
            InitializeComponent();
            //InitializeGrid();
        }

        public string LandID = string.Empty;
        ApplicationDS tdsLand = new ApplicationDS();
        ApplicationDS tdsAddress = new ApplicationDS();
        ApplicationDS tdsTempDT = new ApplicationDS();
        ApplicationDS tdsTempDTMain = new ApplicationDS();
        string sqlTmp = string.Empty;
        string TempTimeLineHDID = string.Empty;
        ReportDS dsReport = new ReportDS();
        public static ApplicationDS.tbEvidenceRow drEvidenceTemp
        { get; set; }

        private void btnAreaPrint_Click(object sender, EventArgs e)
        {
            // Create a new instance of EvidenceInfoForm
        }

        protected override void DoLoadForm()
        {
            LoadProvince();

            switch (FormState.ToLower())
            {
                case "new":
                    LandID = string.Empty;
                    break;
                case "edit":
                    DoLoadData(LandID);
                    break;
                default:
                    FormState = "new";
                    LandID = string.Empty;
                    break;
            }
        }

        protected override void DoSave()
        {
            Success = true;
            DoCheckData();

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            dgvTimeLandDT.RefreshEdit();
            ApplicationDS.tbTimeLineDTRow[] drTempSave = (ApplicationDS.tbTimeLineDTRow[])tdsTempDT.tbTimeLineDT.Select("");
            if (drTempSave.Length > 0)
            {
                foreach (ApplicationDS.tbTimeLineDTRow drChk in drTempSave)
                {
                    ApplicationDS.tbTimeLineDTRow[] drTempChk = (ApplicationDS.tbTimeLineDTRow[])tdsTempDTMain.tbTimeLineDT.Select("TimeLineDTID = '" + drChk.TimeLineDTID + "'");
                    if (drTempChk.Length == 0)
                    {
                        tdsTempDTMain.tbTimeLineDT.ImportRow(drChk);
                    }
                }
            }

            switch (FormState.ToLower())
            {
                case "new":
                    #region Save
                    if (Success)
                    {
                        try
                        {
                            #region tbTimeLand
                            LandID = Guid.NewGuid().ToString();
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tbLand VALUES (@LandID,@VillageName,@VillageNo,@SubDistrict,@District,@Province,@History,@Distress,@CreatedBy,GETDATE())");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
                            dbConString.Com.Parameters.Add("@VillageName", SqlDbType.VarChar).Value = txtVillageName.Text;
                            dbConString.Com.Parameters.Add("@VillageNo", SqlDbType.VarChar).Value = txtVillageNo.Text;
                            dbConString.Com.Parameters.Add("@SubDistrict", SqlDbType.VarChar).Value = txtSubDistrict.Text;
                            dbConString.Com.Parameters.Add("@District", SqlDbType.VarChar).Value = txtDistrict.Text;
                            dbConString.Com.Parameters.Add("@Province", SqlDbType.VarChar).Value = txtProvince.Text;
                            dbConString.Com.Parameters.Add("@History", SqlDbType.VarChar).Value = txtHistory.Text;
                            dbConString.Com.Parameters.Add("@Distress", SqlDbType.VarChar).Value = txtDistress.Text;
                            dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                            dbConString.Com.ExecuteNonQuery();
                            
                            #endregion

                            #region
                            foreach (ApplicationDS.tbTimeLineHDRow drHD in tdsLand.tbTimeLineHD.Select(""))
                            {
                                StringBd.Clear();
                                sqlTmp = string.Empty;
                                StringBd.Append("INSERT INTO tbTimeLineHD VALUES (@TimeLineHDID,@LandID,@TimeLineDate,@TimeLineEvent,@Remark,@CreatedBy,GETDATE())");
                                sqlTmp = "";
                                sqlTmp = StringBd.ToString();
                                dbConString.Com = new SqlCommand();
                                dbConString.Com.CommandText = sqlTmp;
                                dbConString.Com.CommandType = CommandType.Text;
                                dbConString.Com.Connection = dbConString.mySQLConn;
                                dbConString.Com.Transaction = dbConString.Transaction;
                                dbConString.Com.Parameters.Clear();
                                dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = drHD.TimeLineHDID;
                                dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
                                dbConString.Com.Parameters.Add("@TimeLineDate", SqlDbType.DateTime).Value = drHD.TimeLineDate;
                                dbConString.Com.Parameters.Add("@TimeLineEvent", SqlDbType.VarChar).Value = drHD.TimeLineEvent;
                                dbConString.Com.Parameters.Add("@Remark", SqlDbType.VarChar).Value = drHD.Remark;
                                dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                                dbConString.Com.ExecuteNonQuery();
                            }
                            #endregion

                            #region
                            foreach (ApplicationDS.tbTimeLineDTRow drDT in tdsTempDTMain.tbTimeLineDT.Select(""))
                            {
                                StringBd.Clear();
                                sqlTmp = string.Empty;
                                StringBd.Append("INSERT INTO tbTimeLineDT VALUES (@TimeLineDTID,@TimeLineHDID,@EvidenceID,@CreatedBy,GETDATE())");
                                sqlTmp = "";
                                sqlTmp = StringBd.ToString();
                                dbConString.Com = new SqlCommand();
                                dbConString.Com.CommandText = sqlTmp;
                                dbConString.Com.CommandType = CommandType.Text;
                                dbConString.Com.Connection = dbConString.mySQLConn;
                                dbConString.Com.Transaction = dbConString.Transaction;
                                dbConString.Com.Parameters.Clear();
                                dbConString.Com.Parameters.Add("@TimeLineDTID", SqlDbType.VarChar).Value = drDT.TimeLineDTID;
                                dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = drDT.TimeLineHDID;
                                dbConString.Com.Parameters.Add("@EvidenceID", SqlDbType.VarChar).Value = drDT.EvidenceID;
                                dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                                dbConString.Com.ExecuteNonQuery();
                            }
                            #endregion

                            dbConString.Transaction.Commit();
                            FormState = "edit";
                            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                            StringBd.Append("UPDATE tbLand SET VillageName = @VillageName,VillageNo = @VillageNo,SubDistrict = @SubDistrict,District = @District,");
                            StringBd.Append(" Province = @Province,History = @History,Distress = @Distress,CreatedBy = @CreatedBy WHERE LandID = @LandID; ");
                            StringBd.Append(" DELETE DT FROM tbTimeLineDT AS DT  LEFT JOIN tbTimeLineHD AS HD ON DT.TimeLineHDID = HD.TimeLineHDID  WHERE HD.LandID = @LandID;");
                            StringBd.Append(" DELETE tbTimeLineHD WHERE LandID = @LandID;");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
                            dbConString.Com.Parameters.Add("@VillageName", SqlDbType.VarChar).Value = txtVillageName.Text;
                            dbConString.Com.Parameters.Add("@VillageNo", SqlDbType.VarChar).Value = txtVillageNo.Text;
                            dbConString.Com.Parameters.Add("@SubDistrict", SqlDbType.VarChar).Value = txtSubDistrict.Text;
                            dbConString.Com.Parameters.Add("@District", SqlDbType.VarChar).Value = txtDistrict.Text;
                            dbConString.Com.Parameters.Add("@Province", SqlDbType.VarChar).Value = txtProvince.Text;
                            dbConString.Com.Parameters.Add("@History", SqlDbType.VarChar).Value = txtHistory.Text;
                            dbConString.Com.Parameters.Add("@Distress", SqlDbType.VarChar).Value = txtDistress.Text;
                            dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                            dbConString.Com.ExecuteNonQuery();


                            #region
                            foreach (ApplicationDS.tbTimeLineHDRow drHD in tdsLand.tbTimeLineHD.Select(""))
                            {
                                StringBd.Clear();
                                sqlTmp = string.Empty;
                                StringBd.Append("INSERT INTO tbTimeLineHD VALUES (@TimeLineHDID,@LandID,@TimeLineDate,@TimeLineEvent,@Remark,@CreatedBy,GETDATE())");
                                sqlTmp = "";
                                sqlTmp = StringBd.ToString();
                                dbConString.Com = new SqlCommand();
                                dbConString.Com.CommandText = sqlTmp;
                                dbConString.Com.CommandType = CommandType.Text;
                                dbConString.Com.Connection = dbConString.mySQLConn;
                                dbConString.Com.Transaction = dbConString.Transaction;
                                dbConString.Com.Parameters.Clear();
                                dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = drHD.TimeLineHDID;
                                dbConString.Com.Parameters.Add("@LandID", SqlDbType.VarChar).Value = LandID;
                                dbConString.Com.Parameters.Add("@TimeLineDate", SqlDbType.DateTime).Value = drHD.TimeLineDate;
                                dbConString.Com.Parameters.Add("@TimeLineEvent", SqlDbType.VarChar).Value = drHD.TimeLineEvent;
                                dbConString.Com.Parameters.Add("@Remark", SqlDbType.VarChar).Value = drHD.Remark;
                                dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                                dbConString.Com.ExecuteNonQuery();
                            }
                            #endregion

                            #region
                            foreach (ApplicationDS.tbTimeLineDTRow drDT in tdsTempDTMain.tbTimeLineDT.Select(""))
                            {
                                StringBd.Clear();
                                sqlTmp = string.Empty;
                                StringBd.Append("INSERT INTO tbTimeLineDT VALUES (@TimeLineDTID,@TimeLineHDID,@EvidenceID,@CreatedBy,GETDATE())");
                                sqlTmp = "";
                                sqlTmp = StringBd.ToString();
                                dbConString.Com = new SqlCommand();
                                dbConString.Com.CommandText = sqlTmp;
                                dbConString.Com.CommandType = CommandType.Text;
                                dbConString.Com.Connection = dbConString.mySQLConn;
                                dbConString.Com.Transaction = dbConString.Transaction;
                                dbConString.Com.Parameters.Clear();
                                dbConString.Com.Parameters.Add("@TimeLineDTID", SqlDbType.VarChar).Value = drDT.TimeLineDTID;
                                dbConString.Com.Parameters.Add("@TimeLineHDID", SqlDbType.VarChar).Value = drDT.TimeLineHDID;
                                dbConString.Com.Parameters.Add("@EvidenceID", SqlDbType.VarChar).Value = drDT.EvidenceID;
                                dbConString.Com.Parameters.Add("@CreatedBy", SqlDbType.VarChar).Value = string.Empty;
                                dbConString.Com.ExecuteNonQuery();
                            }
                            #endregion



                            dbConString.Transaction.Commit();
                            #endregion
                            MessageBox.Show("บันทึกค่าเรียบร้อย", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch (Exception ex)
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

        private void DoLoadData(string LandID)
        {
            #region ALL Data
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbLand WHERE LandID = '" + LandID + "'";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tdsLand.Clear();
                da.Fill(tdsLand, "tbLand");
                da.Dispose();

                sqlTmp = "";
                sqlTmp = "SELECT * FROM tbTimeLineHD WHERE LandID = '" + LandID + "'";
                Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                da = new SqlDataAdapter(cmd);
                da.Fill(tdsLand, "tbTimeLineHD");
                da.Dispose();

                sqlTmp = "";
                sqlTmp = "SELECT DT.*,EV.EvidenceCode,EV.EvidenceName,EV.EvidenceType,EV.Detail,EV.Path FROM tbTimeLineDT AS DT LEFT JOIN tbTimeLineHD AS HD ON DT.TimeLineHDID = HD.TimeLineHDID LEFT JOIN tbEvidence AS EV ON DT.EvidenceID = EV.EvidenceID WHERE HD.LandID = '" + LandID + "'";
                Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                da = new SqlDataAdapter(cmd);
                tdsTempDTMain.Clear();
                da.Fill(tdsTempDTMain, "tbTimeLineDT");
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

            if (tdsLand.tbLand.Rows.Count > 0)
            {
                LandID = tdsLand.tbLand[0].LandID;
                txtVillageName.Text = tdsLand.tbLand[0].VillageName;
                txtVillageNo.Text = tdsLand.tbLand[0].VillageNo;
                txtSubDistrict.Text = tdsLand.tbLand[0].SubDistrict;
                txtDistrict.Text = tdsLand.tbLand[0].District;
                txtProvince.Text = tdsLand.tbLand[0].Province;
                txtHistory.Text = tdsLand.tbLand[0].History;
                txtDistress.Text = tdsLand.tbLand[0].Distress;
                //
                dgvTimeLandHD.DataSource = tdsLand.tbTimeLineHD;
            }
        }

        private void DoCheckData()
        {
            if (string.IsNullOrEmpty(txtVillageName.Text))
            {
                MessageBox.Show("VillageName is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtVillageName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtVillageNo.Text))
            {
                MessageBox.Show("VillageNo is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtVillageNo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtSubDistrict.Text))
            {
                MessageBox.Show("SubDistrict is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtSubDistrict.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDistrict.Text))
            {
                MessageBox.Show("District is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtDistrict.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtProvince.Text))
            {
                MessageBox.Show("Province is Empty", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtProvince.Focus();
                return;
            }
        }

        private void dgvTimeLandDT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string TimeLineDTID = Guid.NewGuid().ToString();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                EvidenceListPicker frm = new EvidenceListPicker();
                frm.ShowDialog();
                drEvidenceTemp = frm.drEvidence;
                if (drEvidenceTemp != null)
                {
                    dgvTimeLandDT.BeginEdit(true);
                    dgvTimeLandDT.Rows[e.RowIndex].Cells[colTimeLineHDIDDT.Name].Value = TempTimeLineHDID;
                    dgvTimeLandDT.Rows[e.RowIndex].Cells[colTimeLineDTID.Name].Value = TimeLineDTID;
                    dgvTimeLandDT.Rows[e.RowIndex].Cells[colEvidenceID.Name].Value = drEvidenceTemp.EvidenceID;
                    dgvTimeLandDT.Rows[e.RowIndex].Cells[colEvidenceCode.Name].Value = drEvidenceTemp.EvidenceCode;
                    dgvTimeLandDT.Rows[e.RowIndex].Cells[colEvidenceType.Name].Value = drEvidenceTemp.EvidenceType;
                    dgvTimeLandDT.Rows[e.RowIndex].Cells[colDetail.Name].Value = drEvidenceTemp.Detail;
                    dgvTimeLandDT.NotifyCurrentCellDirty(true);
                    dgvTimeLandDT.EndEdit();
                    dgvTimeLandDT.NotifyCurrentCellDirty(false);

                    ApplicationDS.tbTimeLineDTRow drTmpTimeLane = null;
                    drTmpTimeLane = tdsTempDT.tbTimeLineDT.NewtbTimeLineDTRow();
                    drTmpTimeLane.TimeLineHDID = TempTimeLineHDID;
                    drTmpTimeLane.TimeLineDTID = TimeLineDTID;
                    drTmpTimeLane.EvidenceID = drEvidenceTemp.EvidenceID;
                    drTmpTimeLane.EvidenceCode = drEvidenceTemp.EvidenceCode;
                    drTmpTimeLane.Detail= drEvidenceTemp.Detail;

                    ApplicationDS.tbTimeLineDTRow[] drTempChk = (ApplicationDS.tbTimeLineDTRow[])tdsTempDTMain.tbTimeLineDT.Select("TimeLineDTID = '" + TimeLineDTID + "'");
                    if (drTempChk.Length == 0)
                    {
                        tdsTempDTMain.tbTimeLineDT.ImportRow(drTmpTimeLane);
                    }
                        
                }
                dgvTimeLandDT.Refresh();
                
            }
        }

        private void dgvTimeLandHD_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                if (dgvTimeLandHD.Rows[e.RowIndex].Cells[colTimeLineHDID.Name].Value == null
                    || dgvTimeLandHD.Rows[e.RowIndex].Cells[colTimeLineHDID.Name].Value == "")
                {
                    dgvTimeLandHD.Rows[e.RowIndex-1].Cells[colTimeLineHDID.Name].Value = Guid.NewGuid().ToString();
                    dgvTimeLandHD.Refresh();
                }
            }
        }

        private void dgvTimeLandHD_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvTimeLandHD.Rows[e.RowIndex].Cells[colTimeLineHDID.Name].Value != null)
            {
                ApplicationDS.tbTimeLineDTRow[] drTempSave = (ApplicationDS.tbTimeLineDTRow[])tdsTempDT.tbTimeLineDT.Select("");
                if (drTempSave.Length > 0)
                {
                    foreach (ApplicationDS.tbTimeLineDTRow drChk in drTempSave)
                    {
                        ApplicationDS.tbTimeLineDTRow[] drTempChk = (ApplicationDS.tbTimeLineDTRow[])tdsTempDTMain.tbTimeLineDT.Select("TimeLineDTID = '" + drChk.TimeLineDTID + "'");
                        if (drTempChk.Length == 0)
                        {
                            tdsTempDTMain.tbTimeLineDT.ImportRow(drChk);
                        }
                    }
                }

                tdsTempDT.Clear();
                TempTimeLineHDID = dgvTimeLandHD.Rows[e.RowIndex].Cells[colTimeLineHDID.Name].Value.ToString();
                if(!string.IsNullOrEmpty(TempTimeLineHDID))
                {
                    ApplicationDS.tbTimeLineDTRow[] drTemp = (ApplicationDS.tbTimeLineDTRow[])tdsTempDTMain.tbTimeLineDT.Select("TimeLineHDID = '" + TempTimeLineHDID + "'");
                    foreach(ApplicationDS.tbTimeLineDTRow dr in drTemp)
                    {
                        tdsTempDT.tbTimeLineDT.ImportRow(dr);
                    }
                    dgvTimeLandDT.DataSource = tdsTempDT.tbTimeLineDT;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dsReport.tbLand.Rows.Count == 0)
            {
                ReportDS.tbLandRow drLand = dsReport.tbLand.NewtbLandRow();
                drLand.LandID = Guid.NewGuid().ToString();
                drLand.VillageName = txtVillageName.Text;
                drLand.VillageNo = txtVillageNo.Text;
                drLand.SubDistrict = txtSubDistrict.Text;
                drLand.District = txtDistrict.Text;
                drLand.Province = txtProvince.Text;
                dsReport.tbLand.AddtbLandRow(drLand);
            }

            // Create a new instance of EvidenceInfoForm
            ReportPreview ReportPreviewForm = new ReportPreview();
            // Pass Dataset to PreviewReport From
            ReportPreviewForm.GetDataSet = dsReport;
            // Display the form as top most form.
            ReportPreviewForm.TopMost = true;

            // Show the settings form
            ReportPreviewForm.Show();
        }

        private void LoadProvince()
        {
            #region ALL Data
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM uv_Address ";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tdsLand.Clear();
                da.Fill(tdsAddress, "uv_Address");
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion

            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            if (tdsAddress.uv_Address.Rows.Count > 0)
            {
                foreach (ApplicationDS.uv_AddressRow dr in tdsAddress.uv_Address.Select())
                {
                    namesCollection.Add(dr.PROVINCE_NAME.ToString());
                }
            }

            txtProvince.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProvince.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtProvince.AutoCompleteCustomSource = namesCollection;

            LoadDistrict();
            LoadSubDistrict();
        }

        private void LoadDistrict()
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            if (tdsAddress.uv_Address.Rows.Count > 0)
            {
                foreach (ApplicationDS.uv_AddressRow dr in tdsAddress.uv_Address.Select())
                {
                    namesCollection.Add(dr.AMPHUR_NAME.ToString());
                }
            }

            txtDistrict.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtDistrict.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDistrict.AutoCompleteCustomSource = namesCollection;
        }

        private void LoadSubDistrict()
        {
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            if (tdsAddress.uv_Address.Rows.Count > 0)
            {
                foreach (ApplicationDS.uv_AddressRow dr in tdsAddress.uv_Address.Select())
                {
                    namesCollection.Add(dr.DISTRICT_NAME.ToString());
                }
            }

            txtSubDistrict.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSubDistrict.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSubDistrict.AutoCompleteCustomSource = namesCollection;
        }

    }

}
