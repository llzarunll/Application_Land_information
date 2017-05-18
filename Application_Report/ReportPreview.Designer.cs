namespace Application_Report
{
    partial class ReportPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Application_Service.BaseInfo));
            this.crvTimeline = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvTimeline
            // 
            this.crvTimeline.ActiveViewIndex = -1;
            this.crvTimeline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvTimeline.CachedPageNumberPerDoc = 10;
            this.crvTimeline.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvTimeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvTimeline.Location = new System.Drawing.Point(0, 0);
            this.crvTimeline.Name = "crvTimeline";
            this.crvTimeline.Size = new System.Drawing.Size(1044, 463);
            this.crvTimeline.TabIndex = 0;
            this.crvTimeline.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportPreview
            // 
            this.ClientSize = new System.Drawing.Size(1044, 463);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Controls.Add(this.crvTimeline);
            this.Text = "รายงานลำดับเหตุการณ์";
            this.Name = "ReportPreview";
            this.Load += new System.EventHandler(this.ReportPreview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvTimeline;
    }
}