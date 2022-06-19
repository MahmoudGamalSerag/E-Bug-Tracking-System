using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugSolve
{
    class DataBaseConnection
    {
        public string connection = @"Data Source=DARTHVADER\MSSQLSERVER02;
                                                  Initial Catalog=BugSolving;
                                                 Integrated Security=True;";
            //create instanace of database connection
            public SqlConnection DBconniction = new SqlConnection(@"Data Source=DARTHVADER\MSSQLSERVER02;
                                                  Initial Catalog=BugSolving;
                                                 Integrated Security=True;");
   
            
    }
}
