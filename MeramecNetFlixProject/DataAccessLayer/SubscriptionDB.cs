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
    class SubscriptionDB
    {
        public static List<SUBSCRIPTION> GetSubscriptionList()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<SUBSCRIPTION> subscriptionList = new List<SUBSCRIPTION>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            string sqlString = "Select id, name, cost";
            SqlCommand objCommand = null;

            SqlDataReader subscriptionReader = null;

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        using ((subscriptionReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (subscriptionReader.Read())
                            {
                                SUBSCRIPTION objSubscription = new SUBSCRIPTION();
                                objSubscription.id = subscriptionReader["id"].ToString();
                                objSubscription.name = subscriptionReader["name"].ToString();
                                objSubscription.cost = subscriptionReader["cost"].ToString();

                                subscriptionList.Add(objSubscription);
                            }
                        }
                    }
                    return subscriptionList;
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


        public static SUBSCRIPTION GetSubscriptionList(int id) //parameter is key class
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            //GENRE genreList = new GENRE();
            List<SUBSCRIPTION> subscriptionList = new List<SUBSCRIPTION>();


            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            string sqlString = "Select id, name, cost";
            SqlCommand objCommand = null;

            SqlDataReader subscriptionReader = null;
            SUBSCRIPTION objSubscription = null;

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

                        using ((subscriptionReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (subscriptionReader.Read())
                            {
                                objSubscription = new SUBSCRIPTION();
                                objSubscription.id = subscriptionReader["id"].ToString();
                                objSubscription.name = subscriptionReader["name"].ToString();
                                objSubscription.cost = subscriptionReader["cost"].ToString();                                

                                subscriptionList.Add(objSubscription);
                            }
                        }
                    }
                    return objSubscription;
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

        public static bool AddSubscriptionList(SUBSCRIPTION objSubscription)
        {
            List<SUBSCRIPTION> subscriptionList = new List<SUBSCRIPTION>();
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
                    sqlString = "INSERT into SUBSCRIPTION values (@id, @name, @cost)";
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objSubscription.id);
                        objCommand.Parameters.AddWithValue("@name", objSubscription.name);
                        objCommand.Parameters.AddWithValue("@cost", objSubscription.cost);
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

        public static bool UpdateSubscriptionList(SUBSCRIPTION objSubscription)
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
                    sqlString = "UPDATE SUBSCRIPTION " + Environment.NewLine +
                                "set name = @name, " + Environment.NewLine +
                                 "set cost = @cost, " + Environment.NewLine +
                                "where id = @id"; 


                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objSubscription.id);
                        objCommand.Parameters.AddWithValue("@name", objSubscription.name);
                        objCommand.Parameters.AddWithValue("@cost", objSubscription.cost);

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

        public static bool DeleteGenreList(SUBSCRIPTION objSubscription)
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
                    sqlString = "DELETE SUBSCRIPTION where id = @id";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@id", objSubscription.id);

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
