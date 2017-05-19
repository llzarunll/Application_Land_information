using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application_Service.ClassService;

namespace Application_Service
{
    public partial class BaseListUserControl : UserControl
    {
        public BaseListUserControl()
        {
            InitializeComponent();
        }

        protected virtual void DoNew()
        { }

        protected virtual void DoEdit()
        { }

        protected virtual void DoDelete()
        { }

        protected virtual void DoReset()
        { }

        protected virtual void DoLoadForm()
        { }

        protected virtual void DoCloseForm()
        { }

        protected virtual void DoSearch()
        { }

        protected virtual void btnStatus(bool xStatus)//สถานะปุ่ม
        {

            if (xStatus == true)
            {
                //tsSave.Enabled = true;
                tsEdit.Enabled = false;
                tsDelete.Enabled = false;
            }
            else if (xStatus == false)
            {
                //tsSave.Enabled = false;
                tsEdit.Enabled = true;
                tsDelete.Enabled = true;
            }
        }

        protected virtual void DoVisibleSave(bool VisibleStatus)
        {
            tsSave.Visible = VisibleStatus;
            toolStripSeparator2.Visible = VisibleStatus;
        }

        protected virtual void DoVisibleEdit(bool VisibleStatus)
        {
            tsEdit.Visible = VisibleStatus;
            toolStripSeparator1.Visible = VisibleStatus;
        }

        protected virtual void DoVisibleDeleted(bool VisibleStatus)
        {
            tsDelete.Visible = VisibleStatus;
            toolStripSeparator3.Visible = VisibleStatus;
        }

        private void BaseListUserControl_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            btnStatus(true);
            DoLoadForm();
        }
        
        private void tsSave_Click(object sender, EventArgs e)
        {
            DoNew();
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
                DoCloseForm();
            }
        }

        private void tsBtuSearch_TextChanged(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
    }
}
