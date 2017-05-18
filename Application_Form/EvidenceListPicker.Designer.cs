namespace Application_Form
{
    partial class EvidenceListPicker
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
            this.dgvEvidenceList = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.colEvidenceID = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colEvidenceCode = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colEvidenceName = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colEvidenceType = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colDetail = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colPath = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCreatedBy = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.colCreatedDate = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.tbEvidenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS1 = new Application_Form.ApplicationData.ApplicationDS();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvidenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEvidenceList
            // 
            this.dgvEvidenceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvidenceList.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.dgvEvidenceList.Location = new System.Drawing.Point(0, 55);
            this.dgvEvidenceList.Name = "dgvEvidenceList";
            // 
            // 
            // 
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colEvidenceID);
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colEvidenceCode);
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colEvidenceName);
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colEvidenceType);
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colDetail);
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colPath);
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colCreatedBy);
            this.dgvEvidenceList.PrimaryGrid.Columns.Add(this.colCreatedDate);
            this.dgvEvidenceList.PrimaryGrid.DataSource = this.tbEvidenceBindingSource;
            this.dgvEvidenceList.PrimaryGrid.MultiSelect = false;
            this.dgvEvidenceList.PrimaryGrid.SelectionGranularity = DevComponents.DotNetBar.SuperGrid.SelectionGranularity.Row;
            this.dgvEvidenceList.Size = new System.Drawing.Size(713, 380);
            this.dgvEvidenceList.TabIndex = 124;
            this.dgvEvidenceList.Text = "superGridControl1";
            this.dgvEvidenceList.CellDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridCellDoubleClickEventArgs>(this.dgvEvidenceList_CellDoubleClick);
            // 
            // colEvidenceID
            // 
            this.colEvidenceID.DataPropertyName = "EvidenceID";
            this.colEvidenceID.HeaderText = "EvidenceID";
            this.colEvidenceID.Name = "EvidenceID";
            this.colEvidenceID.Visible = false;
            // 
            // colEvidenceCode
            // 
            this.colEvidenceCode.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colEvidenceCode.DataPropertyName = "EvidenceCode";
            this.colEvidenceCode.FillWeight = 40;
            this.colEvidenceCode.HeaderText = "EvidenceCode";
            this.colEvidenceCode.Name = "EvidenceCode";
            // 
            // colEvidenceName
            // 
            this.colEvidenceName.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colEvidenceName.DataPropertyName = "EvidenceName";
            this.colEvidenceName.FillWeight = 50;
            this.colEvidenceName.HeaderText = "EvidenceName";
            this.colEvidenceName.Name = "EvidenceName";
            // 
            // colEvidenceType
            // 
            this.colEvidenceType.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colEvidenceType.DataPropertyName = "EvidenceType";
            this.colEvidenceType.FillWeight = 40;
            this.colEvidenceType.HeaderText = "EvidenceType";
            this.colEvidenceType.Name = "EvidenceType";
            // 
            // colDetail
            // 
            this.colDetail.AutoSizeMode = DevComponents.DotNetBar.SuperGrid.ColumnAutoSizeMode.Fill;
            this.colDetail.DataPropertyName = "Detail";
            this.colDetail.HeaderText = "Detail";
            this.colDetail.Name = "Detail";
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "Path";
            this.colPath.HeaderText = "Path";
            this.colPath.Name = "Path";
            this.colPath.Visible = false;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.DataPropertyName = "CreatedBy";
            this.colCreatedBy.HeaderText = "CreatedBy";
            this.colCreatedBy.Name = "CreatedBy";
            this.colCreatedBy.Visible = false;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridDateTimeInputEditControl);
            this.colCreatedDate.HeaderText = "CreatedDate";
            this.colCreatedDate.Name = "CreatedDate";
            this.colCreatedDate.Visible = false;
            // 
            // tbEvidenceBindingSource
            // 
            this.tbEvidenceBindingSource.DataMember = "tbEvidence";
            this.tbEvidenceBindingSource.DataSource = this.applicationDS1;
            // 
            // applicationDS1
            // 
            this.applicationDS1.DataSetName = "ApplicationDS";
            this.applicationDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 55);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(569, 20);
            this.textBox1.TabIndex = 0;
            // 
            // EvidenceListPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.dgvEvidenceList);
            this.Controls.Add(this.groupBox1);
            this.Name = "EvidenceListPicker";
            this.Load += new System.EventHandler(this.EvidenceListPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbEvidenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationData.ApplicationDS applicationDS;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl dgvEvidenceList;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colEvidenceID;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colEvidenceCode;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colEvidenceName;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colEvidenceType;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colDetail;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colPath;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCreatedDate;
        private System.Windows.Forms.BindingSource tbEvidenceBindingSource;
        private ApplicationData.ApplicationDS applicationDS1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn colCreatedBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}