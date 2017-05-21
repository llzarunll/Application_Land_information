using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Form.ApplicationData;
using Application_Service;
using Application_Service.ClassService;
using DocExp;
    
namespace Application_Form
{
    public partial class EvidenceInfo : BaseInfo
    {
        public EvidenceInfo()
        {
            InitializeComponent();
        }

        #region
        public string EvidenceID = string.Empty;
        ApplicationDS tblEvidence = new ApplicationDS();
        string sqlTmp = string.Empty;
        #endregion

        protected override void DoLoadForm()
        {
            btnPerview.Enabled = false;

            switch (FormState.ToLower())
            {
                case "new":
                    EvidenceID = string.Empty;
                    break;
                case "edit":
                    DoLoadData(EvidenceID);
                    break;
                default:
                    EvidenceID = string.Empty;
                    break;
            }
        }

        private void DoLoadData(string EvidenceID)
        {
            #region tbUser
            try
            {
                string sqlTmp = "";
                sqlTmp = "SELECT * FROM tbEvidence WHERE EvidenceID = '" + EvidenceID + "'";
                DataSet Ds = new DataSet();
                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                SqlCommand cmd = new SqlCommand(sqlTmp, dbConString.mySQLConn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                tblEvidence.Clear();
                da.Fill(tblEvidence, "tbEvidence");
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
            if (tblEvidence.tbEvidence.Rows.Count > 0)
            {
                EvidenceID = tblEvidence.tbEvidence[0].EvidenceID;
                txtEvidenceCode.Text = tblEvidence.tbEvidence[0].EvidenceCode;
                txtEvidenceName.Text = tblEvidence.tbEvidence[0].EvidenceName;
                txtPath.Text = tblEvidence.tbEvidence[0].Path;
                //cboEvidenceType.Text = tblEvidence.tbEvidence[0].EvidenceType;
                txtDetail.Text = tblEvidence.tbEvidence[0].Detail;
            }

            if (string.IsNullOrEmpty(txtPath.Text))
                btnPerview.Enabled = false;
            else
                btnPerview.Enabled = true;
        }

        private void DoCheckData()
        {
            if (string.IsNullOrEmpty(txtEvidenceCode.Text))
            {
                MessageBox.Show("รหัสพยาน/หลักฐานไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtEvidenceCode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtEvidenceName.Text))
            {
                MessageBox.Show("ชื่อพยาน/หลักฐานไม่สามารถเป็นค่าว่างได้ กรุณาป้อนข้อมูล", "Warning", MessageBoxButtons.OK);
                Success = false;
                txtEvidenceName.Focus();
                return;
            }

            //if (cboEvidenceType.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Evidence Type is Empty", "Warning", MessageBoxButtons.OK);
            //    Success = false;
            //    cboEvidenceType.Focus();
            //    return;
            //}
        }

        protected override void DoSave()
        {
            Success = true;
            DoCheckData();

            if (!Success)
                return;

            //Check Duplicate
            if (Success == true && tblEvidence.tbEvidence.Rows.Count > 0)
            {
                Success = Utilities.CheckDuplicateNotInOldValues(tblEvidence.tbEvidence.TableName,
                                                                tblEvidence.tbEvidence.EvidenceCodeColumn.ColumnName,
                                                                txtEvidenceCode.Text,
                                                                tblEvidence.tbEvidence[0].EvidenceCode);
                if (!Success)
                {
                    MessageBox.Show("รหัสพยาน/หลักฐานไม่สามารถซ้ำได้ กรุณาป้อนข้อมูลใหม่", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    return;
                }
            }
            else
            {
                Success = Utilities.CheckDuplicate(tblEvidence.tbEvidence.TableName,
                                                  tblEvidence.tbEvidence.EvidenceCodeColumn.ColumnName,
                                                  txtEvidenceCode.Text);
                if (!Success)
                {
                    MessageBox.Show("ชื่อพยาน/หลักฐานไม่สามารถซ้ำได้ กรุณาป้อนข้อมูลใหม่", "คำเตือน", MessageBoxButtons.OK);
                    Success = false;
                    return;
                }
            }

            if (MessageBox.Show("คุณต้องการบันทึกข้อมูล ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            #region
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                if (File.Exists(txtPath.Text))
                {
                    string sourcePath = Path.GetDirectoryName(txtPath.Text);
                    string destinationPath = dbConString.SettingPath + @"\" + txtEvidenceCode.Text + @"\";
                    string sourceFileName = Path.GetFileName(txtPath.Text);
                    //string destinationFileName = DateTime.Now.ToString("yyyyMMddhhmmss") + ".xml"; // Don't mind this. I did this because I needed to name the copied files with respect to time.
                    string sourceFile = System.IO.Path.Combine(sourcePath, sourceFileName);
                    string destinationFile = System.IO.Path.Combine(destinationPath, sourceFileName);
                    txtPath.Text = dbConString.SettingPath + @"\" + txtEvidenceCode.Text + @"\" + sourceFileName;

                    if (!Directory.Exists(destinationPath))
                    {
                        Directory.CreateDirectory(destinationPath);
                    }
                    File.Copy(sourceFile, destinationFile, true);
                }
            }
            #endregion

            switch (FormState.ToLower())
            {
                case "new":
                    #region Save
                    if (Success)
                    {
                        try
                        {
                            #region tbUser
                            EvidenceID = Guid.NewGuid().ToString();
                            dbConString.Transaction = dbConString.mySQLConn.BeginTransaction();
                            StringBuilder StringBd = new StringBuilder();
                            StringBd.Clear();
                            sqlTmp = string.Empty;
                            StringBd.Append("INSERT INTO tbEvidence VALUES (@EvidenceID,@EvidenceCode,@EvidenceName,@EvidenceType,@Detail,@Path,@CreatedBy,GETDATE())");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@EvidenceID", SqlDbType.VarChar).Value = EvidenceID;
                            dbConString.Com.Parameters.Add("@EvidenceCode", SqlDbType.VarChar).Value = txtEvidenceCode.Text;
                            dbConString.Com.Parameters.Add("@EvidenceName", SqlDbType.VarChar).Value = txtEvidenceName.Text;
                            dbConString.Com.Parameters.Add("@EvidenceType", SqlDbType.VarChar).Value = string.Empty;
                            dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = txtDetail.Text;
                            dbConString.Com.Parameters.Add("@Path", SqlDbType.VarChar).Value = txtPath.Text;
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
                            StringBd.Append("UPDATE tbEvidence SET EvidenceCode = @EvidenceCode, EvidenceName = @EvidenceName, EvidenceType = @EvidenceType,");
                            StringBd.Append("Detail = @Detail, Path = @Path WHERE EvidenceID = @EvidenceID");
                            sqlTmp = "";
                            sqlTmp = StringBd.ToString();

                            dbConString.Com = new SqlCommand();
                            dbConString.Com.CommandText = sqlTmp;
                            dbConString.Com.CommandType = CommandType.Text;
                            dbConString.Com.Connection = dbConString.mySQLConn;
                            dbConString.Com.Transaction = dbConString.Transaction;
                            dbConString.Com.Parameters.Clear();
                            dbConString.Com.Parameters.Add("@EvidenceID", SqlDbType.VarChar).Value = EvidenceID;
                            dbConString.Com.Parameters.Add("@EvidenceCode", SqlDbType.VarChar).Value = txtEvidenceCode.Text;
                            dbConString.Com.Parameters.Add("@EvidenceName", SqlDbType.VarChar).Value = txtEvidenceName.Text;
                            dbConString.Com.Parameters.Add("@EvidenceType", SqlDbType.VarChar).Value = string.Empty;
                            dbConString.Com.Parameters.Add("@Detail", SqlDbType.VarChar).Value = txtDetail.Text;
                            dbConString.Com.Parameters.Add("@Path", SqlDbType.VarChar).Value = txtPath.Text;
                            dbConString.Com.ExecuteNonQuery();
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

        private void btnPerview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                if (File.Exists(txtPath.Text))
                {
                    frmPerview frm = new frmPerview();
                    frm.strPath = txtPath.Text;
                    frm.ShowDialog();
                    btnPerview.Enabled = true;
                }
                else
                {
                    MessageBox.Show("ไม่พบ File ", dbConString.xMessage, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string sFileName = choofdlog.FileName;
                txtPath.Text = sFileName;
                string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true 
                btnPerview.Enabled = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtPath.Clear();
            btnPerview.Enabled = false;
        }
    }
}
