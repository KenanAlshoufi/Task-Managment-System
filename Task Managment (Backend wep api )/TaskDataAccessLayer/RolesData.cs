using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskDTOs.DTOsRole;

namespace TaskDataAccessLayer
{
    public class RolesData
    {
        public static DTORoleInfo GetRolesByID(int RoleID)
        {
            DTORoleInfo roleInfo=new DTORoleInfo();

            string SP = @"SP_GetRolesByID";

            using (SqlConnection connection = new SqlConnection(ConnctionString.Connctionstring))
            {
                using (SqlCommand command = new SqlCommand(SP, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@RoleID", RoleID);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {

                            roleInfo.RoleID = (int)reader["RoleID"];
                            roleInfo.Name = (string)reader["Name"];
                        }
                    }
                    catch (Exception ex)
                    {
                      
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return roleInfo;
        }
        public static DTORoleInfo GetRolesByName( string Name)
        {
            DTORoleInfo roleInfo = new DTORoleInfo();

            string SP = @"SP_GetRolesByName";

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
                            roleInfo.RoleID = (int)reader["RoleID"];

                         
                        }
                        else
                        {
                           
                        }

                    }
                    catch (Exception ex)
                    {
                       
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
            return roleInfo;
        }
        public static List<DTORoleInfo> GetAllRoles()
        {
            List<DTORoleInfo> Roles = new List<DTORoleInfo>();

            string SP = @"SP_GetAllRoles";

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
                            Roles.Add(new DTORoleInfo(
                                reader.GetInt32(reader.GetOrdinal("RoleID")),
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
            return Roles;
        }
    }
}
