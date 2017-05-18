namespace DocExp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ilExplorer = new System.Windows.Forms.ImageList(this.components);
            this.sc = new System.Windows.Forms.SplitContainer();
            this.lvExplorer = new System.Windows.Forms.ListView();
            this.cm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.iconSize = new System.Windows.Forms.TrackBar();
            this.btnShowPreview = new System.Windows.Forms.Button();
            this.ilButtons = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.btnClosePreview = new System.Windows.Forms.Button();
            this.fsw = new System.IO.FileSystemWatcher();
            this.ilContext = new System.Windows.Forms.ImageList(this.components);
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.SuspendLayout();
            // 
            // ilExplorer
            // 
            this.ilExplorer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilExplorer.ImageStream")));
            this.ilExplorer.TransparentColor = System.Drawing.Color.Transparent;
            this.ilExplorer.Images.SetKeyName(0, "NetworkDrive");
            this.ilExplorer.Images.SetKeyName(1, "CDDVD");
            this.ilExplorer.Images.SetKeyName(2, "Drive");
            this.ilExplorer.Images.SetKeyName(3, "FolderUp");
            this.ilExplorer.Images.SetKeyName(4, "Folder");
            this.ilExplorer.Images.SetKeyName(5, "Pdf");
            this.ilExplorer.Images.SetKeyName(6, "Gif");
            this.ilExplorer.Images.SetKeyName(7, "Jpg");
            this.ilExplorer.Images.SetKeyName(8, "*");
            this.ilExplorer.Images.SetKeyName(9, "Png");
            this.ilExplorer.Images.SetKeyName(10, "Mp3");
            this.ilExplorer.Images.SetKeyName(11, "Wav");
            this.ilExplorer.Images.SetKeyName(12, "Wma");
            this.ilExplorer.Images.SetKeyName(13, "Wmv");
            this.ilExplorer.Images.SetKeyName(14, "Avi");
            this.ilExplorer.Images.SetKeyName(15, "Html");
            this.ilExplorer.Images.SetKeyName(16, "Jpeg");
            this.ilExplorer.Images.SetKeyName(17, "Htm");
            this.ilExplorer.Images.SetKeyName(18, "Mpg");
            this.ilExplorer.Images.SetKeyName(19, "Bmp");
            this.ilExplorer.Images.SetKeyName(20, "Txt");
            this.ilExplorer.Images.SetKeyName(21, "Tif");
            this.ilExplorer.Images.SetKeyName(22, "Mid");
            this.ilExplorer.Images.SetKeyName(23, "Rtf");
            this.ilExplorer.Images.SetKeyName(24, "Docx");
            this.ilExplorer.Images.SetKeyName(25, "Dox");
            this.ilExplorer.Images.SetKeyName(26, "Xlsx");
            this.ilExplorer.Images.SetKeyName(27, "Xls");
            this.ilExplorer.Images.SetKeyName(28, "Ppt");
            this.ilExplorer.Images.SetKeyName(29, "Pptx");
            this.ilExplorer.Images.SetKeyName(30, "Pps");
            this.ilExplorer.Images.SetKeyName(31, "Ppsx");
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.lvExplorer);
            this.sc.Panel1.Controls.Add(this.pnlBottom);
            this.sc.Panel1.Controls.Add(this.panel1);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.pnlPreview);
            this.sc.Panel2.Controls.Add(this.btnClosePreview);
            this.sc.Panel2Collapsed = true;
            this.sc.Size = new System.Drawing.Size(905, 474);
            this.sc.SplitterDistance = 301;
            this.sc.TabIndex = 1;
            // 
            // lvExplorer
            // 
            this.lvExplorer.ContextMenuStrip = this.cm;
            this.lvExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvExplorer.LargeImageList = this.ilExplorer;
            this.lvExplorer.Location = new System.Drawing.Point(0, 21);
            this.lvExplorer.Name = "lvExplorer";
            this.lvExplorer.Size = new System.Drawing.Size(905, 426);
            this.lvExplorer.SmallImageList = this.ilExplorer;
            this.lvExplorer.TabIndex = 6;
            this.lvExplorer.UseCompatibleStateImageBehavior = false;
            this.lvExplorer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvExplorer_MouseDoubleClick);
            this.lvExplorer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvExplorer_MouseClick);
            // 
            // cm
            // 
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(61, 4);
            this.cm.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cm_ItemClicked);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.iconSize);
            this.pnlBottom.Controls.Add(this.btnShowPreview);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 447);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(905, 27);
            this.pnlBottom.TabIndex = 5;
            // 
            // iconSize
            // 
            this.iconSize.AutoSize = false;
            this.iconSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconSize.LargeChange = 32;
            this.iconSize.Location = new System.Drawing.Point(0, 0);
            this.iconSize.Maximum = 128;
            this.iconSize.Minimum = 16;
            this.iconSize.Name = "iconSize";
            this.iconSize.Size = new System.Drawing.Size(788, 27);
            this.iconSize.SmallChange = 16;
            this.iconSize.TabIndex = 2;
            this.iconSize.TickFrequency = 16;
            this.iconSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.iconSize.Value = 32;
            this.iconSize.ValueChanged += new System.EventHandler(this.iconSize_ValueChanged);
            // 
            // btnShowPreview
            // 
            this.btnShowPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPreview.ImageIndex = 1;
            this.btnShowPreview.ImageList = this.ilButtons;
            this.btnShowPreview.Location = new System.Drawing.Point(788, 0);
            this.btnShowPreview.Name = "btnShowPreview";
            this.btnShowPreview.Size = new System.Drawing.Size(117, 27);
            this.btnShowPreview.TabIndex = 1;
            this.btnShowPreview.Text = "Show Preview";
            this.btnShowPreview.UseVisualStyleBackColor = true;
            this.btnShowPreview.Click += new System.EventHandler(this.btnShowPreview_Click);
            // 
            // ilButtons
            // 
            this.ilButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButtons.ImageStream")));
            this.ilButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButtons.Images.SetKeyName(0, "refresh.png");
            this.ilButtons.Images.SetKeyName(1, "navigate_right2.png");
            this.ilButtons.Images.SetKeyName(2, "navigate_left2.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 21);
            this.panel1.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.White;
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPath.Location = new System.Drawing.Point(0, 0);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(878, 20);
            this.txtPath.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.ImageIndex = 0;
            this.btnRefresh.ImageList = this.ilButtons;
            this.btnRefresh.Location = new System.Drawing.Point(878, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(27, 21);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlPreview
            // 
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPreview.Location = new System.Drawing.Point(0, 0);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(96, 77);
            this.pnlPreview.TabIndex = 1;
            // 
            // btnClosePreview
            // 
            this.btnClosePreview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClosePreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClosePreview.ImageKey = "navigate_left2.png";
            this.btnClosePreview.ImageList = this.ilButtons;
            this.btnClosePreview.Location = new System.Drawing.Point(0, 77);
            this.btnClosePreview.Name = "btnClosePreview";
            this.btnClosePreview.Size = new System.Drawing.Size(96, 23);
            this.btnClosePreview.TabIndex = 0;
            this.btnClosePreview.Text = "Close Preview";
            this.btnClosePreview.UseVisualStyleBackColor = true;
            this.btnClosePreview.Click += new System.EventHandler(this.btnClosePreview_Click);
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.SynchronizingObject = this;
            this.fsw.Renamed += new System.IO.RenamedEventHandler(this.fsw_Renamed);
            this.fsw.Deleted += new System.IO.FileSystemEventHandler(this.fsw_Deleted);
            this.fsw.Created += new System.IO.FileSystemEventHandler(this.fsw_Created);
            this.fsw.Changed += new System.IO.FileSystemEventHandler(this.fsw_Changed);
            // 
            // ilContext
            // 
            this.ilContext.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilContext.ImageStream")));
            this.ilContext.TransparentColor = System.Drawing.Color.Transparent;
            this.ilContext.Images.SetKeyName(0, "Copy");
            this.ilContext.Images.SetKeyName(1, "Delete");
            this.ilContext.Images.SetKeyName(2, "Preview");
            this.ilContext.Images.SetKeyName(3, "Move");
            this.ilContext.Images.SetKeyName(4, "Open");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(905, 474);
            this.Controls.Add(this.sc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Document Explorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            this.sc.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.ImageList ilExplorer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ContextMenuStrip cm;
        private System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Button btnClosePreview;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnShowPreview;
        private System.Windows.Forms.ListView lvExplorer;
        private System.Windows.Forms.ImageList ilContext;
        private System.Windows.Forms.ImageList ilButtons;
        private System.Windows.Forms.TrackBar iconSize;
    }
}

