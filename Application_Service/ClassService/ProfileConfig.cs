using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using Application_Service.Data;

namespace Application_Service.ClassService
{
    public class ProfileConfig
    {
        #region
        public static string ProfilePath = Application.StartupPath + @"\Profile.xml";
        #endregion

        #region Save
        public static void Save(LoginDS dsProfile)
        {
            try
            {
                FileStream fsWriteXml = new FileStream(ProfilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                dsProfile.WriteXml(fsWriteXml, XmlWriteMode.WriteSchema);
                fsWriteXml.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Load
        public static LoginDS Load()
        {
            LoginDS dsProfile = new LoginDS();
            FileStream fsWriteXml = new FileStream(ProfilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            try
            {
                if (fsWriteXml.Length < 10)
                {
                    LoginDS.DBProfileRow row = dsProfile.DBProfile.NewDBProfileRow();
                    row.DataBase = "";
                    row.DBLogin = "sa";
                    row.DBPassword = "";
                    row.ServerName = "localhost\\SQLExpress";

                    dsProfile.DBProfile.Rows.Add(row);
                    dsProfile.WriteXml(fsWriteXml, XmlWriteMode.WriteSchema);
                }
                else
                {
                    dsProfile.ReadXml(fsWriteXml);
                }
                fsWriteXml.Close();
                return dsProfile;
            }
            catch
            {
                dsProfile.WriteXml(fsWriteXml, XmlWriteMode.WriteSchema);
                return dsProfile;
            }
        }
        #endregion  
    }
}
