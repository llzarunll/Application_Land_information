using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GenericDataGridView
{


    public partial class popupForm : Form
    {

        DataTable m_dtTable;
        public int selectedRowValue;
        public popupForm()
        {
            InitializeComponent();
        }


        public void fillGrid(DataTable m_dtTable1)
        {
            m_dtTable = m_dtTable1;
            this.dataGridView1.DataSource = m_dtTable;
        }

        //public void DatagridViewDblClick(object sender, EventArgs e)
        //{
        //    int selectedRowIndex=-1;
        //    if (this.dataGridView1.SelectedRows.Count>0)
        //    {
        //        selectedRowIndex = this.dataGridView1.SelectedRows[0].Index;
        //    }
        //    if (selectedRowIndex != -1)
        //    {
        //        // this.Parent.Text = Convert.ToString(this.dataGridView1.Rows[selectedRowIndex].Cells["VL"].Value);
        //        //selectedRowValue = Convert.ToInt32(this.dataGridView1.Rows[selectedRowIndex].Cells["VL"].Value);
        //        selectedRowValue = selectedRowIndex;
        //        this.Close();
        //    }
        //}
        
    }

     
}