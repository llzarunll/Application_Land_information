using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Enums;

namespace DocExp
{
    public class FileTypeGroup
    {
        private string _HeaderName;

        public string HeaderName
        {
            get { return _HeaderName; }
            set { _HeaderName = value; }
        }
        private bool _ShowInExplorer;

        public bool ShowInExplorer
        {
            get { return _ShowInExplorer; }
            set { _ShowInExplorer = value; }
        }
        private GroupTypes _GroupType;

        public GroupTypes GroupType
        {
            get { return _GroupType; }
            set { _GroupType = value; }
        }
        public FileTypeGroup(string parHeaderName, bool parShowInExplorer,GroupTypes parGroupType)
        {
            _HeaderName = parHeaderName;
            _ShowInExplorer = parShowInExplorer;
            _GroupType = parGroupType;
        }
    }
}
