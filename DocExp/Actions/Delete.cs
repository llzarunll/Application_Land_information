using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Attributes;
using DocExp.Enums;
using System.IO;

namespace DocExp.Actions
{
    [ActionAttributes(ActionName = "Delete", IsDefaultAction = false, ActionsGroupTypes = new GroupTypes[] { GroupTypes.File, GroupTypes.Folder })]
    public class Delete : DocExp.AbstractClasses.Action
    {
        public override void DoAction(string path, FileType parFileType, frmPerview frm)
        {
            try
            {

                if (parFileType.Group.GroupType == GroupTypes.File)
                {
                    DeleteFile(path);
                }
                else if (parFileType.Group.GroupType == GroupTypes.Folder)
                {
                    DeleteDirectory(path);
                }

            }
            catch (Exception)
            {
                ShowError("An error occured while deleting");
            }
        }
        public void DeleteDirectory(string source)
        {
            foreach (string directory in Directory.GetDirectories(source))
            {
                DeleteDirectory(directory);
            }
            foreach (string file in Directory.GetFiles(source))
            {
                DeleteFile(file);
            }
            Directory.Delete(source, true);
        }
        public void DeleteFile(string source)
        {
            File.Delete(source);
        }
    }
}
