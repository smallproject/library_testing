using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SQL_experiments
    {
        public int Id { get; set; }
        public string AccountId { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public void commandtxt()
        {

            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO Users ([Id],[Account_Id],[Username],[Password])" +
                                  "VALUES(@Id,@Accountid,@username,@password)";
            command.Parameters.Add("@Id", SqlDbType.Int);
            command.Parameters.Add("@Accountid", SqlDbType.Int);
            command.Parameters.Add("@username", SqlDbType.NVarChar);
            command.Parameters.Add("@password", SqlDbType.NVarChar);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@Accountid", AccountId);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.CommandTimeout = 15;
            command.CommandType = CommandType.Text;

            Console.WriteLine(command.CommandText);
        }
    }
}
