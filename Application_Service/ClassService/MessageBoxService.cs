using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DevComponents.DotNetBar;

namespace Application_Service.ClassService
{

    public enum MessageBoxServiceResult
    {
        Yes, YesAll, No, NoAll, Cancel, OK, Retry, Abourt, Ignore, None
    }

    public enum MessageBoxServiceButtons
    {
        AbortRetryIgnore,
        OK,
        OKCanCel,
        RetryCancel,
        YesNo,
        YesNoCancel,
        YesAllNoAll,
        YesAllNoAllCancel
    }

    public enum MessageBoxServiceIcon
    {
        Asterisk,
        Information,
        Error,
        Hand,
        Stop,
        Exclamation,
        Warning,
        None,
        Question
    }

    class MessageBoxService
    {
        #region Member
        string titleThai = string.Empty;
        string titleEng = string.Empty;
        string textThai = string.Empty;
        string textEng = string.Empty;
        MessageBoxServiceIcon icon = MessageBoxServiceIcon.None;
        MessageBoxServiceButtons button = MessageBoxServiceButtons.OK;
        #endregion
    }
}
