using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using UserMS.Models;
using UserMS.Util;

namespace UserMS.DataAccess
{
    public static class UserDB
    {
        
        public static User GetUserById(int id)
        {
            try
            {
                User userToReturn = new User();

                using (SqlConnection connection = new SqlConnection(DBFunctions.ConnectionString))
                {
                    SqlCommand command = connection.CreateCommand();
                    command.CommandText = String.Format(@"
                        SELECT *
                        FROM [user].[User]
                        WHERE [Id] = @Id
                    ");
                    command.Parameters.Add("@Id", SqlDbType.Int);
                    command.Parameters["@Id"].Value = id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userToReturn.Id = (int)reader["Id"];
                            userToReturn.Name = reader["Name"] as string;
                        }
                    }
                }
                return userToReturn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}