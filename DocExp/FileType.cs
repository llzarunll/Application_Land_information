using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocExp
{
    public class FileType
    {
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
        private FileTypeGroup _Group;

        public FileTypeGroup Group
        {
            get { return _Group; }
            set { _Group = value; }
        }
        private string _SearchCriteria;

        public string SearchCriteria
        {
            get { return _SearchCriteria; }
            set { _SearchCriteria = value; }
        }
        private Type _PreviewType;

        public Type PreviewType
        {
            get { return _PreviewType; }
            set { _PreviewType = value; }
        }
    
        public FileType(string parDescription,string parSearchCriteria, Type parPreviewType,FileTypeGroup parGroup)
        {
            _Description = parDescription;
            _SearchCriteria = parSearchCriteria;
            _PreviewType = parPreviewType;
            _Group = parGroup;
            
        }
    }
}
