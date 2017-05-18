using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using DocExp.Attributes;
using DocExp.Enums;

namespace DocExp.Actions
{
    [ActionAttributes(ActionName = "Open", IsDefaultAction = false, ActionsGroupTypes =new GroupTypes[]{ GroupTypes.File , GroupTypes.Drive ,GroupTypes.Folder , GroupTypes.FolderUp})]
    public class Open : DocExp.AbstractClasses.Action
    {
        public override void DoAction(string path, FileType parFileType, frmPerview frm)
        {
            try
            {

                if (parFileType.Group.GroupType == GroupTypes.File)
                {
                    if (FileExists(path))
                    {
                        Process.Start(path);
                    }
                }
                else
                {
                    if (DirectoryExists(path))
                    {
                        frm.LoadSubFilesAndFolders(path);
                    }
                }

            }
            catch (Exception)
            {
                ShowError("An error occured while opening file");
            }
        }
    }
}
