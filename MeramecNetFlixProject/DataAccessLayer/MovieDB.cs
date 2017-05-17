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
    class MovieDB
    {
        public static List<MOVIE> GetMovieList()
        {
            List<MOVIE> movieList = new List<MOVIE>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            string sqlString = "Select * from MOVIE";
            SqlCommand objCommand = null;

            SqlDataReader movieReader = null;

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        using ((movieReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (movieReader.Read())
                            {
                                MOVIE objMovie = new MOVIE();
                                objMovie.movie_number = movieReader["movie_number"].ToString();
                                objMovie.movie_title = movieReader["movie_title"].ToString();
                                objMovie.Description = movieReader["Description"].ToString();
                                objMovie.movie_year_made = movieReader["movie_year_made"].ToString();
                                objMovie.genre_id = movieReader["genre_id"].ToString();
                                objMovie.movie_rating = movieReader["movie_rating"].ToString();
                                objMovie.movie_retail_cost = movieReader["movie_retail_cost"].ToString();
                                objMovie.copies_on_hand = movieReader["copies_on_hand"].ToString();
                                objMovie.image = movieReader["image"].ToString();
                                objMovie.trailer = movieReader["trailer"].ToString();

                                movieList.Add(objMovie);
                            }
                        }
                    }
                    return movieList;
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


        public static MOVIE GetMovieList(int movie_number) //parameter is key class
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            //GENRE genreList = new GENRE();
            List<MOVIE> movieList = new List<MOVIE>();


            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            string sqlString = "Select movie_number, movie_title, Description, movie_year_made, genre_id, movie_rating, movie_retail_cost, copies_on_hand, image, trailer";
            SqlCommand objCommand = null;

            SqlDataReader movieReader = null;
            MOVIE objMovie = null;

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
                        objCommand.Parameters.AddWithValue("@movie_number", movie_number);

                        using ((movieReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (movieReader.Read())
                            {
                                objMovie = new MOVIE(); //test
                                objMovie.movie_number = movieReader["movie_number"].ToString();
                                objMovie.movie_title = movieReader["movie_title"].ToString();
                                objMovie.Description = movieReader["Description"].ToString();
                                objMovie.movie_year_made = movieReader["movie_year_made"].ToString();
                                objMovie.genre_id = movieReader["genre_id"].ToString();
                                objMovie.movie_rating = movieReader["movie_rating"].ToString();
                                objMovie.movie_retail_cost = movieReader["movie_retail_cost"].ToString();
                                objMovie.copies_on_hand = movieReader["copies_on_hand"].ToString();
                                objMovie.image = movieReader["image"].ToString();
                                objMovie.trailer = movieReader["trailer"].ToString();

                                movieList.Add(objMovie);
                            }
                        }
                    }
                    return objMovie;
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

        public static bool AddMovieList(MOVIE objMovie)
        {
            List<MOVIE> movieList = new List<MOVIE>();
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
                    sqlString = "INSERT into MOVIE values (@movie_number, @movie_title, @Description, @movie_year_made, @genre_id, @movie_rating, @movie_retail_cost, @copies_on_hand, @image, @trailer)";
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);
                        objCommand.Parameters.AddWithValue("@movie_title", objMovie.movie_title);
                        objCommand.Parameters.AddWithValue("@Description", objMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", objMovie.movie_year_made);
                        objCommand.Parameters.AddWithValue("@genre_id", objMovie.genre_id);
                        objCommand.Parameters.AddWithValue("@movie_rating", objMovie.movie_rating);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", objMovie.movie_retail_cost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", objMovie.copies_on_hand);
                        objCommand.Parameters.AddWithValue("@image", objMovie.image);
                        objCommand.Parameters.AddWithValue("@trailer", objMovie.trailer);

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

        public static bool UpdateMovieList(MOVIE objMovie)
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
                    sqlString = "UPDATE MOVIE " + Environment.NewLine +                                
                                "set movie_title = @movie_title, " + Environment.NewLine +
                                "Description = @Description, " + Environment.NewLine +
                                "movie_year_made = @movie_year_made, " + Environment.NewLine +
                                "genre_id = @genre_id, " + Environment.NewLine +
                                "movie_rating = @movie_rating, " + Environment.NewLine +
                                "movie_retail_cost = @movie_retail_cost, " + Environment.NewLine +
                                "copies_on_hand = @copies_on_hand, " + Environment.NewLine +
                                "image = @image, " + Environment.NewLine +
                                "trailer = @trailer " + Environment.NewLine +
                                "where movie_number = @movie_number";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);
                        objCommand.Parameters.AddWithValue("@movie_title", objMovie.movie_title);
                        objCommand.Parameters.AddWithValue("@Description", objMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", objMovie.movie_year_made);
                        objCommand.Parameters.AddWithValue("@genre_id", objMovie.genre_id);
                        objCommand.Parameters.AddWithValue("@movie_rating", objMovie.movie_rating);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", objMovie.movie_retail_cost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", objMovie.copies_on_hand);
                        objCommand.Parameters.AddWithValue("@image", objMovie.image);
                        objCommand.Parameters.AddWithValue("@trailer", objMovie.trailer);

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

        public static bool DeleteMovieList(MOVIE objMovie)
        {
            string SQLStatement = String.Empty;
            int rowsAffected = 0;
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            SqlCommand objCommand = null;
            //SqlConnection objConn = null;

            string sqlString;
            try
            {
                using (mycon)
                {
                    mycon.Open();
                    sqlString = "DELETE MOVIE where movie_number = @movie_number";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", objMovie.movie_number);

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
