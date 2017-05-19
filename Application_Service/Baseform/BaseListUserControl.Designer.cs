namespace Application_Service
{
    partial class BaseListUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseListUserControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.tsClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSearch = new System.Windows.Forms.ToolStripButton();
            this.tsBtuSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tblDealerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDealerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSave,
            this.toolStripSeparator2,
            this.tsEdit,
            this.toolStripSeparator1,
            this.tsDelete,
            this.toolStripSeparator3,
            this.tsClose,
            this.tsClear,
            this.toolStripSeparator5,
            this.toolStripSeparator4,
            this.tsSearch,
            this.tsBtuSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(864, 39);
            this.toolStrip1.TabIndex = 123;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // tsSave
            // 
            this.tsSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSave.Image = global::Application_Service.Properties.Resources.Add;
            this.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(65, 36);
            this.tsSave.Text = "เพิ่ม";
            this.tsSave.Click += new System.EventHandler(this.tsSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsEdit
            // 
            this.tsEdit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsEdit.Image = global::Application_Service.Properties.Resources.Edit;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(75, 36);
            this.tsEdit.Text = "แก้ไข";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsDelete
            // 
            this.tsDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDelete.Image = global::Application_Service.Properties.Resources.Delete2;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(60, 36);
            this.tsDelete.Text = "ลบ";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsClose
            // 
            this.tsClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(60, 36);
            this.tsClose.Text = "ปิด";
            this.tsClose.Visible = false;
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // tsClear
            // 
            this.tsClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsClear.Image = global::Application_Service.Properties.Resources.Reset;
            this.tsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(64, 36);
            this.tsClear.Text = "ล้าง";
            this.tsClear.Visible = false;
            this.tsClear.Click += new System.EventHandler(this.tsClear_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            this.toolStripSeparator5.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // tsSearch
            // 
            this.tsSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsSearch.Image = global::Application_Service.Properties.Resources.Search;
            this.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(74, 36);
            this.tsSearch.Text = "ค้นหา";
            this.tsSearch.Click += new System.EventHandler(this.tsSearch_Click);
            // 
            // tsBtuSearch
            // 
            this.tsBtuSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtuSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsBtuSearch.Name = "tsBtuSearch";
            this.tsBtuSearch.Size = new System.Drawing.Size(300, 39);
            this.tsBtuSearch.TextChanged += new System.EventHandler(this.tsBtuSearch_TextChanged);
            // 
            // BaseListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "BaseListUserControl";
            this.Size = new System.Drawing.Size(864, 496);
            this.Load += new System.EventHandler(this.BaseListUserControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDealerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tblDealerBindingSource;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource1;
        private System.Windows.Forms.BindingSource tblEmployeeBindingSource;
        private System.Windows.Forms.BindingSource pOSBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsSearch;
        public System.Windows.Forms.ToolStripTextBox tsBtuSearch;
    }
}
