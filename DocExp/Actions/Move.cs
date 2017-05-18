using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Attributes;
using DocExp.Enums;
using System.Windows.Forms;

namespace DocExp.Actions
{
    [ActionAttributes(ActionName = "Move", IsDefaultAction = false, ActionsGroupTypes = new GroupTypes[] { GroupTypes.File, GroupTypes.Folder })]
    public class Move : DocExp.AbstractClasses.Action
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
                        new Copy().CopyFile(path, fbd.SelectedPath);
                        new Delete().DeleteFile(path);
                    }
                    else if (parFileType.Group.GroupType == GroupTypes.Folder)
                    {
                        new Copy().CopyDirectory(path, fbd.SelectedPath);
                        new Delete().DeleteDirectory(path);
                    }
                }
                else
                {
                    ShowError("Please select a destination folder.");
                }
            }
            catch (Exception)
            {
                ShowError("An error occured while moving");
            }
        }
    }
}
