using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDataAccessLayer
{
    public class PriorityData
    {
        public static bool GetPriorityByID(int PriorityID, ref string Name)
        {
            bool IsFound = false;

            string SP = @"SP_GetPriorityByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PriorityID", PriorityID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            Name = (string)reader["Name"];

                            IsFound = true;

                        }
                        else
                        {
                            IsFound = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return IsFound;
        }
        public static bool GetPriorityByName(ref int PriorityID, string Name)
        {
            bool IsFound = false;

            string SP = @"SP_GetPriorityByName";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", Name);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            PriorityID = (int)reader["PriorityID"];

                            IsFound = true;
                        }
                        else
                        {
                            IsFound = false;
                        }

                    }
                    catch (Exception ex)
                    {
                        IsFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return IsFound;
        }
        public static List<Tuple<int, string>> GetAllPriority()
        {
            List<Tuple<int, string>> Priority = new List<Tuple<int, string>>();

            string SP = @"SP_GetAllPriority";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;


                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Priority.Add(new Tuple<int, string>(
                                reader.GetInt32(reader.GetOrdinal("PriorityID")),
                                reader.GetString(reader.GetOrdinal("Name"))
                               ));
                        }

                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return Priority;
        }
    }
}
