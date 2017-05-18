namespace Application_Form
{
    partial class LandList
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
            this.dgvLandList = new System.Windows.Forms.DataGridView();
            this.colLandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVillageName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVillageNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistrict = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbLandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS = new Application_Form.ApplicationData.ApplicationDS();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLandList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLandList
            // 
            this.dgvLandList.AllowUserToAddRows = false;
            this.dgvLandList.AllowUserToDeleteRows = false;
            this.dgvLandList.AutoGenerateColumns = false;
            this.dgvLandList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLandList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLandList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLandList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLandID,
            this.colVillageName,
            this.colVillageNo,
            this.colSubDistrict,
            this.colDistrict,
            this.colProvince,
            this.colHistory,
            this.colDistress,
            this.colCreatedBy,
            this.colCreatedDate});
            this.dgvLandList.DataSource = this.tbLandBindingSource;
            this.dgvLandList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLandList.Location = new System.Drawing.Point(0, 39);
            this.dgvLandList.Name = "dgvLandList";
            this.dgvLandList.ReadOnly = true;
            this.dgvLandList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLandList.Size = new System.Drawing.Size(729, 435);
            this.dgvLandList.TabIndex = 123;
            this.dgvLandList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLandList_CellMouseDoubleClick);
            this.dgvLandList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLandList_CellMouseUp);
            // 
            // colLandID
            // 
            this.colLandID.DataPropertyName = "LandID";
            this.colLandID.HeaderText = "LandID";
            this.colLandID.Name = "colLandID";
            this.colLandID.ReadOnly = true;
            this.colLandID.Visible = false;
            // 
            // colVillageName
            // 
            this.colVillageName.DataPropertyName = "VillageName";
            this.colVillageName.HeaderText = "ชื่อหมู่บ้าน";
            this.colVillageName.Name = "colVillageName";
            this.colVillageName.ReadOnly = true;
            // 
            // colVillageNo
            // 
            this.colVillageNo.DataPropertyName = "VillageNo";
            this.colVillageNo.HeaderText = "หมู่ที่";
            this.colVillageNo.Name = "colVillageNo";
            this.colVillageNo.ReadOnly = true;
            // 
            // colSubDistrict
            // 
            this.colSubDistrict.DataPropertyName = "SubDistrict";
            this.colSubDistrict.HeaderText = "ตำบล";
            this.colSubDistrict.Name = "colSubDistrict";
            this.colSubDistrict.ReadOnly = true;
            // 
            // colDistrict
            // 
            this.colDistrict.DataPropertyName = "District";
            this.colDistrict.HeaderText = "อำเภอ";
            this.colDistrict.Name = "colDistrict";
            this.colDistrict.ReadOnly = true;
            // 
            // colProvince
            // 
            this.colProvince.DataPropertyName = "Province";
            this.colProvince.HeaderText = "จังหวัด";
            this.colProvince.Name = "colProvince";
            this.colProvince.ReadOnly = true;
            // 
            // colHistory
            // 
            this.colHistory.DataPropertyName = "History";
            this.colHistory.HeaderText = "History";
            this.colHistory.Name = "colHistory";
            this.colHistory.ReadOnly = true;
            this.colHistory.Visible = false;
            // 
            // colDistress
            // 
            this.colDistress.DataPropertyName = "Distress";
            this.colDistress.HeaderText = "Distress";
            this.colDistress.Name = "colDistress";
            this.colDistress.ReadOnly = true;
            this.colDistress.Visible = false;
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
            // tbLandBindingSource
            // 
            this.tbLandBindingSource.DataMember = "tbLand";
            this.tbLandBindingSource.DataSource = this.applicationDS;
            // 
            // applicationDS
            // 
            this.applicationDS.DataSetName = "ApplicationDS";
            this.applicationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LandList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLandList);
            this.Name = "LandList";
            this.Size = new System.Drawing.Size(729, 474);
            this.Controls.SetChildIndex(this.dgvLandList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLandList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLandList;
        private System.Windows.Forms.BindingSource tbLandBindingSource;
        private ApplicationData.ApplicationDS applicationDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVillageName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVillageNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistrict;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
    }
}