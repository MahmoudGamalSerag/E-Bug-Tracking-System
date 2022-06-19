using System;
using System.Data.SqlClient;

namespace BugSolve
{
    class Custmer:IRegistration,IUser,IBug
    {
        public string CustmerName { get; set; }
        public string CustmerPassword { get; set; }
        DataBaseConnection Connection = new DataBaseConnection();
        SqlCommand Command;
        public bool register(string username, string password)
        {
            string CustmerData = "insert into UserData values('" + username + "','" + password + "','" + "Custmer" + "')";
             Command = new SqlCommand(CustmerData,Connection.DBconniction);
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
        public int GenerateBug(string BugDescription)
        {
            string NewBug = "insert into Bugs([Custmer Name],Description) values('" + this.CustmerName + "','" + BugDescription + "');SELECT CAST(scope_identity() AS int)";
            Command = new SqlCommand(NewBug, Connection.DBconniction);
            try
            {
                Connection.DBconniction.Open();
                int TicketNumber = (int)Command.ExecuteScalar();
                return TicketNumber;
            }
            catch (SqlException e)
            {

                return 0;
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
                        State = Result["State"].ToString()
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
    }
}
