namespace Application_Form
{
    partial class EvidenceInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEvidenceCode = new System.Windows.Forms.TextBox();
            this.txtEvidenceName = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnPerview = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(10, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "รหัสพยาน/หลักฐาน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "ชื่อพยาน/หลักฐาน";
            // 
            // txtEvidenceCode
            // 
            this.txtEvidenceCode.Location = new System.Drawing.Point(152, 57);
            this.txtEvidenceCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEvidenceCode.MaxLength = 50;
            this.txtEvidenceCode.Name = "txtEvidenceCode";
            this.txtEvidenceCode.Size = new System.Drawing.Size(174, 24);
            this.txtEvidenceCode.TabIndex = 15;
            // 
            // txtEvidenceName
            // 
            this.txtEvidenceName.Location = new System.Drawing.Point(152, 89);
            this.txtEvidenceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEvidenceName.MaxLength = 100;
            this.txtEvidenceName.Name = "txtEvidenceName";
            this.txtEvidenceName.Size = new System.Drawing.Size(385, 24);
            this.txtEvidenceName.TabIndex = 16;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(152, 153);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetail.MaxLength = 500;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(385, 251);
            this.txtDetail.TabIndex = 19;
            this.txtDetail.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "รายละเอียด";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(152, 121);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(216, 24);
            this.txtPath.TabIndex = 21;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(374, 119);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(78, 28);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "เบราว์...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblAttachment
            // 
            this.lblAttachment.AutoSize = true;
            this.lblAttachment.Location = new System.Drawing.Point(10, 124);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(77, 17);
            this.lblAttachment.TabIndex = 23;
            this.lblAttachment.Text = "เอกสารแนบ";
            // 
            // btnPerview
            // 
            this.btnPerview.Location = new System.Drawing.Point(461, 119);
            this.btnPerview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPerview.Name = "btnPerview";
            this.btnPerview.Size = new System.Drawing.Size(36, 28);
            this.btnPerview.TabIndex = 122;
            this.btnPerview.Text = "P";
            this.btnPerview.UseVisualStyleBackColor = true;
            this.btnPerview.Click += new System.EventHandler(this.btnPerview_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(503, 119);
            this.btnclear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(34, 28);
            this.btnclear.TabIndex = 123;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // EvidenceInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(548, 417);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnPerview);
            this.Controls.Add(this.lblAttachment);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.txtEvidenceName);
            this.Controls.Add(this.txtEvidenceCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(564, 456);
            this.MinimumSize = new System.Drawing.Size(532, 456);
            this.Name = "EvidenceInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "พยาน/หลักฐาน";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtEvidenceCode, 0);
            this.Controls.SetChildIndex(this.txtEvidenceName, 0);
            this.Controls.SetChildIndex(this.txtDetail, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtPath, 0);
            this.Controls.SetChildIndex(this.btnBrowse, 0);
            this.Controls.SetChildIndex(this.lblAttachment, 0);
            this.Controls.SetChildIndex(this.btnPerview, 0);
            this.Controls.SetChildIndex(this.btnclear, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEvidenceCode;
        private System.Windows.Forms.TextBox txtEvidenceName;
        private System.Windows.Forms.RichTextBox txtDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnPerview;
        private System.Windows.Forms.Button btnclear;
    }
}