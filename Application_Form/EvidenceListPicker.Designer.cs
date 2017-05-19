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
            this.tbEvidenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS1 = new Application_Form.ApplicationData.ApplicationDS();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvEvidenceList = new System.Windows.Forms.DataGridView();
            this.EvidenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvidenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvidenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvidenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvidenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidenceList)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 55);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(603, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(28, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(569, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvEvidenceList
            // 
            this.dgvEvidenceList.AllowUserToAddRows = false;
            this.dgvEvidenceList.AllowUserToDeleteRows = false;
            this.dgvEvidenceList.AutoGenerateColumns = false;
            this.dgvEvidenceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvidenceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidenceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvidenceID,
            this.EvidenceCode,
            this.EvidenceName,
            this.EvidenceType,
            this.Detail,
            this.Path,
            this.CreatedBy,
            this.CreatedDate});
            this.dgvEvidenceList.DataSource = this.tbEvidenceBindingSource;
            this.dgvEvidenceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvidenceList.Location = new System.Drawing.Point(0, 55);
            this.dgvEvidenceList.Name = "dgvEvidenceList";
            this.dgvEvidenceList.ReadOnly = true;
            this.dgvEvidenceList.Size = new System.Drawing.Size(713, 380);
            this.dgvEvidenceList.TabIndex = 126;
            this.dgvEvidenceList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvidenceList_CellDoubleClick);
            // 
            // EvidenceID
            // 
            this.EvidenceID.DataPropertyName = "EvidenceID";
            this.EvidenceID.HeaderText = "EvidenceID";
            this.EvidenceID.Name = "EvidenceID";
            this.EvidenceID.ReadOnly = true;
            this.EvidenceID.Visible = false;
            // 
            // EvidenceCode
            // 
            this.EvidenceCode.DataPropertyName = "EvidenceCode";
            this.EvidenceCode.FillWeight = 30F;
            this.EvidenceCode.HeaderText = "EvidenceCode";
            this.EvidenceCode.Name = "EvidenceCode";
            this.EvidenceCode.ReadOnly = true;
            // 
            // EvidenceName
            // 
            this.EvidenceName.DataPropertyName = "EvidenceName";
            this.EvidenceName.FillWeight = 40F;
            this.EvidenceName.HeaderText = "EvidenceName";
            this.EvidenceName.Name = "EvidenceName";
            this.EvidenceName.ReadOnly = true;
            // 
            // EvidenceType
            // 
            this.EvidenceType.DataPropertyName = "EvidenceType";
            this.EvidenceType.FillWeight = 40F;
            this.EvidenceType.HeaderText = "EvidenceType";
            this.EvidenceType.Name = "EvidenceType";
            this.EvidenceType.ReadOnly = true;
            this.EvidenceType.Visible = false;
            // 
            // Detail
            // 
            this.Detail.DataPropertyName = "Detail";
            this.Detail.HeaderText = "Detail";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Visible = false;
            // 
            // CreatedBy
            // 
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "CreatedBy";
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.ReadOnly = true;
            this.CreatedBy.Visible = false;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "CreatedDate";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Visible = false;
            // 
            // EvidenceListPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 435);
            this.Controls.Add(this.dgvEvidenceList);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "EvidenceListPicker";
            this.Load += new System.EventHandler(this.EvidenceListPicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbEvidenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidenceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ApplicationData.ApplicationDS applicationDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.BindingSource tbEvidenceBindingSource;
        private ApplicationData.ApplicationDS applicationDS1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvEvidenceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;

    }
}