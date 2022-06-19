using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSolve
{
    class Solution : IMessage
    {
        
        public bool Send(string CustomerName, string SenderName, string SenderType, string Message)
        {
            DataBaseConnection Connection = new DataBaseConnection();
            SqlCommand Command;
            string MessageType = "Solution";
            string MessageCommandString = "insert into Messages(CustmerName,SenderName,SenderType,MessageType,Message)" +
                " values('" + CustomerName + "','" + SenderName + "','" + SenderType + "','" + MessageType + "','" + Message + "')";
            Command = new SqlCommand(MessageCommandString, Connection.DBconniction);
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

       
    }
}
