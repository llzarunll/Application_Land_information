using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DocExp.Controls
{
    public class DocExpListViewItem:ListViewItem
    {
        public DocExpListViewItem(string text, ListViewGroup group)
            : base(text, group)
        {

        }
        private string _Path;

        public string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }
        private FileType _FileType;

        public FileType FileType
        {
            get { return _FileType; }
            set { _FileType = value; }
        }
    }
}
