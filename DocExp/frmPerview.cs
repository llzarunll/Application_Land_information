using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DocExp.PreviewControls;
//using DocExp.Actions;
//using DocExp.Controls;
using DocExp.Attributes;
//using DocExp.Enums;
using DocExp.Interfaces;

namespace DocExp
{
    public partial class frmPerview : Form
    {
        public frmPerview()
        {
            InitializeComponent();
        }

        public string strPath = string.Empty;
        public Type t;
        public FileType ft;
        private void frmPerview_Load(object sender, EventArgs e)
        {
            ft = GetFileType(strPath);
            try
            {
                if (FileExists(strPath))
                {
                    if (ft.PreviewType == null)
                    {
                        ShowError("Preview not available");
                    }
                    else
                    {
                        Type t = ft.PreviewType;
                        //SplitContainer sc=(SplitContainer)frm.Controls.Find("sc", true)[0];
                        //Panel pnl=(Panel)sc.Panel2.Controls.Find("pnlPreview", true)[0];
                        Panel pnl = (Panel)this.Controls.Find("pnlPreview", true)[0];
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
                        p.Preview(strPath);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("An error occured while loading preview control");
            }

        }

        public FileType GetFileType(string FileName)
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

            FileType TempFileType = null;
            string[] TempFileName = FileName.Split('.');
            switch (TempFileName[TempFileName.Length - 1].ToLower())
            {
                case "jpg":
                    TempFileType = new FileType("JPG Files", "*.Jpg", typeof(ImagePreview), imageFileTypeGroup);
                    break;
                case "jpeg":
                    TempFileType = new FileType("JPEG Files", "*.Jpeg", typeof(ImagePreview), imageFileTypeGroup);
                    break;
                case "tif":
                    TempFileType = new FileType("TIFF Files", "*.Tif", typeof(ImagePreview), imageFileTypeGroup);
                    break;
                case "gif":
                    TempFileType = new FileType("GIF Files", "*.Gif", typeof(ImagePreview), imageFileTypeGroup);
                    break;
                case "bmp":
                    TempFileType = new FileType("BMP Files", "*.Bmp", typeof(ImagePreview), imageFileTypeGroup);
                    break;
                case "png":
                    TempFileType = new FileType("PNG Files", "*.Png", typeof(ImagePreview), imageFileTypeGroup);
                    break;
                case "mp3":
                    TempFileType = new FileType("MP3 Files", "*.Mp3", typeof(MediaPreview), musicFileTypeGroup);
                    break;
                case "wav":
                    TempFileType = new FileType("Wav Files", "*.Wav", typeof(MediaPreview), musicFileTypeGroup);
                    break;
                case "wma":
                    TempFileType = new FileType("Wma Files", "*.Wma", typeof(MediaPreview), musicFileTypeGroup);
                    break;
                case "mid":
                    TempFileType = new FileType("Midi Files", "*.Mid", typeof(MediaPreview), musicFileTypeGroup);
                    break;
                case "avi":
                    TempFileType = new FileType("Avi Files", "*.Avi", typeof(MediaPreview), videoFileTypeGroup);
                    break;
                case "mpg":
                    TempFileType = new FileType("Mpg Files", "*.Mpg", typeof(MediaPreview), videoFileTypeGroup);
                    break;
                case "wmv":
                    TempFileType = new FileType("Wmv Files", "*.Wmv", typeof(MediaPreview), videoFileTypeGroup);
                    break;
                case "html":
                    TempFileType = new FileType("Html Files", "*.Html", typeof(HtmlPreview), htmlFileTypeGroup);
                    break;
                case "txt":
                    TempFileType = new FileType("Txt Files", "*.Txt", typeof(TextPreview), textFileTypeGroup);
                    break;
                case "rtf":
                    TempFileType = new FileType("Rtf Files", "*.Rtf", typeof(TextPreview), textFileTypeGroup);
                    break;
                case "docx":
                    TempFileType = new FileType("Docx Files", "*.Docx", typeof(WordPreview), wordFileTypeGroup);
                    break;
                case "doc":
                    TempFileType = new FileType("Doc Files", "*.Doc", typeof(WordPreview), wordFileTypeGroup);
                    break;
                case "xlsx":
                    TempFileType = new FileType("Xlsx Files", "*.Xlsx", typeof(ExcelPreview), excelFileTypeGroup);
                    break;
                case "xls":
                    TempFileType = new FileType("Xls Files", "*.Xls", typeof(ExcelPreview), excelFileTypeGroup);
                    break;
                case "pptx":
                    TempFileType = new FileType("Pptx Files", "*.Pptx", typeof(PowerPointPreview), powerpointFileTypeGroup);
                    break;
                case "ppt":
                    TempFileType = new FileType("Ppt Files", "*.Ppt", typeof(PowerPointPreview), powerpointFileTypeGroup);
                    break;
                case "ppsx":
                    TempFileType = new FileType("Ppsx Files", "*.Ppsx", typeof(PowerPointPreview), powerpointFileTypeGroup);
                    break;
                case "pps":
                    TempFileType = new FileType("Pps Files", "*.Pps", typeof(PowerPointPreview), powerpointFileTypeGroup);
                    break;
            }


            return TempFileType;
        }
        public void LoadSubFilesAndFolders(string path)
        {
            //fsw.Path = path;
            //txtPath.Text = path;

            //lvExplorer.Groups.Clear();
            //lvExplorer.Items.Clear();

            //ListViewGroup grpActions = new ListViewGroup(" ");
            //grpActions.Tag = groups[2];
            //lvExplorer.Groups.Add(grpActions);
            //ListViewGroup grpDirectories = new ListViewGroup(groups[1].HeaderName);
            //grpDirectories.Tag = groups[1];
            //lvExplorer.Groups.Add(grpDirectories);



            //DocExpListViewItem lviUp = new DocExpListViewItem("Up", grpActions);
            //lviUp.ImageKey = "FolderUp";
            //lviUp.FileType = fileTypes[2];
            //lviUp.Path = path;
            //lvExplorer.Items.Add(lviUp);

            //foreach (string directory in Directory.GetDirectories(path))
            //{
            //    DocExpListViewItem lviDirectory = new DocExpListViewItem(directory.Substring(directory.LastIndexOf(@"\") + 1), grpDirectories);
            //    lviDirectory.Path = directory;
            //    lviDirectory.FileType = fileTypes[1];
            //    lviDirectory.ImageKey = "Folder";
            //    lvExplorer.Items.Add(lviDirectory);

            //}
            //List<string> filesLoaded = new List<string>();
            //foreach (FileTypeGroup ftg in (from ftg in groups where ftg.ShowInExplorer == true select ftg))
            //{
            //    List<DocExpListViewItem> items = new List<DocExpListViewItem>();
            //    foreach (FileType ft in (from ft in fileTypes where ft.Group == ftg select ft))
            //    {
            //        ListViewGroup grpFiles = null;
            //        if (lvExplorer.Groups[ftg.HeaderName] == null)
            //        {
            //            grpFiles = new ListViewGroup(ftg.HeaderName, ftg.HeaderName);
            //            grpFiles.Tag = ftg;
            //            lvExplorer.Groups.Add(grpFiles);
            //        }
            //        else
            //        {
            //            grpFiles = lvExplorer.Groups[ftg.HeaderName];
            //        }

            //        foreach (string file in Directory.GetFiles(path, ft.SearchCriteria, SearchOption.TopDirectoryOnly))
            //        {
            //            if (!filesLoaded.Contains(file))
            //            {
            //                DocExpListViewItem lviFile = new DocExpListViewItem(file.Substring(file.LastIndexOf(@"\") + 1), grpFiles);
            //                lviFile.Path = file;
            //                lviFile.FileType = ft;
            //                if (ilExplorer.Images.Keys.IndexOf(ft.SearchCriteria.Replace("*.", "")) > -1)
            //                {
            //                    lviFile.ImageKey = ft.SearchCriteria.Replace("*.", "");
            //                }
            //                else
            //                {
            //                    lviFile.ImageKey = "*";
            //                }
            //                items.Add(lviFile);
            //                filesLoaded.Add(file);
            //            }
            //        }

            //    }
            //    foreach (DocExpListViewItem itm in (from i in items orderby i.Text ascending select i))
            //    {
            //        lvExplorer.Items.Add(itm);
            //    }
            //}
        }
        public void SetPreviewPanelButtonsVisibility()
        {
            //if (sc.Panel2Collapsed)
            //{
            //    btnShowPreview.Visible = true;
            //}
            //else
            //{
            //    btnShowPreview.Visible = false;
            //}
        }

        public bool FileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                ShowError("File is not accessable");
                return false;
            }
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
