using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Collections;
using System.Linq;
using DocExp.PreviewControls;
using DocExp.Actions;
using DocExp.Controls;
using DocExp.Attributes;
using DocExp.Enums;

namespace DocExp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        List<FileType> fileTypes = new List<FileType>();
        List<FileTypeGroup> groups = new List<FileTypeGroup>();
        List<ActionType> actionTypes = new List<ActionType>();
        private void Form1_Load(object sender, EventArgs e)
        {
            FileTypeGroup pdfFileTypeGroup = new FileTypeGroup("PDF Documents", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup imageFileTypeGroup = new FileTypeGroup("Images", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup otherFileTypeGroup = new FileTypeGroup("Other Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup videoFileTypeGroup = new FileTypeGroup("Video Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup musicFileTypeGroup = new FileTypeGroup("Music Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup textFileTypeGroup = new FileTypeGroup("Text Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup htmlFileTypeGroup = new FileTypeGroup("Html Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup wordFileTypeGroup = new FileTypeGroup("Word Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup excelFileTypeGroup = new FileTypeGroup("Excel Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup powerpointFileTypeGroup = new FileTypeGroup("PowerPoint Files", true, DocExp.Enums.GroupTypes.File);
            FileTypeGroup drives = new FileTypeGroup("Drives", false, DocExp.Enums.GroupTypes.Drive);
            FileTypeGroup folders = new FileTypeGroup("Folders", false, DocExp.Enums.GroupTypes.Folder);
            FileTypeGroup up = new FileTypeGroup("", false, DocExp.Enums.GroupTypes.FolderUp);

            groups.Add(drives);
            groups.Add(folders);
            groups.Add(up);
            groups.Add(musicFileTypeGroup);
            groups.Add(videoFileTypeGroup);
            groups.Add(pdfFileTypeGroup);
            groups.Add(wordFileTypeGroup);
            groups.Add(excelFileTypeGroup);
            groups.Add(powerpointFileTypeGroup);
            groups.Add(imageFileTypeGroup);
            groups.Add(textFileTypeGroup);
            groups.Add(htmlFileTypeGroup);
            groups.Add(otherFileTypeGroup);
            

            fileTypes.Add(new FileType("Drivers", "*.*", null, drives));
            fileTypes.Add(new FileType("Folders", "*.*", null, folders));
            fileTypes.Add(new FileType("Up", "*.*", null, up));
            //fileTypes.Add(new FileType("PDF Files", "*.Pdf", typeof(PdfPreview), pdfFileTypeGroup));
            fileTypes.Add(new FileType("JPG Files", "*.Jpg", typeof(ImagePreview), imageFileTypeGroup));
            fileTypes.Add(new FileType("JPEG Files", "*.Jpeg", typeof(ImagePreview), imageFileTypeGroup));
            fileTypes.Add(new FileType("TIFF Files", "*.Tif", typeof(ImagePreview), imageFileTypeGroup));
            fileTypes.Add(new FileType("GIF Files", "*.Gif", typeof(ImagePreview), imageFileTypeGroup));
            fileTypes.Add(new FileType("BMP Files", "*.Bmp", typeof(ImagePreview), imageFileTypeGroup));
            fileTypes.Add(new FileType("PNG Files", "*.Png", typeof(ImagePreview), imageFileTypeGroup));
            fileTypes.Add(new FileType("MP3 Files", "*.Mp3", typeof(MediaPreview), musicFileTypeGroup));
            fileTypes.Add(new FileType("Wav Files", "*.Wav", typeof(MediaPreview), musicFileTypeGroup));
            fileTypes.Add(new FileType("Wma Files", "*.Wma", typeof(MediaPreview), musicFileTypeGroup));
            fileTypes.Add(new FileType("Midi Files", "*.Mid", typeof(MediaPreview), musicFileTypeGroup));
            fileTypes.Add(new FileType("Avi Files", "*.Avi", typeof(MediaPreview), videoFileTypeGroup));
            fileTypes.Add(new FileType("Mpg Files", "*.Mpg", typeof(MediaPreview), videoFileTypeGroup));
            fileTypes.Add(new FileType("Wmv Files", "*.Wmv", typeof(MediaPreview), videoFileTypeGroup));
            fileTypes.Add(new FileType("Html Files", "*.Html", typeof(HtmlPreview), htmlFileTypeGroup));
            fileTypes.Add(new FileType("Htm Files", "*.Htm", typeof(HtmlPreview), htmlFileTypeGroup));
            fileTypes.Add(new FileType("Txt Files", "*.Txt", typeof(TextPreview), textFileTypeGroup));
            fileTypes.Add(new FileType("Rtf Files", "*.Rtf", typeof(TextPreview), textFileTypeGroup));
            fileTypes.Add(new FileType("Docx Files", "*.Docx", typeof(WordPreview), wordFileTypeGroup));
            fileTypes.Add(new FileType("Doc Files", "*.Doc", typeof(WordPreview), wordFileTypeGroup));
            fileTypes.Add(new FileType("Xlsx Files", "*.Xlsx", typeof(ExcelPreview), excelFileTypeGroup));
            fileTypes.Add(new FileType("Xls Files", "*.Xls", typeof(ExcelPreview), excelFileTypeGroup));
            fileTypes.Add(new FileType("Pptx Files", "*.Pptx", typeof(PowerPointPreview), powerpointFileTypeGroup));
            fileTypes.Add(new FileType("Ppt Files", "*.Ppt", typeof(PowerPointPreview), powerpointFileTypeGroup));
            fileTypes.Add(new FileType("Ppsx Files", "*.Ppsx", typeof(PowerPointPreview), powerpointFileTypeGroup));
            fileTypes.Add(new FileType("Pps Files", "*.Pps", typeof(PowerPointPreview), powerpointFileTypeGroup));
            fileTypes.Add(new FileType("Other Files", "*.*", null, otherFileTypeGroup));

            foreach (Type t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes())
            {
                if (t.BaseType == typeof(DocExp.AbstractClasses.Action))
                {
                    string actionName = ((ActionAttributes)t.GetCustomAttributes(typeof(ActionAttributes), true)[0]).ActionName;
                    bool isDefault = ((ActionAttributes)t.GetCustomAttributes(typeof(ActionAttributes), true)[0]).IsDefaultAction;
                    GroupTypes[] gt = ((ActionAttributes)t.GetCustomAttributes(typeof(ActionAttributes), true)[0]).ActionsGroupTypes;
                    ActionType at = new ActionType(actionName, t, isDefault);
                    foreach (GroupTypes g in gt)
                    {
                        at.ActionsGroupTypes.Add(g);
                    }
                    actionTypes.Add(at);
                }
            }
            SetImageSize();
            LoadDrives();
        }
        private void SetContextMenu()
        {
            cm.Items.Clear();
            cm.ImageList = ilContext;
            List<GroupTypes> groupTypes = new List<GroupTypes>();
            foreach (DocExpListViewItem d in lvExplorer.SelectedItems)
            {
                if (!groupTypes.Contains(d.FileType.Group.GroupType))
                {
                    groupTypes.Add(d.FileType.Group.GroupType);
                }
            }

            foreach (ActionType at in actionTypes)
            {
                bool containsAll = true;
                foreach (GroupTypes gt in groupTypes)
                {
                    if (!at.ActionsGroupTypes.Contains(gt))
                    {
                        containsAll = false;
                    }
                }
                if (containsAll)
                {
                    ToolStripButton tsb = new ToolStripButton(at.ActionName,ilContext.Images[at.ActionName]);
                    tsb.Tag = at;
                    tsb.ImageKey = at.ActionName;
                    cm.Items.Add(tsb);
                }
            }

        }
        public void LoadDrives()
        {
            txtPath.Text = "";
            lvExplorer.Groups.Clear();
            lvExplorer.Items.Clear();
            ListViewGroup grpDrives = new ListViewGroup(groups[0].HeaderName);
            grpDrives.Tag = groups[0];
            lvExplorer.Groups.Add(grpDrives);
            ManagementObjectSearcher mos = new ManagementObjectSearcher();
            mos.Query = new ObjectQuery("SELECT * From Win32_LogicalDisk");
            foreach (ManagementObject mo in mos.Get())
            {
                string type = mo["DriveType"].ToString();
                string name = mo["DeviceId"].ToString() + @"\";

                DocExpListViewItem lviDrive = new DocExpListViewItem(name, grpDrives);
                lviDrive.FileType = fileTypes[0];
                lviDrive.Path = name;
                if (type == "3")
                {
                    lviDrive.ImageKey = "Drive";
                }
                else if (type == "4")
                {
                    lviDrive.ImageKey = "NetworkDrive";
                }
                else if (type == "5")
                {
                    lviDrive.ImageKey = "CDDVD";
                }
                else
                {

                }

                lvExplorer.Items.Add(lviDrive);
            }

        }
        public void LoadSubFilesAndFolders(string path)
        {
            fsw.Path = path;
            txtPath.Text = path;

            lvExplorer.Groups.Clear();
            lvExplorer.Items.Clear();

            ListViewGroup grpActions = new ListViewGroup(" ");
            grpActions.Tag = groups[2];
            lvExplorer.Groups.Add(grpActions);
            ListViewGroup grpDirectories = new ListViewGroup(groups[1].HeaderName);
            grpDirectories.Tag = groups[1];
            lvExplorer.Groups.Add(grpDirectories);



            DocExpListViewItem lviUp = new DocExpListViewItem("Up", grpActions);
            lviUp.ImageKey = "FolderUp";
            lviUp.FileType = fileTypes[2];
            lviUp.Path = path;
            lvExplorer.Items.Add(lviUp);

            foreach (string directory in Directory.GetDirectories(path))
            {
                DocExpListViewItem lviDirectory = new DocExpListViewItem(directory.Substring(directory.LastIndexOf(@"\") + 1), grpDirectories);
                lviDirectory.Path = directory;
                lviDirectory.FileType = fileTypes[1];
                lviDirectory.ImageKey = "Folder";
                lvExplorer.Items.Add(lviDirectory);

            }
            List<string> filesLoaded = new List<string>();
            foreach (FileTypeGroup ftg in (from ftg in groups where ftg.ShowInExplorer == true select ftg))
            {
                List<DocExpListViewItem> items = new List<DocExpListViewItem>();
                foreach (FileType ft in (from ft in fileTypes where ft.Group == ftg select ft))
                {
                    ListViewGroup grpFiles = null;
                    if (lvExplorer.Groups[ftg.HeaderName] == null)
                    {
                        grpFiles = new ListViewGroup(ftg.HeaderName, ftg.HeaderName);
                        grpFiles.Tag = ftg;
                        lvExplorer.Groups.Add(grpFiles);
                    }
                    else
                    {
                        grpFiles = lvExplorer.Groups[ftg.HeaderName];
                    }

                    foreach (string file in Directory.GetFiles(path, ft.SearchCriteria, SearchOption.TopDirectoryOnly))
                    {
                        if (!filesLoaded.Contains(file))
                        {
                            DocExpListViewItem lviFile = new DocExpListViewItem(file.Substring(file.LastIndexOf(@"\") + 1), grpFiles);
                            lviFile.Path = file;
                            lviFile.FileType = ft;
                            if (ilExplorer.Images.Keys.IndexOf(ft.SearchCriteria.Replace("*.", "")) > -1)
                            {
                                lviFile.ImageKey = ft.SearchCriteria.Replace("*.", "");
                            }
                            else
                            {
                                lviFile.ImageKey = "*";
                            }
                            items.Add(lviFile);
                            filesLoaded.Add(file);
                        }
                    }
                    
                }
                foreach (DocExpListViewItem itm in (from i in items orderby i.Text ascending select i))
                {
                    lvExplorer.Items.Add(itm);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                LoadDrives();
            }
            else
            {
                LoadSubFilesAndFolders(txtPath.Text);
            }
        }
        List<Image> imageList = new List<Image>();
        private void iconSize_ValueChanged(object sender, EventArgs e)
        {
            SetImageSize();
        }

        private void SetImageSize()
        {
            if (imageList.Count == 0)
            {
                foreach (Image i in ilExplorer.Images)
                {
                    imageList.Add(i);
                }
            }
            ilExplorer.ImageSize = new Size(iconSize.Value, iconSize.Value);
            ilExplorer.ColorDepth = ColorDepth.Depth32Bit;
            ilExplorer.TransparentColor = System.Drawing.Color.Transparent;
            foreach (Image i in imageList)
            {
                ilExplorer.Images.Add(i);
            }
            int fontsize = 0;
            if (iconSize.Value <= 32)
            {
                fontsize = 8;
            }
            else if (iconSize.Value <= 64)
            {
                fontsize = 12;
            }
            else
            {
                fontsize = 16;
            }
            Font f = new Font(lvExplorer.Font.FontFamily, fontsize);
            lvExplorer.Font = f;
        }

        private void cm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (DocExpListViewItem li in lvExplorer.SelectedItems)
            {
                Type t = ((ActionType)e.ClickedItem.Tag).Action;
                //((DocExp.AbstractClasses.Action)Activator.CreateInstance(t)).DoAction(li.Path, li.FileType, this);
            }
        }

        private void lvExplorer_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                SetContextMenu();
            }
        }

        private void lvExplorer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    if (lvExplorer.SelectedItems.Count != 0)
                    {
                        FileType ft = ((DocExpListViewItem)lvExplorer.SelectedItems[0]).FileType;
                        string path = ((DocExpListViewItem)lvExplorer.SelectedItems[0]).Path;
                        if (ft.Group.GroupType == DocExp.Enums.GroupTypes.Folder || ft.Group.GroupType == DocExp.Enums.GroupTypes.Drive)
                        {
                            LoadSubFilesAndFolders(path);
                        }

                        else if (ft.Group.GroupType == DocExp.Enums.GroupTypes.FolderUp)
                        {
                            if (path.Length == 3)
                            {
                                LoadDrives();
                            }
                            else
                            {
                                path = path.Substring(0, path.LastIndexOf(@"\"));
                                if (path.Length == 2)
                                {
                                    path += @"\";
                                }
                                LoadSubFilesAndFolders(path);
                            }
                        }
                        else
                        {
                            IEnumerable<ActionType> resultSet = (from a in actionTypes where a.IsDefaultAction == true select a);
                            if (resultSet.Count() == 1)
                            {
                                Type t = resultSet.First().Action;
                                //((DocExp.AbstractClasses.Action)Activator.CreateInstance(t)).DoAction(path, ft, this);
                                frmPerview frm = new frmPerview();
                                frm.strPath = path;
                                frm.t = t;
                                frm.ft = ft;
                                frm.ShowDialog();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured, you may not have permission to object or object is inaccessable.");
                }
            }
        }

        private void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            LoadSubFilesAndFolders(txtPath.Text);
        }

        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            LoadSubFilesAndFolders(txtPath.Text);
        }

        private void fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            LoadSubFilesAndFolders(txtPath.Text);
        }

        private void fsw_Renamed(object sender, RenamedEventArgs e)
        {
            LoadSubFilesAndFolders(txtPath.Text);
        }

        private void btnClosePreview_Click(object sender, EventArgs e)
        {
            sc.Panel2Collapsed = true;
            SetPreviewPanelButtonsVisibility();
        }

        private void btnShowPreview_Click(object sender, EventArgs e)
        {
            sc.Panel2Collapsed = false;
            SetPreviewPanelButtonsVisibility();
        }
        public void SetPreviewPanelButtonsVisibility()
        {
            if (sc.Panel2Collapsed)
            {
                btnShowPreview.Visible = true;
            }
            else
            {
                btnShowPreview.Visible = false;
            }
        }





    }
}
