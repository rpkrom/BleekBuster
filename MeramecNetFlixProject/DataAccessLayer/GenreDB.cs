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
    class GenreDB
    {
        public static List<GENRE> GetGenreList()
        {
            List<GENRE> genreList = new List<GENRE>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            string sqlString = "Select * from GENRE"; //changed to get all from GENRE
            SqlCommand objCommand = null;
           
            SqlDataReader genreReader = null;

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        using ((genreReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (genreReader.Read())
                            {
                                GENRE objGenre = new GENRE();
                                objGenre.id = genreReader["id"].ToString();
                                objGenre.name = genreReader["name"].ToString();

                                genreList.Add(objGenre);
                            }
                        }
                    }
                    return genreList;
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


        public static GENRE GetGenreList(int id) //parameter is key class
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            //GENRE genreList = new GENRE();
            List<GENRE> genreList = new List<GENRE>();


            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            string sqlString = "Select id, name";
            SqlCommand objCommand = null;
            
            SqlDataReader genreReader = null;
            GENRE objGenre = null;

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

                        using ((genreReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (genreReader.Read())
                            {
                                objGenre = new GENRE();
                                objGenre.id = genreReader["id"].ToString();
                                objGenre.name = genreReader["name"].ToString();

                                genreList.Add(objGenre);
                            }
                        }
                    }
                    return objGenre;
                }
                
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                if (mycon!= null)
                {
                    mycon.Close();
                }
            }
        }

        public static bool AddGenreList(GENRE objGenre)
        {
            List<GENRE> genreList = new List<GENRE>();
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
                    sqlString = "INSERT into GENRE values (@id, @name)";
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objGenre.id);
                        objCommand.Parameters.AddWithValue("@name", objGenre.name);
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

        public static bool UpdateGenreList(GENRE objGenre)
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
                    sqlString = "UPDATE GENRE " + Environment.NewLine +
                                "set name = @name " + Environment.NewLine +
                                "where id = @id";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objGenre.id);
                        objCommand.Parameters.AddWithValue("@name", objGenre.name);

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
                if (mycon!=null)
                {
                    mycon.Close();
                }
            }
        }

        public static bool DeleteGenreList(GENRE objGenre)
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
                    sqlString = "DELETE GENRE where id = @id";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objGenre.id);
                        
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
