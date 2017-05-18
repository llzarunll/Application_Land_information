using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Enums;

namespace DocExp.Attributes
{
    public class ActionAttributes:Attribute
    {
        private string _ActionName;

        public string ActionName
        {
            get { return _ActionName; }
            set { _ActionName = value; }
        }
        private bool _IsDefaultAction;

        public bool IsDefaultAction
        {
            get { return _IsDefaultAction; }
            set { _IsDefaultAction = value; }
        }
        private GroupTypes[] _ActionsGroupTypes;

        public GroupTypes[] ActionsGroupTypes
        {
            get { return _ActionsGroupTypes; }
            set { _ActionsGroupTypes = value; }
        }
    }
}
