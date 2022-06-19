using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSolve
{
    interface IAssignBug:IBug
    {
       bool AssignBugToStaff(int TicketNumber, string StaffName);
    }
}
