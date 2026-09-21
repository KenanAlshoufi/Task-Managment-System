using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TaskDataAccessLayer;
using TaskDTOs.DTOsTask;

namespace StatusDataAccessLayer
{
    public class StatusData
    {
        public static bool GetStatusByID(int StatusID ,ref string Name)
        {
           bool IsFound=false;

            string SP = @"SP_GetStatusByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@StatusID", StatusID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            Name = (string)reader["Name"];

                            IsFound=true;

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
        public static bool GetStatusByName(ref int StatusID ,string Name)
        {
            bool IsFound = false;

            string SP = @"SP_GetStatusByName";

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
                            StatusID = (int)reader["StatusID"];

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
        public static List<Tuple<int,string>> GetAllStatus()
        {
            List<Tuple<int, string>> Status = new List<Tuple<int, string>>();

            string SP = @"SP_GetAllStatus";

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
                            Status.Add(new Tuple<int, string>(
                                reader.GetInt32(reader.GetOrdinal("StatusID")),
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
            return Status;
        }

    }
}
