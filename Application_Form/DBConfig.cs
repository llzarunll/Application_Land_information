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
using Application_Service.Data;

namespace Application_Form
{
    public partial class DBConfig : Form
    {
        public DBConfig()
        {
            InitializeComponent();
        }

        LoginDS tblLogin = new LoginDS();

        private void btnCheck_Click(object sender, EventArgs e)
        {
            bool IsChk = true;
            try
            {
                dbConString.ServerName = txtServerName.Text.Trim();
                dbConString.DBName = txtDatabaseName.Text.Trim();
                dbConString.Sa = txtUsername.Text.Trim();
                dbConString.SaPassword = txtPassword.Text.Trim();
                IsChk = dbConString.CheckOpenConn();
                if (IsChk)
                {
                    if (tblLogin.DBProfile.Count > 0)
                    {
                        tblLogin.DBProfile[0].ServerName = txtServerName.Text.Trim();
                        tblLogin.DBProfile[0].DataBase = txtDatabaseName.Text.Trim();
                        tblLogin.DBProfile[0].DBLogin = txtUsername.Text.Trim();
                        tblLogin.DBProfile[0].DBPassword = txtPassword.Text.Trim();
                    }
                    else
                    {
                        LoginDS.DBProfileRow dr = tblLogin.DBProfile.NewDBProfileRow();
                        dr.ServerName = txtServerName.Text.Trim();
                        dr.DataBase = txtDatabaseName.Text.Trim();
                        dr.DBLogin = txtUsername.Text.Trim();
                        dr.DBPassword = txtPassword.Text.Trim();
                        tblLogin.DBProfile.AddDBProfileRow(dr);
                    }
                    ProfileConfig.Save(tblLogin);
                    MessageBox.Show("บันทึกข้อูลตั้งค่า ระบบฐานข้อมูล", "Land_information", MessageBoxButtons.OK);
                }                
            }
            catch
            {
                MessageBox.Show("ข้อูลตั้งค่า ระบบฐานข้อมูล ไม่ถูกต้องกรุณาตรวจสอบ", "คำเตือน", MessageBoxButtons.OK);
                txtServerName.Focus();
                return;
            }

            
        }

        private void DBConfig_Load(object sender, EventArgs e)
        {
            tblLogin = ProfileConfig.Load();
            if (tblLogin.DBProfile.Count > 0)
            {

                txtServerName.Text = tblLogin.DBProfile[0].ServerName;
                txtDatabaseName.Text = tblLogin.DBProfile[0].DataBase;
                txtUsername.Text = tblLogin.DBProfile[0].DBLogin;
                txtPassword.Text = tblLogin.DBProfile[0].DBPassword;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
