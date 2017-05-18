namespace Application_Form
{
    partial class LandInfo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDistress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHistory = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubDistrict = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVillageNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVillageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvTimeLandDT = new GenericDataGridView.GenericDataGridView(this.components);
            this.tbTimeLineDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicationDS2 = new Application_Form.ApplicationData.ApplicationDS();
            this.dgvTimeLandHD = new GenericDataGridView.GenericDataGridView(this.components);
            this.tbTimeLineHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.colTimeLineHDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineDate = new GenericDataGridView.GenericDataGridView.CalendarColumn();
            this.colTimeLineEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedByHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDateHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineDTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeLineHDIDDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbtnADD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEvidenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvidenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedByDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDateDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(701, 479);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDistress);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtHistory);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtProvince);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtDistrict);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtSubDistrict);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtVillageNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtVillageName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(693, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ข้อมูลพื้นที่";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDistress
            // 
            this.txtDistress.Location = new System.Drawing.Point(342, 143);
            this.txtDistress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistress.Name = "txtDistress";
            this.txtDistress.Size = new System.Drawing.Size(303, 213);
            this.txtDistress.TabIndex = 41;
            this.txtDistress.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "ปัญหาด้านที่ดินป่าไม้ของชุมชน ";
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(21, 143);
            this.txtHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.Size = new System.Drawing.Size(303, 213);
            this.txtHistory.TabIndex = 37;
            this.txtHistory.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "ประวัติความเป็นมาของชุมชน";
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(91, 79);
            this.txtProvince.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(233, 24);
            this.txtProvince.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "จังหวัด";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(412, 47);
            this.txtDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(233, 24);
            this.txtDistrict.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "อำเภอ";
            // 
            // txtSubDistrict
            // 
            this.txtSubDistrict.Location = new System.Drawing.Point(91, 47);
            this.txtSubDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubDistrict.Name = "txtSubDistrict";
            this.txtSubDistrict.Size = new System.Drawing.Size(233, 24);
            this.txtSubDistrict.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "ตำบล";
            // 
            // txtVillageNo
            // 
            this.txtVillageNo.Location = new System.Drawing.Point(412, 15);
            this.txtVillageNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVillageNo.Name = "txtVillageNo";
            this.txtVillageNo.Size = new System.Drawing.Size(233, 24);
            this.txtVillageNo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "หมู่";
            // 
            // txtVillageName
            // 
            this.txtVillageName.Location = new System.Drawing.Point(91, 15);
            this.txtVillageName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVillageName.Name = "txtVillageName";
            this.txtVillageName.Size = new System.Drawing.Size(233, 24);
            this.txtVillageName.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "ชื่อหมู่บ้าน";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPrint);
            this.tabPage3.Controls.Add(this.dgvTimeLandDT);
            this.tabPage3.Controls.Add(this.dgvTimeLandHD);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(693, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ลำดับเหตุการณ์";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(6, 7);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 28);
            this.btnPrint.TabIndex = 42;
            this.btnPrint.Text = "พิมพ์";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvTimeLandDT
            // 
            this.dgvTimeLandDT.AllowUserToDeleteRows = false;
            this.dgvTimeLandDT.AutoGenerateColumns = false;
            this.dgvTimeLandDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimeLandDT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimeLandDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeLandDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimeLineDTID,
            this.colTimeLineHDIDDT,
            this.colEvidenceID,
            this.colbtnADD,
            this.colEvidenceCode,
            this.colEvidenceType,
            this.colDetail,
            this.colCreatedByDT,
            this.CreatedDateDT});
            this.dgvTimeLandDT.DataColumns = null;
            this.dgvTimeLandDT.DataColumnsTable = null;
            this.dgvTimeLandDT.DataConnection = null;
            this.dgvTimeLandDT.DataSource = this.tbTimeLineDTBindingSource;
            this.dgvTimeLandDT.DBDateFormat = null;
            this.dgvTimeLandDT.Location = new System.Drawing.Point(8, 289);
            this.dgvTimeLandDT.Name = "dgvTimeLandDT";
            this.dgvTimeLandDT.ReadOnly = true;
            this.dgvTimeLandDT.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvTimeLandDT.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvTimeLandDT.Size = new System.Drawing.Size(677, 155);
            this.dgvTimeLandDT.TabIndex = 41;
            this.dgvTimeLandDT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeLandDT_CellContentClick);
            // 
            // tbTimeLineDTBindingSource
            // 
            this.tbTimeLineDTBindingSource.DataMember = "tbTimeLineDT";
            this.tbTimeLineDTBindingSource.DataSource = this.applicationDS2;
            // 
            // applicationDS2
            // 
            this.applicationDS2.DataSetName = "ApplicationDS";
            this.applicationDS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvTimeLandHD
            // 
            this.dgvTimeLandHD.AutoGenerateColumns = false;
            this.dgvTimeLandHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimeLandHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimeLandHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeLandHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTimeLineHDID,
            this.colLandID,
            this.colTimeLineDate,
            this.colTimeLineEvent,
            this.colRemark,
            this.colCreatedByHD,
            this.colCreatedDateHD});
            this.dgvTimeLandHD.DataColumns = null;
            this.dgvTimeLandHD.DataColumnsTable = null;
            this.dgvTimeLandHD.DataConnection = null;
            this.dgvTimeLandHD.DataSource = this.tbTimeLineHDBindingSource;
            this.dgvTimeLandHD.DBDateFormat = null;
            this.dgvTimeLandHD.Location = new System.Drawing.Point(8, 70);
            this.dgvTimeLandHD.Name = "dgvTimeLandHD";
            this.dgvTimeLandHD.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvTimeLandHD.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dgvTimeLandHD.Size = new System.Drawing.Size(677, 181);
            this.dgvTimeLandHD.TabIndex = 40;
            this.dgvTimeLandHD.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeLandHD_CellMouseUp);
            this.dgvTimeLandHD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTimeLandHD_RowsAdded);
            // 
            // tbTimeLineHDBindingSource
            // 
            this.tbTimeLineHDBindingSource.DataMember = "tbTimeLineHD";
            this.tbTimeLineHDBindingSource.DataSource = this.applicationDS2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "พยานหลักฐาน";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "ลำดับเหตุการณ์";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(598, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 28);
            this.button2.TabIndex = 35;
            this.button2.Text = "ค้นหา";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(406, 7);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(186, 24);
            this.textBox6.TabIndex = 34;
            // 
            // colTimeLineHDID
            // 
            this.colTimeLineHDID.DataPropertyName = "TimeLineHDID";
            this.colTimeLineHDID.HeaderText = "TimeLineHDID";
            this.colTimeLineHDID.Name = "colTimeLineHDID";
            this.colTimeLineHDID.Visible = false;
            // 
            // colLandID
            // 
            this.colLandID.DataPropertyName = "LandID";
            this.colLandID.HeaderText = "LandID";
            this.colLandID.Name = "colLandID";
            this.colLandID.Visible = false;
            // 
            // colTimeLineDate
            // 
            this.colTimeLineDate.DataPropertyName = "TimeLineDate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTimeLineDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTimeLineDate.FillWeight = 30F;
            this.colTimeLineDate.HeaderText = "วัน/เดือน/ปี ที่เกิดเหตุการณ์";
            this.colTimeLineDate.Name = "colTimeLineDate";
            this.colTimeLineDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTimeLineDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTimeLineEvent
            // 
            this.colTimeLineEvent.DataPropertyName = "TimeLineEvent";
            this.colTimeLineEvent.HeaderText = "เหตุการณ์";
            this.colTimeLineEvent.Name = "colTimeLineEvent";
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "หมายเหตุ";
            this.colRemark.Name = "colRemark";
            // 
            // colCreatedByHD
            // 
            this.colCreatedByHD.DataPropertyName = "CreatedBy";
            this.colCreatedByHD.HeaderText = "CreatedBy";
            this.colCreatedByHD.Name = "colCreatedByHD";
            this.colCreatedByHD.Visible = false;
            // 
            // colCreatedDateHD
            // 
            this.colCreatedDateHD.DataPropertyName = "CreatedDate";
            this.colCreatedDateHD.HeaderText = "CreatedDate";
            this.colCreatedDateHD.Name = "colCreatedDateHD";
            this.colCreatedDateHD.Visible = false;
            // 
            // colTimeLineDTID
            // 
            this.colTimeLineDTID.DataPropertyName = "TimeLineDTID";
            this.colTimeLineDTID.HeaderText = "TimeLineDTID";
            this.colTimeLineDTID.Name = "colTimeLineDTID";
            this.colTimeLineDTID.ReadOnly = true;
            this.colTimeLineDTID.Visible = false;
            // 
            // colTimeLineHDIDDT
            // 
            this.colTimeLineHDIDDT.DataPropertyName = "TimeLineHDID";
            this.colTimeLineHDIDDT.HeaderText = "TimeLineHDID";
            this.colTimeLineHDIDDT.Name = "colTimeLineHDIDDT";
            this.colTimeLineHDIDDT.ReadOnly = true;
            this.colTimeLineHDIDDT.Visible = false;
            // 
            // colEvidenceID
            // 
            this.colEvidenceID.DataPropertyName = "EvidenceID";
            this.colEvidenceID.HeaderText = "EvidenceID";
            this.colEvidenceID.Name = "colEvidenceID";
            this.colEvidenceID.ReadOnly = true;
            this.colEvidenceID.Visible = false;
            // 
            // colbtnADD
            // 
            this.colbtnADD.FillWeight = 20F;
            this.colbtnADD.HeaderText = "ADD";
            this.colbtnADD.Name = "colbtnADD";
            this.colbtnADD.ReadOnly = true;
            // 
            // colEvidenceCode
            // 
            this.colEvidenceCode.DataPropertyName = "EvidenceCode";
            this.colEvidenceCode.FillWeight = 30F;
            this.colEvidenceCode.HeaderText = "รหัสพยาน/หลักฐาน";
            this.colEvidenceCode.Name = "colEvidenceCode";
            this.colEvidenceCode.ReadOnly = true;
            // 
            // colEvidenceType
            // 
            this.colEvidenceType.DataPropertyName = "EvidenceType";
            this.colEvidenceType.FillWeight = 30F;
            this.colEvidenceType.HeaderText = "ชื่อพยาน/หลักฐาน";
            this.colEvidenceType.Name = "colEvidenceType";
            this.colEvidenceType.ReadOnly = true;
            // 
            // colDetail
            // 
            this.colDetail.DataPropertyName = "Detail";
            this.colDetail.HeaderText = "รายละเอียด";
            this.colDetail.Name = "colDetail";
            this.colDetail.ReadOnly = true;
            // 
            // colCreatedByDT
            // 
            this.colCreatedByDT.DataPropertyName = "CreatedBy";
            this.colCreatedByDT.HeaderText = "CreatedBy";
            this.colCreatedByDT.Name = "colCreatedByDT";
            this.colCreatedByDT.ReadOnly = true;
            this.colCreatedByDT.Visible = false;
            // 
            // CreatedDateDT
            // 
            this.CreatedDateDT.DataPropertyName = "CreatedDate";
            this.CreatedDateDT.HeaderText = "CreatedDate";
            this.CreatedDateDT.Name = "CreatedDateDT";
            this.CreatedDateDT.ReadOnly = true;
            this.CreatedDateDT.Visible = false;
            // 
            // LandInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 518);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(532, 427);
            this.Name = "LandInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ข้อมูลพื้นที่";
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationDS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeLandHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimeLineHDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubDistrict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVillageNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVillageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDistress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtHistory;
        private ApplicationData.ApplicationDS applicationDS;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private ApplicationData.ApplicationDS applicationDS1;
        private GenericDataGridView.GenericDataGridView dgvTimeLandDT;
        private GenericDataGridView.GenericDataGridView dgvTimeLandHD;
        private System.Windows.Forms.BindingSource tbTimeLineDTBindingSource;
        private ApplicationData.ApplicationDS applicationDS2;
        private System.Windows.Forms.BindingSource tbTimeLineHDBindingSource;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineHDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLandID;
        private GenericDataGridView.GenericDataGridView.CalendarColumn colTimeLineDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedByHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDateHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineDTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeLineHDIDDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceID;
        private System.Windows.Forms.DataGridViewButtonColumn colbtnADD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvidenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedByDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDateDT;
    }
}