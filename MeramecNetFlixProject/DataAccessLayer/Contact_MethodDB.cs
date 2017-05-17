using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MeramecNetFlixProject.BusinessObjects;

namespace MeramecNetFlixProject.DataAccessLayer
{
    class Contact_MethodDB
    {
        public static List<CONTACT_METHOD> GetContact_MethodList()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<CONTACT_METHOD> contact_methodList = new List<CONTACT_METHOD>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            string sqlString = "Select id, name";
            SqlCommand objCommand = null;

            SqlDataReader contact_methodReader = null;

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        using ((contact_methodReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (contact_methodReader.Read())
                            {
                                CONTACT_METHOD objContact_Method = new CONTACT_METHOD();
                                objContact_Method.id = contact_methodReader["id"].ToString();
                                objContact_Method.name = contact_methodReader["name"].ToString();

                                contact_methodList.Add(objContact_Method);
                            }
                        }
                    }
                    return contact_methodList;
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (mycon != null)
                {
                    mycon.Close();
                }
            }

            //Step #3: Return the objtemp generic list variable  back to the calling UI 

        }


        public static CONTACT_METHOD GetContact_MethodList(int id) //parameter is key class
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            //GENRE genreList = new GENRE();
            List<CONTACT_METHOD> contact_methodList = new List<CONTACT_METHOD>();


            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            string sqlString = "Select id, name";
            SqlCommand objCommand = null;

            SqlDataReader contact_methodReader = null;
            CONTACT_METHOD objContact_Method = null;

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Code logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program     

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", id);

                        using ((contact_methodReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (contact_methodReader.Read())
                            {
                                objContact_Method = new CONTACT_METHOD();
                                objContact_Method.id = contact_methodReader["id"].ToString();
                                objContact_Method.name = contact_methodReader["name"].ToString();

                                contact_methodList.Add(objContact_Method);
                            }
                        }
                    }
                    return objContact_Method;
                }

            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (mycon != null)
                {
                    mycon.Close();
                }
            }
        }

        public static bool AddContact_MethodList(CONTACT_METHOD objContact_Method)
        {
            List<CONTACT_METHOD> contact_methodList = new List<CONTACT_METHOD>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program 
            int rowsAffected = 0;

            SqlCommand objCommand = null;


            string sqlString;
            try
            {
                using (mycon)
                {
                    mycon.Open();
                    sqlString = "INSERT into CONTACT_METHOD values (@id, @name)";
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objContact_Method.id);
                        objCommand.Parameters.AddWithValue("@name", objContact_Method.name);
                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (mycon != null)
                {
                    mycon.Close();
                }
            }

            //return true; //temporary return until your code is fully flushed out. Remove or comment out this line
        }

        public static bool UpdateContact_MethodList(CONTACT_METHOD objContact_Method)
        {
            string SQLStatement = String.Empty;
            int rowsAffected = 0;
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            SqlCommand objCommand = null;


            string sqlString;
            try
            {
                using (mycon)
                {
                    mycon.Open();
                    sqlString = "UPDATE CONTACT_METHOD " + Environment.NewLine +
                                "set name = @name, " + Environment.NewLine +
                                "where id = @id";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objContact_Method.id);
                        objCommand.Parameters.AddWithValue("@name", objContact_Method.name);

                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (mycon != null)
                {
                    mycon.Close();
                }
            }

        }

        public static bool DeleteContact_MethodList(CONTACT_METHOD objContact_Method)
        {
            string SQLStatement = String.Empty;
            int rowsAffected = 0;
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            SqlCommand objCommand = null;


            string sqlString;
            try
            {
                using (mycon)
                {
                    mycon.Open();
                    sqlString = "DELETE CONTACT_METHOD where id = @id";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objContact_Method.id);

                        rowsAffected = objCommand.ExecuteNonQuery();
                        mycon.Close();
                    }
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (mycon != null)
                {
                    mycon.Close();
                }
            }

        }

    }
}
