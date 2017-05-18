using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Interfaces;
using System.Windows.Forms;
using System.IO;
using DocExp.Attributes;
using DocExp.Enums;

namespace DocExp.Actions
{
    [ActionAttributes(ActionName = "Preview", IsDefaultAction = true, ActionsGroupTypes = new GroupTypes[] { GroupTypes.File })]
    public class Preview : DocExp.AbstractClasses.Action
    {

        public override void DoAction(string path, FileType parFileType, frmPerview frm)
        {
            try
            {
                if (FileExists(path))
                {
                    if (parFileType.PreviewType == null)
                    {
                        ShowError("Preview not available");
                    }
                    else
                    {
                        Type t = parFileType.PreviewType;
                        //SplitContainer sc=(SplitContainer)frm.Controls.Find("sc", true)[0];
                        //Panel pnl=(Panel)sc.Panel2.Controls.Find("pnlPreview", true)[0];
                        Panel pnl = (Panel)frm.Controls.Find("pnlPreview", true)[0];
                        if (pnl.Controls.Count > 0)
                        {
                            Control pOld = pnl.Controls[0];
                            pOld.Dispose();
                        }
                        pnl.Controls.Clear();
                        //sc.Panel2Collapsed = false;
                        IPreview p = (IPreview)Activator.CreateInstance(t);
                        pnl.Controls.Add((Control)p);
                        ((Control)p).Dock = DockStyle.Fill;
                        p.Preview(path);
                        frm.SetPreviewPanelButtonsVisibility();
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("An error occured while loading preview control");
                frm.SetPreviewPanelButtonsVisibility();
            }
        }
    }
}
