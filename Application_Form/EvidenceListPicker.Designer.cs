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
            this.colEvidenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.colEvidenceID,
            this.colEvidenceCode,
            this.colEvidenceName,
            this.colEvidenceType,
            this.colDetail,
            this.colPath,
            this.colCreatedBy,
            this.colCreatedDate});
            this.dgvEvidenceList.DataSource = this.tbEvidenceBindingSource;
            this.dgvEvidenceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvidenceList.Location = new System.Drawing.Point(0, 55);
            this.dgvEvidenceList.Name = "dgvEvidenceList";
            this.dgvEvidenceList.ReadOnly = true;
            this.dgvEvidenceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvidenceList.Size = new System.Drawing.Size(713, 380);
            this.dgvEvidenceList.TabIndex = 126;
            this.dgvEvidenceList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvidenceList_CellDoubleClick);
            // 
            // colEvidenceID
            // 
            this.colEvidenceID.DataPropertyName = "EvidenceID";
            this.colEvidenceID.HeaderText = "EvidenceID";
            this.colEvidenceID.Name = "colEvidenceID";
            this.colEvidenceID.ReadOnly = true;
            this.colEvidenceID.Visible = false;
            // 
            // colEvidenceCode
            // 
            this.colEvidenceCode.DataPropertyName = "EvidenceCode";
            this.colEvidenceCode.FillWeight = 30F;
            this.colEvidenceCode.HeaderText = "EvidenceCode";
            this.colEvidenceCode.Name = "colEvidenceCode";
            this.colEvidenceCode.ReadOnly = true;
            // 
            // colEvidenceName
            // 
            this.colEvidenceName.DataPropertyName = "EvidenceName";
            this.colEvidenceName.FillWeight = 40F;
            this.colEvidenceName.HeaderText = "EvidenceName";
            this.colEvidenceName.Name = "colEvidenceName";
            this.colEvidenceName.ReadOnly = true;
            // 
            // colEvidenceType
            // 
            this.colEvidenceType.DataPropertyName = "EvidenceType";
            this.colEvidenceType.FillWeight = 40F;
            this.colEvidenceType.HeaderText = "EvidenceType";
            this.colEvidenceType.Name = "colEvidenceType";
            this.colEvidenceType.ReadOnly = true;
            this.colEvidenceType.Visible = false;
            // 
            // colDetail
            // 
            this.colDetail.DataPropertyName = "Detail";
            this.colDetail.HeaderText = "Detail";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // colPath
            // 
            this.colPath.DataPropertyName = "Path";
            this.colPath.HeaderText = "Path";
            this.colPath.Name = "colPath";
            this.colPath.ReadOnly = true;
            this.colPath.Visible = false;
            // 
            // colCreatedBy
            // 
            this.colCreatedBy.DataPropertyName = "CreatedBy";
            this.colCreatedBy.HeaderText = "CreatedBy";
            this.colCreatedBy.Name = "colCreatedBy";
            this.colCreatedBy.ReadOnly = true;
            this.colCreatedBy.Visible = false;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.HeaderText = "CreatedDate";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            this.colCreatedDate.Visible = false;
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
        private System.Windows.Forms.BindingSource tbEvidenceBindingSource;
        private ApplicationData.ApplicationDS applicationDS1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvEvidenceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;

    }
}