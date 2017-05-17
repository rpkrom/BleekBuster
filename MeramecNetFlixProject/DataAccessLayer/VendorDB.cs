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
    class VendorDB
    {
        public static List<VENDOR> GetVendorList()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<VENDOR> vendorList = new List<VENDOR>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            string sqlString = "Select * from VENDOR"; //changed to get all from GENRE
            SqlCommand objCommand = null;

            SqlDataReader vendorReader = null;

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        using ((vendorReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (vendorReader.Read())
                            {
                                VENDOR objVendor = new VENDOR();
                                objVendor.id = vendorReader["id"].ToString();
                                objVendor.name = vendorReader["name"].ToString();
                                objVendor.title = vendorReader["title"].ToString();
                                objVendor.quantity = vendorReader["quantity"].ToString();

                                vendorList.Add(objVendor);
                            }
                        }
                    }
                    return vendorList;
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


        public static VENDOR GetVendorList(int id) //parameter is key class
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            //GENRE genreList = new GENRE();
            List<VENDOR> genreList = new List<VENDOR>();


            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            string sqlString = "Select id, name, title, quantity";
            SqlCommand objCommand = null;

            SqlDataReader vendorReader = null;
            VENDOR objVendor = null;

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

                        using ((vendorReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (vendorReader.Read())
                            {
                                objVendor = new VENDOR();
                                objVendor.id = vendorReader["id"].ToString();
                                objVendor.name = vendorReader["name"].ToString();
                                objVendor.title = vendorReader["title"].ToString();
                                objVendor.quantity = vendorReader["quantity"].ToString();

                                genreList.Add(objVendor);
                            }
                        }
                    }
                    return objVendor;
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

        public static bool AddVendorList(VENDOR objVendor)
        {
            List<VENDOR> vendorList = new List<VENDOR>();
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
                    sqlString = "INSERT into VENDOR values (@id, @name, @title, @quantity)";
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objVendor.id);
                        objCommand.Parameters.AddWithValue("@name", objVendor.name);
                        objCommand.Parameters.AddWithValue("@title", objVendor.title);
                        objCommand.Parameters.AddWithValue("@quantity", objVendor.quantity);
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

        public static bool UpdateVendorList(VENDOR objVendor)
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
                    sqlString = "UPDATE VENDOR " + Environment.NewLine +
                                "set name = @name " + Environment.NewLine +
                                "set title = @title " + Environment.NewLine +
                                "set quantity = @quantity " + Environment.NewLine +
                                "where id = @id";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objVendor.id);
                        objCommand.Parameters.AddWithValue("@name", objVendor.name);
                        objCommand.Parameters.AddWithValue("@title", objVendor.title);
                        objCommand.Parameters.AddWithValue("@quantity", objVendor.quantity);

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

        public static bool DeleteVendorList(VENDOR objVendor)
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
                    sqlString = "DELETE VENDOR where id = @id";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objVendor.id);

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
