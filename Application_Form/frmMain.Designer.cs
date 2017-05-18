namespace Application_Form
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnLand = new System.Windows.Forms.Button();
            this.btnEvidence = new System.Windows.Forms.Button();
            this.pnSetting = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.tabPageMain = new System.Windows.Forms.TabControl();
            this.pnMenu.SuspendLayout();
            this.pnSetting.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnMenu.Controls.Add(this.btnUser);
            this.pnMenu.Controls.Add(this.btnLand);
            this.pnMenu.Controls.Add(this.btnEvidence);
            this.pnMenu.Controls.Add(this.pnSetting);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(234, 576);
            this.pnMenu.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnUser.Location = new System.Drawing.Point(3, 426);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(224, 68);
            this.btnUser.TabIndex = 5;
            this.btnUser.Text = "ข้อมูลผู้ใช้";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnLand
            // 
            this.btnLand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLand.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLand.Location = new System.Drawing.Point(3, 79);
            this.btnLand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(224, 68);
            this.btnLand.TabIndex = 4;
            this.btnLand.Text = "ข้อมูลพื้นที่";
            this.btnLand.UseVisualStyleBackColor = true;
            this.btnLand.Click += new System.EventHandler(this.btnLand_Click);
            // 
            // btnEvidence
            // 
            this.btnEvidence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvidence.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEvidence.Location = new System.Drawing.Point(3, 4);
            this.btnEvidence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEvidence.Name = "btnEvidence";
            this.btnEvidence.Size = new System.Drawing.Size(224, 68);
            this.btnEvidence.TabIndex = 3;
            this.btnEvidence.Text = "พยาน/หลักฐาน";
            this.btnEvidence.UseVisualStyleBackColor = true;
            this.btnEvidence.Click += new System.EventHandler(this.btnEvidence_Click);
            // 
            // pnSetting
            // 
            this.pnSetting.Controls.Add(this.btnClose);
            this.pnSetting.Controls.Add(this.btnSetting);
            this.pnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSetting.Location = new System.Drawing.Point(0, 501);
            this.pnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnSetting.Name = "pnSetting";
            this.pnSetting.Size = new System.Drawing.Size(234, 75);
            this.pnSetting.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(119, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 69);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSetting.Location = new System.Drawing.Point(3, 4);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(111, 69);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "ตั้งค่า";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.White;
            this.pnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMain.BackgroundImage")));
            this.pnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnMain.Controls.Add(this.tabPageMain);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(234, 0);
            this.pnMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(646, 576);
            this.pnMain.TabIndex = 1;
            this.pnMain.Visible = false;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPageMain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tabPageMain.Location = new System.Drawing.Point(0, 0);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.SelectedIndex = 0;
            this.tabPageMain.ShowToolTips = true;
            this.tabPageMain.Size = new System.Drawing.Size(646, 71);
            this.tabPageMain.TabIndex = 3;
            this.tabPageMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabPageMain_DrawItem);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 576);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.pnMenu.ResumeLayout(false);
            this.pnSetting.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLand;
        private System.Windows.Forms.Button btnEvidence;
        private System.Windows.Forms.Panel pnSetting;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.TabControl tabPageMain;
    }
}