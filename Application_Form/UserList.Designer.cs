namespace Application_Form
{
    partial class UserList
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
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.ColUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS = new Application_Form.ApplicationData.ApplicationDS();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserList
            // 
            this.dgvUserList.AllowUserToAddRows = false;
            this.dgvUserList.AllowUserToDeleteRows = false;
            this.dgvUserList.AutoGenerateColumns = false;
            this.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColUserID,
            this.ColUserName,
            this.ColPassword,
            this.ColDetail,
            this.ColCreatedBy,
            this.ColCreatedDate});
            this.dgvUserList.DataSource = this.tbUserBindingSource;
            this.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserList.Location = new System.Drawing.Point(0, 39);
            this.dgvUserList.MultiSelect = false;
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.ReadOnly = true;
            this.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserList.Size = new System.Drawing.Size(864, 457);
            this.dgvUserList.TabIndex = 124;
            this.dgvUserList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserList_CellContentDoubleClick);
            this.dgvUserList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserList_CellMouseDoubleClick);
            this.dgvUserList.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserList_CellMouseUp);
            // 
            // ColUserID
            // 
            this.ColUserID.DataPropertyName = "UserID";
            this.ColUserID.HeaderText = "UserID";
            this.ColUserID.Name = "ColUserID";
            this.ColUserID.ReadOnly = true;
            this.ColUserID.Visible = false;
            // 
            // ColUserName
            // 
            this.ColUserName.DataPropertyName = "UserName";
            this.ColUserName.FillWeight = 30F;
            this.ColUserName.HeaderText = "ชื่อผู้ใช้";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.ReadOnly = true;
            // 
            // ColPassword
            // 
            this.ColPassword.DataPropertyName = "Password";
            this.ColPassword.HeaderText = "Password";
            this.ColPassword.Name = "ColPassword";
            this.ColPassword.ReadOnly = true;
            this.ColPassword.Visible = false;
            // 
            // ColDetail
            // 
            this.ColDetail.DataPropertyName = "Detail";
            this.ColDetail.HeaderText = "รายละเอียด";
            this.ColDetail.Name = "ColDetail";
            this.ColDetail.ReadOnly = true;
            // 
            // ColCreatedBy
            // 
            this.ColCreatedBy.DataPropertyName = "CreatedBy";
            this.ColCreatedBy.HeaderText = "CreatedBy";
            this.ColCreatedBy.Name = "ColCreatedBy";
            this.ColCreatedBy.ReadOnly = true;
            this.ColCreatedBy.Visible = false;
            // 
            // ColCreatedDate
            // 
            this.ColCreatedDate.DataPropertyName = "CreatedDate";
            this.ColCreatedDate.HeaderText = "CreatedDate";
            this.ColCreatedDate.Name = "ColCreatedDate";
            this.ColCreatedDate.ReadOnly = true;
            this.ColCreatedDate.Visible = false;
            // 
            // tbUserBindingSource
            // 
            this.tbUserBindingSource.DataMember = "tbUser";
            this.tbUserBindingSource.DataSource = this.applicationDS;
            // 
            // applicationDS
            // 
            this.applicationDS.DataSetName = "ApplicationDS";
            this.applicationDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvUserList);
            this.Name = "UserList";
            this.Controls.SetChildIndex(this.dgvUserList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserList;
        private System.Windows.Forms.BindingSource tbUserBindingSource;
        private Application_Form.ApplicationData.ApplicationDS applicationDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCreatedDate;
    }
}