namespace Application_Form
{
    partial class EvidenceList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEvidenceList = new System.Windows.Forms.DataGridView();
            this.tbEvidenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS1 = new Application_Form.ApplicationData.ApplicationDS();
            this.colEvidenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidenceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvidenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEvidenceList
            // 
            this.dgvEvidenceList.AllowUserToAddRows = false;
            this.dgvEvidenceList.AllowUserToDeleteRows = false;
            this.dgvEvidenceList.AutoGenerateColumns = false;
            this.dgvEvidenceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvidenceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvidenceList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEvidenceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvidenceList.Location = new System.Drawing.Point(0, 39);
            this.dgvEvidenceList.Name = "dgvEvidenceList";
            this.dgvEvidenceList.ReadOnly = true;
            this.dgvEvidenceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvidenceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvEvidenceList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEvidenceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvidenceList.Size = new System.Drawing.Size(729, 435);
            this.dgvEvidenceList.TabIndex = 123;
            this.dgvEvidenceList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEvidenceList_CellMouseDoubleClick);
            this.dgvEvidenceList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEvidenceList_CellMouseUp);
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
            this.colEvidenceCode.HeaderText = "รหัสพยาน/หลักฐาน";
            this.colEvidenceCode.Name = "colEvidenceCode";
            this.colEvidenceCode.ReadOnly = true;
            // 
            // colEvidenceName
            // 
            this.colEvidenceName.DataPropertyName = "EvidenceName";
            this.colEvidenceName.FillWeight = 40F;
            this.colEvidenceName.HeaderText = "ชื่อพยาน/หลักฐาน";
            this.colEvidenceName.Name = "colEvidenceName";
            this.colEvidenceName.ReadOnly = true;
            // 
            // colEvidenceType
            // 
            this.colEvidenceType.DataPropertyName = "EvidenceType";
            this.colEvidenceType.FillWeight = 30F;
            this.colEvidenceType.HeaderText = "EvidenceType";
            this.colEvidenceType.Name = "colEvidenceType";
            this.colEvidenceType.ReadOnly = true;
            this.colEvidenceType.Visible = false;
            // 
            // colDetail
            // 
            this.colDetail.DataPropertyName = "Detail";
            this.colDetail.HeaderText = "รายละเอียด";
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
            // EvidenceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEvidenceList);
            this.Name = "EvidenceList";
            this.Size = new System.Drawing.Size(729, 474);
            this.Controls.SetChildIndex(this.dgvEvidenceList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidenceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEvidenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEvidenceList;
        private System.Windows.Forms.BindingSource tbEvidenceBindingSource;
        private ApplicationData.ApplicationDS applicationDS1;
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