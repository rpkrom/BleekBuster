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
    class RentalDB
    {
        public static List<RENTAL> GetRentalList()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<RENTAL> rentalList = new List<RENTAL>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            string sqlString = "Select movie_number, member_number, media_checkout_date, media_return_date";
            SqlCommand objCommand = null;

            SqlDataReader rentalReader = null;

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        using ((rentalReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (rentalReader.Read())
                            {
                                RENTAL objRental = new RENTAL();
                                objRental.movie_number = rentalReader["movie_number"].ToString();
                                objRental.member_number = rentalReader["member_number"].ToString();
                                objRental.media_checkout_date = rentalReader["media_checkout_date"].ToString();
                                objRental.media_return_date = rentalReader["media_return_date"].ToString();

                                rentalList.Add(objRental);
                            }
                        }
                    }
                    return rentalList;
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


        public static RENTAL GetRentalList(int id) //parameter is key class
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            //GENRE genreList = new GENRE();
            List<RENTAL> rentalList = new List<RENTAL>();


            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            string sqlString = "Select movie_number, member_number, media_checkout_date, media_return_date";
            SqlCommand objCommand = null;

            SqlDataReader rentalReader = null;
            RENTAL objRental = null;

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

                        using ((rentalReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (rentalReader.Read())
                            {
                                objRental = new RENTAL();
                                objRental.movie_number = rentalReader["movie_number"].ToString();
                                objRental.member_number = rentalReader["member_number"].ToString();
                                objRental.media_checkout_date = rentalReader["media_checkout_date"].ToString();
                                objRental.media_return_date = rentalReader["media_return_date"].ToString();

                                rentalList.Add(objRental);
                            }
                        }
                    }
                    return objRental;
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

        public static bool AddRentalList(RENTAL objRental)
        {
            List<RENTAL> rentalList = new List<RENTAL>();
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
                    sqlString = "INSERT into RENTAL values (@movie_number, @member_number, @media_checkout_date, @media_return_date)";
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", objRental.movie_number);
                        objCommand.Parameters.AddWithValue("@member_number", objRental.member_number);
                        objCommand.Parameters.AddWithValue("@media_checkout_date", objRental.media_checkout_date);
                        objCommand.Parameters.AddWithValue("@media_return_date", objRental.media_return_date);
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

        public static bool UpdateRentalList(RENTAL objRental)
        {
            string SQLStatement = String.Empty;
            int rowsAffected = 0;
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            SqlCommand objCommand = null;


            string sqlString;
            try
            {
                using (mycon)
                {//@movie_number, @member_number, @media_checkout_date, @media_return_date
                    mycon.Open();
                    sqlString = "UPDATE RENTAL " + Environment.NewLine +
                                "set member_number = @member_number, " + Environment.NewLine +
                                "set media_checkout_date = @media_checkout_date, " + Environment.NewLine +
                                "set media_return_date = @media_return_date, " + Environment.NewLine +
                                "where movie_number = @movie_number";


                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", objRental.movie_number);
                        objCommand.Parameters.AddWithValue("@member_number", objRental.member_number);
                        objCommand.Parameters.AddWithValue("@media_checkout_date", objRental.media_checkout_date);
                        objCommand.Parameters.AddWithValue("@media_return_date", objRental.media_return_date);

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

        public static bool DeleteRentalList(RENTAL objRental)
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
                    sqlString = "DELETE RENTAL where movie_number = @movie_number";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", objRental.movie_number);

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
