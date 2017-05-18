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
using Application_Service.ClassService;

namespace Application_Form
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlDataReader Dr;
        const int LEADING_SPACE = 12;
        const int CLOSE_SPACE = 15;
        const int CLOSE_AREA = 15;
        private void frmMain_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            tabPageMain.Visible = false;
            // Set the IsMdiContainer property to true.
            IsMdiContainer = true;
            pnMain.Visible = true;

            DoLoadSettingPath();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEvidence_Click(object sender, EventArgs e)
        {
            if (!CheckTab("tabEvidence"))
            {
                tabPageMain.Visible = true;
                tabPageMain.Dock = DockStyle.Fill;
                EvidenceList f_FormControl = new EvidenceList();
                f_FormControl.Dock = DockStyle.Fill;
                TabPage Tab_New = new TabPage();//Create new tabpage
                Tab_New.Controls.Add(f_FormControl);
                Tab_New.Text = "ข้อมูลพยาน/หลักฐาน";
                Tab_New.Name = "tabEvidence";
                tabPageMain.Controls.Add(Tab_New);
                tabPageMain.SelectedTab = Tab_New;

            }
        }

        private void btnLand_Click(object sender, EventArgs e)
        {
            if (!CheckTab("tabLand"))
            {
                tabPageMain.Visible = true;
                tabPageMain.Dock = DockStyle.Fill;
                LandList f_FormControl = new LandList();
                f_FormControl.Dock = DockStyle.Fill;
                TabPage Tab_New = new TabPage();//Create new tabpage
                Tab_New.Controls.Add(f_FormControl);
                Tab_New.Text = "ข้อมูลพื้นที่";
                Tab_New.Name = "tabLand";
                tabPageMain.Controls.Add(Tab_New);
                tabPageMain.SelectedTab = Tab_New;
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!CheckTab("tabUser"))
            {
                tabPageMain.Visible = true;
                tabPageMain.Dock = DockStyle.Fill;
                UserList f_FormControl = new UserList();
                f_FormControl.Dock = DockStyle.Fill;
                TabPage Tab_New = new TabPage();//Create new tabpage
                Tab_New.Controls.Add(f_FormControl);
                Tab_New.Text = "ข้อมูลผู้ใช้";
                Tab_New.Name = "tabUser";
                tabPageMain.Controls.Add(Tab_New);
                tabPageMain.SelectedTab = Tab_New;

            }

        }

        private void btnNewEvidence_Click(object sender, EventArgs e)
        {
            // Create a new instance of EvidenceInfoForm
            EvidenceInfo EvidenceInfoForm = new EvidenceInfo();

            // Display the form as top most form.
            EvidenceInfoForm.TopMost = true;

            // Show the settings form
            EvidenceInfoForm.Show();
        }

        private void btnNewLand_Click(object sender, EventArgs e)
        {
            // Create a new instance of LandInfoForm
            LandInfo LandInfoForm = new LandInfo();

            // Display the form as top most form.
            LandInfoForm.TopMost = true;

            // Show the settings form
            LandInfoForm.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnMain.Visible = true;

            // Create a new instance of EvidenceInfoForm
            SettingInfo SettingInfoForm = new SettingInfo();

            // Display the form as top most form.
            SettingInfoForm.TopMost = true;

            // Show the settings form
            SettingInfoForm.Show();
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            pnMain.Visible = false;
            if (this.ActiveMdiChild == null)
                tabPageMain.Visible = false; // If no any child form, hide tabControl
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized; // Child form always maximized

                // If child form is new and no has tabPage, create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child form caption
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabPageMain;
                    tabPageMain.SelectedTab = tp;

                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabPageMain.Visible) tabPageMain.Visible = true;
            }
        }

        // If child form closed, remove tabPage
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        #region Function
        private void CloseAllChildForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void DoLoadSettingPath()
        {
            #region tbSettingPath
            bool Duplicate = true;
            int Count = 0;

            DataSet Ds = new DataSet();
            try
            {
                string sqlTmp = "";

                sqlTmp = "SELECT * FROM tbSettingPath";

                dbConString.Com = new SqlCommand();
                dbConString.Com.CommandType = CommandType.Text;
                dbConString.Com.CommandText = sqlTmp;
                dbConString.Com.Connection = dbConString.mySQLConn;
                dbConString.Com.Parameters.Clear();
                Dr = dbConString.Com.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (Dr.HasRows)
            {
                Dr.Read();
                string TempPath = Dr.GetString(Dr.GetOrdinal("SettingPath")).ToString();

                dbConString.SettingPath = TempPath;
                Dr.Close();
            }
            else
            {
                Dr.Close();
                SettingInfo frmShow = new SettingInfo();
                frmShow.ShowDialog();                
            }

            #endregion
        }
        #endregion

        private void tabPageMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - CLOSE_AREA, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabPageMain.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + LEADING_SPACE, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private bool CheckTab(string TabName)
        {
            bool found = false;
            foreach (TabPage tab in tabPageMain.TabPages)
            {
                if (TabName.Equals(tab.Name))
                {
                    tabPageMain.SelectedTab = tab;
                    found = true;
                }
            }
            return found;
        }
    }

}
