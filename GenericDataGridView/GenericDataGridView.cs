using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace GenericDataGridView
{
    public partial class GenericDataGridView : DataGridView
    {
        string m_DataColumns;
        string m_DataColumnsRaw;
        string m_DataColumnsTable;
        string m_DataConnection;
        string m_DBDateFormat;
        DataTable mMultipleComboboxDatatable;
        System.Data.DataTable dtValidation = new System.Data.DataTable("ValidationTable");
        // System.Windows.Forms.MaskedTextBox btDown = new Button();


        public enum ValidationStyle
        {
            NumericInt, NumericDouble, Email, Date
        }

        public GenericDataGridView()
        {
            InitializeComponent();
        }

        public GenericDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region New Properties

        // [Browsable(false), EditorBrowsable(EditorBrowsableState.Always)] 
        [Browsable(true)]
        public string DataColumns
        {
            get
            {
                return m_DataColumnsRaw;
            }
            set
            {
                m_DataColumnsRaw = value;
                //m_DataColumns = value.Replace("%", "");
                //m_DataColumns = m_DataColumns.Replace("-", "");
            }
        }

        [Browsable(true)]
        public string DataColumnsTable
        {
            get
            {
                return m_DataColumnsTable;
            }
            set
            {
                m_DataColumnsTable = value;

            }
        }

        //public bool ExcelExportButton
        //{
        //    get
        //    {
        //        return m_ExcelExportButton;
        //    }
        //    set
        //    {
        //        m_ExcelExportButton = value;
        //        if (value == true)
        //        {
        //            if (btDown.Text != "->")
        //            {
        //                btDown.Text = "->";
        //                btDown.Location = new System.Drawing.Point(this.Location.X, this.Location.Y - 30);
        //                btDown.Click += new EventHandler(BtDownOnClick);
        //                this.Parent.Controls.Add(btDown);
        //            }
        //        }
        //        btDown.Visible = value;
        //     }
        //}

        //public void BtDownOnClick(object sender, EventArgs e)
        //{

        //}

        [Browsable(true)]
        public string DataConnection
        {
            get
            {
                return m_DataConnection;
            }
            set
            {
                m_DataConnection = value;
            }
        }

        [Browsable(true)]
        public string DBDateFormat
        {
            get
            {
                return m_DBDateFormat;
            }
            set
            {
                m_DBDateFormat = value;
            }
        }

        #endregion

        #region FillAll
        public void FillAll()
        {
            System.Data.SqlClient.SqlConnection cn;
            cn = new SqlConnection(DataConnection);
            cn.Open();
            string sql;
            sql = "Select " + m_DataColumns + " from " + m_DataColumnsTable;
            System.Data.SqlClient.SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            System.Data.DataTable dt;
            dt = new System.Data.DataTable();
            da.Fill(dt);
            DataSource = dt;
            dt.Columns[0].ReadOnly = true;
            Columns[0].ReadOnly = true;
            cn.Close();
        }
        #endregion

        #region AddValidation
        public void AddValidation(string ColumnName, bool BlankControl, ValidationStyle ValidationType, string ValidationMessage)
        {
            if (dtValidation.Columns.Count == 0)
            {
                dtValidation.Columns.Add("Name", Type.GetType("System.String"));
                dtValidation.Columns.Add("BlankControl", Type.GetType("System.Boolean"));
                dtValidation.Columns.Add("Validation", Type.GetType("System.Int16"));
                // ValidationType

                // dtValidation.Columns.Add("Validation", Type.GetType(ValidationType));
                dtValidation.Columns.Add("ValidationMessage", Type.GetType("System.String"));


            }
            System.Data.DataRow dr;
            dr = dtValidation.NewRow();
            dr[0] = ColumnName;
            dr[1] = BlankControl;
            dr[2] = ValidationType;
            dr[3] = ValidationMessage;
            dtValidation.Rows.Add(dr);

        }
        #endregion

        #region AddCombo
        public void AddCombo(string ColumnName, string HeaderText, string SourceTable, string DisplayColumn, string ValueMember, string SWhere)
        {
            Columns.Remove(ColumnName);
            System.Data.SqlClient.SqlConnection cn;
            cn = new SqlConnection(DataConnection);
            cn.Open();
            string sql;
            sql = "Select " + DisplayColumn + " as LB," + ValueMember + " as VL from " + SourceTable + " " + SWhere;
            System.Data.SqlClient.SqlDataAdapter da_addcombo = new SqlDataAdapter(sql, cn);
            System.Data.DataTable dt_addcombo;
            dt_addcombo = new System.Data.DataTable();
            da_addcombo.Fill(dt_addcombo);
            DataGridViewComboBoxColumn column_addcombo = new DataGridViewComboBoxColumn();
            column_addcombo.DataSource = dt_addcombo;
            column_addcombo.DisplayMember = "LB";
            column_addcombo.ValueMember = "VL";
            column_addcombo.DataPropertyName = ColumnName;
            column_addcombo.Name = ColumnName;
            column_addcombo.HeaderText = HeaderText;
            Columns.Add(column_addcombo);
            int j, i;
            string[] k;
            char a;
            a = ',';
            k = m_DataColumns.Split(a);
            i = k.Length - 1;
            j = 0;
            while ((j < i) && (k[j].IndexOf(ColumnName) == -1))
            {
                j = j + 1;
            }
            Columns[i].DisplayIndex = j;
        }
        #endregion

        #region AddCalendar
        public void AddCalendar(string ColumnName, string HeaderText)
        {
            Columns.Remove(ColumnName);
            CalendarColumn column_addcalendar = new CalendarColumn();
            column_addcalendar.DataPropertyName = ColumnName;
            column_addcalendar.Name = ColumnName;
            column_addcalendar.HeaderText = HeaderText;
            Columns.Add(column_addcalendar);
            int j, i;
            string[] k;
            char a;
            a = ',';
            k = m_DataColumns.Split(a);
            i = k.Length - 1;
            j = 0;
            while ((j < i) && (k[j].IndexOf(ColumnName) == -1))
            {
                j = j + 1;
            }
            Columns[i].DisplayIndex = j;
        }
        #endregion

        #region AddMask
        public void AddMask(string ColumnName, string HeaderText, string MaskStr)
        {
            Columns.Remove(ColumnName);
            MaskedTextColumn column_addmask;
            column_addmask = new MaskedTextColumn();
            column_addmask.DataPropertyName = ColumnName;
            column_addmask.Name = ColumnName;
            column_addmask.HeaderText = HeaderText;
            column_addmask.maskA(MaskStr);
            Columns.Add(column_addmask);
            int j, i;
            string[] k;
            char a;
            a = ',';
            k = m_DataColumns.Split(a);
            i = k.Length - 1;
            j = 0;
            while ((j < i) && (k[j].IndexOf(ColumnName) == -1))
            {
                j = j + 1;
            }
            Columns[i].DisplayIndex = j;
        }
        #endregion

        //#region AddMultipleCombo
        //public void AddMultipleCombo(string ColumnName, string HeaderText, string SourceTable, string DisplayColumn, string ValueMember, string SWhere)
        //{
        //    Columns.Remove(ColumnName);

        //    System.Data.SqlClient.SqlConnection cn;
        //    cn = new SqlConnection(DataConnection);
        //    cn.Open();
        //    string sql;
        //    sql = "Select " + DisplayColumn + " as LB," + ValueMember + " as VL from " + SourceTable + " " + SWhere;
        //    System.Data.SqlClient.SqlDataAdapter da_addcombo = new SqlDataAdapter(sql, cn);
        //    System.Data.DataTable dt_addcombo;
        //    dt_addcombo = new System.Data.DataTable();
        //    da_addcombo.Fill(dt_addcombo);
        //   // MultipleComboboxColumn column_addcombo = new MultipleComboboxColumn();
        //   // column_addcombo.FillMultipleCombobox(dt_addcombo);
        //    //column_addcombo.DisplayMember = "LB";
        //    //column_addcombo.ValueMember = "VL";
        //  //  column_addcombo.DataPropertyName = ColumnName;
        //    column_addcombo.Name = ColumnName;
        //    column_addcombo.HeaderText = HeaderText;
        //  //  Columns.Add(column_addcombo);
        //    int j, i;
        //    string[] k;
        //    char a;
        //    a = ',';
        //    k = m_DataColumns.Split(a);
        //    i = k.Length - 1;
        //    j = 0;
        //    while ((j < i) && (k[j].IndexOf(ColumnName) == -1))
        //    {
        //        j = j + 1;
        //    }
        //    Columns[i].DisplayIndex = j;
        //}
        //#endregion


        #region Row_Save
        private void Row_Save(int rowNumber)
        {
            int j, i, s;
            string sql;
            string[] kValues;
            string[] columns_mod;
            char a;
          
            a = ',';
            kValues = m_DataColumns.Split(a);
            columns_mod = m_DataColumnsRaw.Split(a);

            j = kValues.Length;


            if (this[kValues[0], rowNumber].Value is System.DBNull)
            {
                kValues[0] = "Null";
            }
            else
            {
                kValues[0] = (this[kValues[0], rowNumber].Value).ToString();
            }

            if (kValues[0] != "Null")
            {
                sql = " update " + DataColumnsTable + " set ";
                for (i = 1; i < j; i++)
                {

                    kValues[i] = kValues[i].Replace(",", "");

                    if (this[kValues[i], rowNumber].Value is System.DBNull)
                    {
                        kValues[i] = "Null";

                    }
                    else
                    {
                        kValues[i] = (this[kValues[i], rowNumber].Value).ToString();
                    }
                    if (columns_mod[i].IndexOf('-') != -1)
                    {

                        columns_mod[i] = columns_mod[i].Replace('-', ' ');
                        sql = sql + columns_mod[i] + "='" + Convert.ToDateTime(kValues[i]).ToString(m_DBDateFormat) + "',";
                    }
                    else if (columns_mod[i].IndexOf('%') != -1)
                    {
                        columns_mod[i] = columns_mod[i].Replace('%', ' ');
                        sql = sql + columns_mod[i] + "='" + kValues[i] + "',";
                    }
                    else
                    {
                        columns_mod[i] = columns_mod[i].Replace('%', ' ');
                        kValues[i] = kValues[i].Replace(",", "");
                        sql = sql + columns_mod[i] + "=" + kValues[i] + ",";
                    }
                }
                s = sql.Length - 1;
                sql = sql.Substring(0, s);
                sql = sql + " where " + columns_mod[0] + "=" + kValues[0];
                System.Data.SqlClient.SqlConnection cn;
                cn = new SqlConnection(DataConnection);
                cn.Open();
                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

            }

            else
            {
                sql = " insert into " + DataColumnsTable + " ( ";
                string sql2 = ") values (";
                for (i = 1; i < j; i++)
                {
                    kValues[i] = kValues[i].Replace(',', ' ');
                    if (this[kValues[i], rowNumber].Value is System.DBNull)
                    {
                        kValues[i] = "Null";

                    }
                    else
                    {
                        kValues[i] = (this[kValues[i], rowNumber].Value).ToString();
                    }
                    if (columns_mod[i].IndexOf('-') != -1)
                    {

                        columns_mod[i] = columns_mod[i].Replace('-', ' ');
                        sql = sql + columns_mod[i] + "='" + Convert.ToDateTime(kValues[i]).ToString(m_DBDateFormat) + "',";
                    }
                    else if (columns_mod[i].IndexOf('%') != -1)
                    {
                        columns_mod[i] = columns_mod[i].Replace('%', ' ');
                        sql = sql + columns_mod[i] + ",";
                        sql2 = sql2 + "'" + kValues[i] + "',";
                    }
                    else
                    {
                        columns_mod[i] = columns_mod[i].Replace('%', ' ');
                        kValues[i] = kValues[i].Replace(',', ' ');
                        sql = sql + columns_mod[i] + ",";
                        sql2 = sql2 + kValues[i] + ",";
                    }
                }
                sql2 = sql2.Substring(0, sql2.Length - 1);
                sql = sql.Substring(0, sql.Length - 1);
                sql = sql + sql2 + ")";
                System.Data.SqlClient.SqlConnection cn;
                cn = new SqlConnection(DataConnection);
                cn.Open();
                System.Data.SqlClient.SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                FillAll();
            }

        }
        #endregion

        #region Events
        /// <param name="e">A <see cref="T:System.Windows.Forms.DataGridViewCellCancelEventArgs"></see> that contains the event data.</param>
        protected override void OnCellBeginEdit(System.Windows.Forms.DataGridViewCellCancelEventArgs e)
        {
            CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
            base.OnCellBeginEdit(e);
        }


        /// <param name="e">A <see cref="T:System.Windows.Forms.DataGridViewCellEventArgs"></see> that contains the event data.</param>
        protected override void OnRowValidated(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (CurrentRow.DefaultCellStyle.BackColor == System.Drawing.Color.Red)
            {
                CurrentRow.DefaultCellStyle.BackColor = System.Drawing.Color.Aqua;
                //Row_Save(e.RowIndex);
                base.OnRowValidated(e);
            }
        }


        /// <param name="e">A <see cref="T:System.Windows.Forms.DataGridViewCellEventArgs"></see> that contains the event data.</param>
        protected override void OnCellEndEdit(System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            this.Rows[e.RowIndex].ErrorText = String.Empty;
            base.OnCellEndEdit(e);
        }

        /// <param name="e">A <see cref="T:System.Windows.Forms.DataGridViewCellValidatingEventArgs"></see> that contains the event data.</param>
        protected override void OnCellValidating(System.Windows.Forms.DataGridViewCellValidatingEventArgs e)
        {
            int i, j;
            j = dtValidation.Rows.Count - 1;
            if (j != -1)
            {

                i = 0;
                bool check = false;
                System.Data.DataView dv = new System.Data.DataView(dtValidation, "Name='" + this.Columns[e.ColumnIndex].Name + "'", null, System.Data.DataViewRowState.CurrentRows);
                if (dv.Count == 1)
                {
                    if ((bool)dv[0][1])
                    {
                        if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                        {
                            this.Rows[e.RowIndex].ErrorText = "Empty Text";
                            e.Cancel = true;
                        }
                    }
                    if ((dv[0][2].ToString()) != "")
                    {
                        switch (dv[0][2].ToString())
                        {
                            case "0":
                                check = IsNumericInt(e.FormattedValue.ToString());
                                break;
                            case "1":
                                check = IsNumericDouble(e.FormattedValue.ToString());
                                break;
                            case "2":
                                check = IsEmail(e.FormattedValue.ToString());
                                break;
                            case "3":
                                check = IsDate(e.FormattedValue.ToString());
                                break;
                        }
                        if (check)
                        {
                            this.Rows[e.RowIndex].ErrorText = dv[0][3].ToString();
                            e.Cancel = check;
                        }
                    }

                }
            }
            base.OnCellValidating(e);
        }



        #endregion

        #region ValidationControls
        private bool IsNumericDouble(object ValueToCheck)
        {
            double Dummy = 0;
            return !double.TryParse(ValueToCheck.ToString(), System.Globalization.NumberStyles.Any, null, out Dummy);
        }

        private bool IsNumericInt(object ValueToCheck)
        {
            int Dummy = 0;
            return !int.TryParse(ValueToCheck.ToString(), System.Globalization.NumberStyles.Any, null, out Dummy);
        }

        private bool IsEmail(object ValueToCheck)
        {
            return !System.Text.RegularExpressions.Regex.IsMatch(ValueToCheck.ToString(), @"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$");
        }

        private bool IsDate(object ValueToCheck)
        {
            return !System.Text.RegularExpressions.Regex.IsMatch(ValueToCheck.ToString(), @"^[0-2]?[1-9](/|-|.)[0-3]?[0-9](/|-|.)[1-2][0-9][0-9][0-9]$");

        }


        #endregion

        #region CalendarColumn

        public class CalendarColumn : DataGridViewColumn
        {
            public CalendarColumn()
                : base(new CalendarCell())
            {
            }

            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    {
                        throw new InvalidCastException("Must be a CalendarCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }

        public class CalendarCell : DataGridViewTextBoxCell
        {

            public CalendarCell()
                : base()
            {
                // Use the short date format.
                this.Style.Format = "d";
            }

            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                CalendarEditingControl ctl =
                    DataGridView.EditingControl as CalendarEditingControl;

                if (this.Value!=System.DBNull.Value)
                {
                ctl.Value = (DateTime)this.Value;
                }
                
            }

            public override Type EditType
            {
                get
                {
                    // Return the type of the editing contol that CalendarCell uses.
                    return typeof(CalendarEditingControl);
                }
            }

            public override Type ValueType
            {
                get
                {
                    // Return the type of the value that CalendarCell contains.
                    return typeof(DateTime);
                }
            }

            public override object DefaultNewRowValue
            {
                get
                {
                    // Use the current date and time as the default value.
                    return DateTime.Now;
                }
            }
        }

        class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
        {
            DataGridView dataGridView;
            private bool valueChanged = false;
            int rowIndex;

            public CalendarEditingControl()
            {
                this.Format = DateTimePickerFormat.Short;
            }

            // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
            // property.
            public object EditingControlFormattedValue
            {
                get
                {
                    return this.Value.ToShortDateString();
                }
                set
                {
                    if (value is String)
                    {
                        this.Value = DateTime.Parse((String)value);
                    }
                }
            }

            // Implements the 
            // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
            public object GetEditingControlFormattedValue(
                DataGridViewDataErrorContexts context)
            {
                return EditingControlFormattedValue;
            }

            // Implements the 
            // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
            public void ApplyCellStyleToEditingControl(
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
            }

            // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
            // property.
            public int EditingControlRowIndex
            {
                get
                {
                    return rowIndex;
                }
                set
                {
                    rowIndex = value;
                }
            }

            // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
            // method.
            public bool EditingControlWantsInputKey(
                Keys key, bool dataGridViewWantsInputKey)
            {
                // Let the DateTimePicker handle the keys listed.
                switch (key & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return false;
                }
            }

            // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
            // method.
            public void PrepareEditingControlForEdit(bool selectAll)
            {
                // No preparation needs to be done.
            }

            // Implements the IDataGridViewEditingControl
            // .RepositionEditingControlOnValueChange property.
            public bool RepositionEditingControlOnValueChange
            {
                get
                {
                    return false;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlDataGridView property.
            public DataGridView EditingControlDataGridView
            {
                get
                {
                    return dataGridView;
                }
                set
                {
                    dataGridView = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlValueChanged property.
            public bool EditingControlValueChanged
            {
                get
                {
                    return valueChanged;
                }
                set
                {
                    valueChanged = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingPanelCursor property.
            public Cursor EditingPanelCursor
            {
                get
                {
                    return base.Cursor;
                }
            }

            protected override void OnValueChanged(EventArgs eventargs)
            {
                // Notify the DataGridView that the contents of the cell
                // have changed.
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(eventargs);
            }
        }

        #endregion

        #region MaskColumn

        public class mskn
        {
            static public string msk = "";
        }


        public class MaskedTextColumn : DataGridViewColumn
        {
            public MaskedTextColumn()
                : base(new MaskedTextCell())
            { }

            public void maskA(string m)
            {
                mskn.msk = m;
            }


            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(MaskedTextCell)))
                    {
                        throw new InvalidCastException("Must be a MaskedTextCell");
                    }
                    base.CellTemplate = value;
                }
            }



        }

        public class MaskedTextCell : DataGridViewTextBoxCell
        {
            public MaskedTextCell()
                : base()
            {
                this.Style.ForeColor = System.Drawing.Color.RoyalBlue;

            }




            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                MaskedTextEditingControl ctl = DataGridView.EditingControl as MaskedTextEditingControl;
                ctl.Text = (string)this.Value;


            }

            public override Type EditType
            {
                get
                {
                    return typeof(MaskedTextEditingControl);
                }
            }

            public override Type ValueType
            {
                get
                {
                    return typeof(string);
                }
            }



            class MaskedTextEditingControl : MaskedTextBox, IDataGridViewEditingControl
            {
                DataGridView dataGridView;
                private bool valueChanged;
                int rowIndex;

                public MaskedTextEditingControl()
                {
                    this.Mask = mskn.msk;
                }


                public object EditingControlFormattedValue
                {
                    get
                    {
                        return this.Text;
                    }
                    set
                    {
                        if (value is String)
                        {
                            this.Text = (String)value;

                        }
                    }
                }

                public object GetEditingControlFormattedValue(
                    DataGridViewDataErrorContexts context)
                {
                    return EditingControlFormattedValue;
                }

                public void ApplyCellStyleToEditingControl(
                    DataGridViewCellStyle dataGridViewCellStyle)
                {
                    this.Font = dataGridViewCellStyle.Font;
                }

                // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
                // property.
                public int EditingControlRowIndex
                {
                    get
                    {
                        return rowIndex;
                    }
                    set
                    {
                        rowIndex = value;
                    }
                }

                public bool EditingControlWantsInputKey(
                    Keys key, bool dataGridViewWantsInputKey)
                {
                    switch (key & Keys.KeyCode)
                    {
                        case Keys.Left:
                        case Keys.Up:
                        case Keys.Down:
                        case Keys.Right:
                        case Keys.Home:
                        case Keys.End:
                        case Keys.PageDown:
                        case Keys.PageUp:
                            return true;
                        default:
                            return false;
                    }
                }

                public void PrepareEditingControlForEdit(bool selectAll)
                {
                    // No preparation needs to be done.
                }

                public bool RepositionEditingControlOnValueChange
                {
                    get
                    {
                        return false;
                    }
                }

                public DataGridView EditingControlDataGridView
                {
                    get
                    {
                        return dataGridView;
                    }
                    set
                    {
                        dataGridView = value;
                    }
                }

                public bool EditingControlValueChanged
                {
                    get
                    {
                        return valueChanged;
                    }
                    set
                    {
                        valueChanged = value;
                    }
                }


                public Cursor EditingPanelCursor
                {
                    get
                    {
                        return base.Cursor;
                    }
                }


                /// <param name="e">An <see cref="T:System.EventArgs"></see> that contains the event data.</param>
                protected override void OnLeave(System.EventArgs e)
                {
                    valueChanged = true;
                    this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                    base.OnTextChanged(e);
                }

            }


        }


        #endregion



       // #region MultipleComboboxColumn



       // public class Mul
       // {
       //     static public DataTable mMultipleComboboxDatatable;
       //     static public int mSelectedIndex;
       // }

       // public class MultipleComboboxColumn : DataGridViewColumn
       // {
       //     public MultipleComboboxColumn()
       //         : base(new MultipleComboboxCell())
       //     {
       //     }

       //     public override DataGridViewCell CellTemplate
       //     {
       //         get
       //         {
       //             return base.CellTemplate;
       //         }
       //         set
       //         {
       //             if (value != null &&
       //                 !value.GetType().IsAssignableFrom(typeof(MultipleComboboxCell)))
       //             {
       //                 throw new InvalidCastException("Must be a MultipleComboboxCell");
       //             }
       //             base.CellTemplate = value;
       //         }
       //     }
       //     public void FillMultipleCombobox(DataTable dtDatatable)
       //     {
       //         Mul.mMultipleComboboxDatatable = dtDatatable;

       //     }
       //}

        public class MultipleComboboxCell : DataGridViewTextBoxCell
        {
            public MultipleComboboxCell()
                : base()
            {
                this.Style.ForeColor = System.Drawing.Color.RoyalBlue;

            }

       

            public override void InitializeEditingControl(int rowIndex, object
                initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                MultipleComboboxEditingControl ctl = DataGridView.EditingControl as MultipleComboboxEditingControl;
                //Int32 a;
                //a=Convert.ToString(this.Value);
                ctl.Text = Convert.ToString(this.Value);


            }

            public override Type EditType
            {
                get
                {
                    return typeof(MultipleComboboxEditingControl);
                }
            }

            public override Type ValueType
            {
                get
                {
                    return typeof(string);
                }
            }



            class MultipleComboboxEditingControl : ComboBox, IDataGridViewEditingControl
            {
                DataGridView dataGridView;
                private bool valueChanged;
                int rowIndex;

                public MultipleComboboxEditingControl()
                {
                    //this.Mask = mskn.msk;
                } 

                //public void FillMultipleCombobox()
                //{
                //    DataSource = Mul.mMultipleComboboxDatatable;
                //}


                public object EditingControlFormattedValue
                {
                    get
                    {
                        return this.Text;
                    }
                    set
                    {
                        if (value is String)
                        {
                            this.Text = (String)value;

                        }
                    }
                }

                public object GetEditingControlFormattedValue(
                    DataGridViewDataErrorContexts context)
                {
                    return EditingControlFormattedValue;
                }

                public void ApplyCellStyleToEditingControl(
                    DataGridViewCellStyle dataGridViewCellStyle)
                {
                    this.Font = dataGridViewCellStyle.Font;
                }

                // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
                // property.
                public int EditingControlRowIndex
                {
                    get
                    {
                        return rowIndex;
                    }
                    set
                    {
                        rowIndex = value;
                    }
                }

                public bool EditingControlWantsInputKey(
                    Keys key, bool dataGridViewWantsInputKey)
                {
                    switch (key & Keys.KeyCode)
                    {
                        case Keys.Left:
                        case Keys.Up:
                        case Keys.Down:
                        case Keys.Right:
                        case Keys.Home:
                        case Keys.End:
                        case Keys.PageDown:
                        case Keys.PageUp:
                            return true;
                        default:
                            return false;
                    }
                }

                public void PrepareEditingControlForEdit(bool selectAll)
                {
                    // No preparation needs to be done.
                }

                public bool RepositionEditingControlOnValueChange
                {
                    get
                    {
                        return false;
                    }
                }

                public DataGridView EditingControlDataGridView
                {
                    get
                    {
                        return dataGridView;
                    }
                    set
                    {
                        dataGridView = value;
                    }
                }

                public bool EditingControlValueChanged
                {
                    get
                    {
                        return valueChanged;
                    }
                    set
                    {
                        valueChanged = value;
                    }
                }


                public Cursor EditingPanelCursor
                {
                    get
                    {
                        return base.Cursor;
                    }
                }

              


                /// <param name="e">An <see cref="T:System.EventArgs"></see> that contains the event data.</param>
                protected override void OnLeave(System.EventArgs e)
                {
                    valueChanged = true;
                    this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                    base.OnTextChanged(e);
                }


                

                //protected override void OnSelectedIndexChanged(EventArgs e)
                //{
                //    // base.OnSelectedIndexChanged(e);
                //    ////this.SelectedIndex = popup.selectedRowValue;
                //    ////Mul.mSelectedIndex = popup.selectedRowValue;
                // //   SelectedIndex = popup.selectedRowValue;
                //    Mul.mSelectedIndex = 2;
                //}

                //protected override void OnSelectedIndexChanged1(EventArgs e)
                //{
                //    // base.OnSelectedIndexChanged(e);
                //    ////this.SelectedIndex = popup.selectedRowValue;
                //    Mul.mSelectedIndex = 1;
                //    //SelectedIndex = popup.selectedRowValue;
                //}



                protected override void OnClick(EventArgs e)
                {
                    // base.OnClick(e);
                }

                protected override void OnDoubleClick(EventArgs e)
                {
                    //base.OnDoubleClick(e);
                }

                protected override void OnDisplayMemberChanged(EventArgs e)
                {
                    // base.OnDisplayMemberChanged(e);
                }

                protected override void OnDataSourceChanged(EventArgs e)
                {
                    //                    base.OnDataSourceChanged(e);
                }

                protected override void OnMouseClick(MouseEventArgs e)
                {
                    //base.OnMouseClick(e);
                }


                protected override void  OnMouseDoubleClick(MouseEventArgs e)
{
// 	         base.OnMouseDoubleClick(e);
                }

                protected override void OnEnter(EventArgs e)
                {
                    //base.OnEnter(e);
                }

                protected override void OnGotFocus(EventArgs e)
                {
                    //base.OnGotFocus(e);
                }

                protected override void OnSelectedItemChanged(EventArgs e)
                {
                    //base.OnSelectedItemChanged(e);
                }

                protected override void OnSelectedValueChanged(EventArgs e)
                {
                    //base.OnSelectedValueChanged(e);
                }

                protected override void OnSelectionChangeCommitted(EventArgs e)
                {
                    //base.OnSelectionChangeCommitted(e);
                }

                
//                protected override void OnDropDown(System.EventArgs e)
//                {
//                    Form parent = this.FindForm();
//                    popupForm popup = new popupForm();
//                    popup.fillGrid(Mul.mMultipleComboboxDatatable);
//                    popup.Location = new Point(this.Left + parent.Left + this.Parent.Left + this.Parent.Parent.Left + 4, parent.Top + this.Parent.Parent.Top + this.Parent.Top + this.Height + 4);
//                    //popup.DatagridViewDblClick += new SelectedIndexChangeEvent(OnSelectedIndexChanged);
//                    //popup.dataGridView1.DoubleClick += new SelectedIndexChangeEvent(OnSelectedIndexChanged);
//                   // popup.dataGridView1.DoubleClick += new System.EventHandler(this.OnSelectedIndexChanged1);

//                    DataSource = Mul.mMultipleComboboxDatatable;
//                    DisplayMember = "LB";
//                    ValueMember = "VL";
//                    popup.Show();
//                    //popup.ShowDialog();
                    
//                    ////this.SelectedIndex = popup.selectedRowValue;
//                    ////Mul.mSelectedIndex = popup.selectedRowValue;
//                    //SelectedIndex = popup.selectedRowValue;
//                    //this.Height = 0;
//                    //// this.SelectedValue = popup.selectedRowValue;
///*
//                    if (this.dataTable != null || this.dataRows != null)
//                    {
//                        popupForm popup = new popupForm(this.dataTable, ref this.selectedRow, columnsToDisplay);
//                        popup.AfterRowSelectEvent += new AfterRowSelectEventHandler(MultiColumnComboBox_AfterSelectEvent);
//                        popup.Location = new Point(parent.Left + this.Left + 4, parent.Top + this.Bottom + this.Height);
//                        popup.Show();
//                        if (popup.SelectedRow != null)
//                        {
//                            try
//                            {
//                                this.selectedRow = popup.SelectedRow;
//                                this.displayValue = popup.SelectedRow[this.displayMember].ToString();
//                                this.Text = this.displayValue;
//                            }
//                            catch (Exception e2)
//                            {
//                                MessageBox.Show(e2.Message, "Error");
//                            }
//                        }
//                        if (AfterSelectEvent != null)
//                            AfterSelectEvent();
//                    }
// */
//                  //  base.OnDropDown(e);
//                }

            }


        }



      

    }

}
