using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DocExp.Enums;

namespace DocExp
{
    public class ActionType
    {
        private string _ActionName;

        public string ActionName
        {
            get { return _ActionName; }
            set { _ActionName = value; }
        }
        private Type _Action;

        public Type Action
        {
            get { return _Action; }
            set { _Action = value; }
        }
        private bool _IsDefaultAction;

        public bool IsDefaultAction
        {
            get { return _IsDefaultAction; }
            set { _IsDefaultAction = value; }
        }
        private List<GroupTypes> _ActionsGroupTypes = new List<GroupTypes>();

        public List<GroupTypes> ActionsGroupTypes
        {
            get { return _ActionsGroupTypes; }
            set { _ActionsGroupTypes = value; }
        }
        public ActionType(string parActionName, Type parAction, bool parIsDefaultAction)
        {
            _ActionName = parActionName;
            _Action = parAction;

            _IsDefaultAction = parIsDefaultAction;
        }
    }
}
