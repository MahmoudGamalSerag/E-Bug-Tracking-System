using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSolve
{
    class Staff:IAssignBug
    {
        public string StaffName { get; set; }
        public string StaffPassword { get; set; }
        private IMessage message;
        DataBaseConnection Connection = new DataBaseConnection();
        SqlCommand Command;
        public IEnumerable<Bug> ShowAssigndBugs()
        {
            List<Bug> AssignedBugs = new List<Bug>();
            try
            {

                string BugStateCommand = "select * from Bugs where [Staff Name]='" + this.StaffName + "' ";
                Connection.DBconniction.Open();
                 Command = new SqlCommand(BugStateCommand, Connection.DBconniction);
                SqlDataReader Result = Command.ExecuteReader();
                while(Result.Read())
                {

                    AssignedBugs.Add(new Bug
                    {
                        TicketNUmber = (int)Result["Ticket Number"]
                    ,
                        StaffName = this.StaffName,
                        CustmerName = Result["Custmer Name"].ToString()
                    ,
                        State = Result["State"].ToString(),
                        Describtion = Result["Description"].ToString()
                    });
                }
               
               
                return AssignedBugs;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection !");
                return null;
            }
            finally
            {
                Connection.DBconniction.Close();
            }
        }
        public bool UpdateFlow(int TicketNumber,string state)
        {
            string UpdateFlowCommand="UPDATE Bugs SET State ='" + state + "' Where [Ticket Number] ='" + TicketNumber + "'";
            try
            {
                Command = new SqlCommand(UpdateFlowCommand, Connection.DBconniction);
                Connection.DBconniction.Open();
                Command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                Connection.DBconniction.Close();
            }
        }

        public bool AssignBugToStaff(int TicketNumber, string StaffName)
        {
            string UpdateFlowCommand = "UPDATE Bugs SET [Staff Name] ='" + StaffName + "' Where [Ticket Number] ='" + TicketNumber + "'";
            try
            {
                Command = new SqlCommand(UpdateFlowCommand, Connection.DBconniction);
                Connection.DBconniction.Open();
                Command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                Connection.DBconniction.Close();
            }
        }

        public Bug ViewBugFlow(int TicketNumber)
        {
            try
            {

                string BugStateCommand = "select * from Bugs where [Ticket Number]='" + TicketNumber + "' ";
                Connection.DBconniction.Open();
                SqlCommand Command = new SqlCommand(BugStateCommand, Connection.DBconniction);
                SqlDataReader Result = Command.ExecuteReader();
                Bug BugFlow = new Bug();
                if (Result.Read())
                {
                    BugFlow = new Bug
                    {
                        TicketNUmber = (int)Result["Ticket Number"],
                        CustmerName = Result["Custmer Name"].ToString()
                    ,
                        StaffName = Result["Staff Name"].ToString(),
                        Describtion = Result["Description"].ToString()
                    ,
                        State= Result["State"].ToString()
                    };
                    return BugFlow;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Can not open connection !");
                return null;
            }
            finally
            {
                Connection.DBconniction.Close();
            }

        }
        public bool SendSolution(string CustomerName, string Message)
        {
            IMessage message = new Solution();
            if (
            message.Send(CustomerName, this.StaffName, "Staff", Message) == true)
            {
                return true;
            }
            else
                return false;
        }
    }
    
}
