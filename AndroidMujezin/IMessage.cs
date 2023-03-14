using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidMujezin
{
    public interface IMessage
    {
        void ShowMessageAndCatchAction(string Message, Action<string> ToClick);
    }
}
