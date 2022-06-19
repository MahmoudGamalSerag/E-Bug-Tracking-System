using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSolve
{
    class Login
    {
        public string login(string username,string password)
        {
            DataBaseConnection Connection = new DataBaseConnection();
            SqlCommand Command;
            try
            {

                string login = "select * from UserData where [User Name]='" + username + "' and [User Password]='" + password + "' ";
                Connection.DBconniction.Open();
                 Command = new SqlCommand(login, Connection.DBconniction);
                SqlDataReader Result = Command.ExecuteReader();
                Bug BugFlow = new Bug();
                if (Result.Read())
                {
                    return Result["User Type"].ToString();
                }
                else
                {
                    return "Wrong info";
                }


            }
            catch (Exception ex)
            {
                return "exeption info";
            }
            finally
            {
                Connection.DBconniction.Close();
            }
        }
    }
}
