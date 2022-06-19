using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSolve
{
    interface IMessage
    {
         bool Send(string CustomerName, string SenderName, string SenderType, string Message);
    }
}
