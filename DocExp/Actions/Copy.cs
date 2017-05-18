using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Attributes;
using DocExp.Enums;
using System.Windows.Forms;
using System.IO;

namespace DocExp.Actions
{
    [ActionAttributes(ActionName = "Copy", IsDefaultAction = false, ActionsGroupTypes = new GroupTypes[] { GroupTypes.File, GroupTypes.Folder })]
    public class Copy : DocExp.AbstractClasses.Action
    {
        public override void DoAction(string path, FileType parFileType, frmPerview frm)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                if (!String.IsNullOrEmpty(fbd.SelectedPath))
                {
                    if (parFileType.Group.GroupType == GroupTypes.File)
                    {
                        CopyFile(path, fbd.SelectedPath);
                    }
                    else if (parFileType.Group.GroupType == GroupTypes.Folder)
                    {
                        CopyDirectory(path, fbd.SelectedPath);
                    }
                }
                else
                {
                    ShowError("Please select a destination folder.");
                }
            }
            catch (Exception)
            {
                ShowError("An error occured while copying");
            }
        }
        public void CopyDirectory(string source, string destination)
        {
            string directoryName = source.Substring(source.LastIndexOf(@"\") + 1);
            DialogResult dr = DialogResult.Yes;
            if (Directory.Exists(destination + @"\" + directoryName))
            {
                dr = MessageBox.Show("Source:" + source + Environment.NewLine + "Destination:" + destination + Environment.NewLine + "Do you want to merge directories ?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            else if (dr == DialogResult.No)
            {
                while (File.Exists(destination + @"\" + directoryName))
                {
                    directoryName = "Copy Of " + directoryName;
                }
            }
            if (!Directory.Exists(destination + @"\" + directoryName))
            {
                Directory.CreateDirectory(destination + @"\" + directoryName);
            }
            foreach (string file in Directory.GetFiles(source))
            {
                CopyFile(file, destination + @"\" + directoryName);
            }
            foreach (string directory in Directory.GetDirectories(source))
            {
                CopyDirectory(directory, destination + @"\" + directoryName);
            }
        }
        public void CopyFile(string source, string destination)
        {
            string fileName = source.Substring(source.LastIndexOf(@"\") + 1);
            DialogResult dr = DialogResult.Yes;
            if (File.Exists(destination + @"\" + fileName))
            {
                dr = MessageBox.Show("Source:" + source + Environment.NewLine + "Destination:" + destination + Environment.NewLine + "Do you want to write over existing file?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            else if (dr == DialogResult.No)
            {
                while (File.Exists(destination + @"\" + fileName))
                {
                    fileName = "Copy Of " + fileName;
                }
            }

            File.Copy(source, destination + @"\" + fileName, true);
        }
    }
}
