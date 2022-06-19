using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSolve
{
    class Admin : IUser,IAssignBug
    {
        
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }
        DataBaseConnection Connection = new DataBaseConnection();
        SqlCommand Command;
        public bool SendSolution( string CustomerName ,string Message)
        {
            IMessage message = new Solution();
            if (
            message.Send(CustomerName, this.AdminName, "Admin", Message) == true)
            {
                return true;
            }
            else
                return false;
        }
        public bool SendNormalMessage(string CustomerName, string Message)
        {
            IMessage message = new SendMessage();
            if (
            message.Send(CustomerName, this.AdminName, "Admin", Message) == true)
            {
                return true;
            }
            else
                return false;
        }
        public bool AddStuff(string StaffNamePrametar,string StaffPasswordParametar)
        {
            string CustmerData = "insert into UserData values('" + StaffNamePrametar + "','" + StaffPasswordParametar + "','" + "Staff" + "')";
            Command = new SqlCommand(CustmerData, Connection.DBconniction);
            try
            {
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
        public IEnumerable<Bug> ViewAllBugs()
        {
            try
            {
                List<Bug> AllBugs = new List<Bug>();
                string BugStateCommand = "select * from Bugs";
                Connection.DBconniction.Open();
                Command = new SqlCommand(BugStateCommand, Connection.DBconniction);
                SqlDataReader Result = Command.ExecuteReader();
                while (Result.Read())
                {
                    AllBugs.Add(new Bug
                    {
                        TicketNUmber = (int)Result["Ticket Number"]
                   ,
                        StaffName = Result["Staff Name"].ToString(),
                        CustmerName = Result["Custmer Name"].ToString()
                   ,
                        State = Result["State"].ToString(),
                        Describtion = Result["Description"].ToString()
                    });
                }
                return AllBugs;
            }
            catch (Exception ex)
            {
                return null;
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
                    string s1 = Result["Ticket Number"].ToString();
                    //Console.Write(s1);

                    BugFlow = new Bug
                    {
                        TicketNUmber = (int)Result["Ticket Number"],
                        CustmerName = Result["Custmer Name"].ToString()
                    ,
                        StaffName = Result["Staff Name"].ToString(),
                        Describtion = Result["Description"].ToString()
                    ,   State = Result["State"].ToString()
                    };
                    //Console.Write(BugFlow.State);
                    return BugFlow;
                }
                else
                {
                    return null;
                }
                

            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                Connection.DBconniction.Close();
            }
        }
    }
}
