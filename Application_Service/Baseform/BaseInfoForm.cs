using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Service.ClassService;

namespace Application_Service
{
    public partial class BaseInfoForm : Form
    {
        public BaseInfoForm()
        {
            InitializeComponent();
        }

        protected virtual void DoSave()
        { 
        
        }

        protected virtual void DoEdit()
        { 
        
        }

        protected virtual void DoDelete()
        { 
        
        }

        protected virtual void DoReset()
        {
            
        }

        protected virtual void DoLoadForm()
        { }

        protected virtual void DoPrint()
        { }
        protected virtual void DoVibletsPrint(bool IsShow)
        {
            tsPrint.Visible = IsShow;
        }

        private void BaseInfoForm_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            btnStatus(true);
            DoLoadForm();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            DoSave();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            DoEdit();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            DoDelete();
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            btnStatus(true);
            DoReset();
        }

        private void tsClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("คุณต้องการปิดหน้าจอ ใช่หรือไม่ ?", dbConString.xMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            DoPrint();
        }

        protected virtual void btnStatus(bool xStatus)//สถานะปุ่ม
        {

            if (xStatus == true)
            {
                tsSave.Enabled = true;
                tsEdit.Enabled = false;
                tsDelete.Enabled = false;
            }
            else if (xStatus == false)
            {
                tsSave.Enabled = false;
                tsEdit.Enabled = true;
                tsDelete.Enabled = true;
            }
        }
    }
}
