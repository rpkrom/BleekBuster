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
    class MemberDB
    {


        public static List<MEMBER> GetMemberList()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<MEMBER> memberList = new List<MEMBER>();
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();

            //Step #2: Code Logic to create appropriate SQL Server objects calls
            //         Code Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            string sqlString = "Select * from MEMBER";
            SqlCommand objCommand = null;

            SqlDataReader memberReader = null;

            try
            {
                using (mycon)
                {
                    mycon.Open();
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        using ((memberReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (memberReader.Read())
                            {
                                MEMBER objMember = new MEMBER();
                                objMember.number = memberReader["number"].ToString();
                                objMember.joindate = memberReader["joindate"].ToString();
                                objMember.firstname = memberReader["firstname"].ToString();
                                objMember.lastname = memberReader["lastname"].ToString();
                                objMember.address = memberReader["address"].ToString();
                                objMember.city = memberReader["city"].ToString();
                                objMember.state = memberReader["state"].ToString();
                                objMember.zipcode = memberReader["zipcode"].ToString();
                                objMember.phone = memberReader["phone"].ToString();
                                objMember.member_status = memberReader["member_status"].ToString();
                                objMember.login_name = memberReader["login_name"].ToString();
                                objMember.password = memberReader["password"].ToString();
                                objMember.email = memberReader["email"].ToString();
                                objMember.contact_method = memberReader["contact_method"].ToString();
                                objMember.subscription_id = memberReader["subscription_id"].ToString();
                                objMember.photo = memberReader["photo"].ToString();

                                memberList.Add(objMember);
                            }
                        }
                    }
                    return memberList;
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


        public static MEMBER GetMemberList(int number) //parameter is key class
        {
            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 
            string SQLStatement = String.Empty;

            //Change the MyCustomObject references  to your customer business object
            SqlConnection mycon = AccessDataSQLServer.GetConnection();
            //GENRE genreList = new GENRE();
            List<MEMBER> genreList = new List<MEMBER>();


            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            string sqlString = "Select * from MEMBER";
            SqlCommand objCommand = null;

            SqlDataReader memberReader = null;
            MEMBER objMember = null;

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
                        objCommand.Parameters.AddWithValue("@number", number);

                        using ((memberReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection)))
                        {
                            while (memberReader.Read())
                            {
                                objMember = new MEMBER();
                                objMember.number = memberReader["number"].ToString();
                                objMember.joindate = memberReader["joindate"].ToString();
                                objMember.firstname = memberReader["firstname"].ToString();
                                objMember.lastname = memberReader["lastname"].ToString();
                                objMember.address = memberReader["address"].ToString();
                                objMember.city = memberReader["city"].ToString();
                                objMember.state = memberReader["state"].ToString();
                                objMember.zipcode = memberReader["zipcode"].ToString();
                                objMember.phone = memberReader["phone"].ToString();
                                objMember.member_status = memberReader["member_status"].ToString();
                                objMember.login_name = memberReader["login_name"].ToString();
                                objMember.password = memberReader["password"].ToString();
                                objMember.email = memberReader["email"].ToString();
                                objMember.contact_method = memberReader["contact_method"].ToString();
                                objMember.subscription_id = memberReader["subscription_id"].ToString();
                                objMember.photo = memberReader["photo"].ToString();

                                genreList.Add(objMember);
                            }
                        }
                    }
                    return objMember;
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

        public static bool AddMemberList(MEMBER objMember)
        {
            List<MEMBER> memberList = new List<MEMBER>();
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
                    sqlString = "INSERT into MEMBER values (@number, @joindate, @firstname, @lastname, @address, @city, @state, @zipcode, @phone, @member_status, @login_name, @password, @email, @contact_method, @subscription_id, @photo)";
                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@number", objMember.number);
                        objCommand.Parameters.AddWithValue("@joindate", objMember.joindate);
                        objCommand.Parameters.AddWithValue("@firstname", objMember.firstname);
                        objCommand.Parameters.AddWithValue("@lastname", objMember.lastname);
                        objCommand.Parameters.AddWithValue("@address", objMember.address);
                        objCommand.Parameters.AddWithValue("@city", objMember.city);
                        objCommand.Parameters.AddWithValue("@state", objMember.state);
                        objCommand.Parameters.AddWithValue("@zipcode", objMember.zipcode);
                        objCommand.Parameters.AddWithValue("@phone", objMember.phone);
                        objCommand.Parameters.AddWithValue("@member_status", objMember.member_status);
                        objCommand.Parameters.AddWithValue("@login_name", objMember.login_name);
                        objCommand.Parameters.AddWithValue("@password", objMember.password);
                        objCommand.Parameters.AddWithValue("@email", objMember.email);
                        objCommand.Parameters.AddWithValue("@contact_method", objMember.contact_method);
                        objCommand.Parameters.AddWithValue("@subscription_id", objMember.subscription_id);
                        objCommand.Parameters.AddWithValue("@photo", objMember.photo);

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

        public static bool UpdateMemberList(MEMBER objMember)
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
                    sqlString = "UPDATE MEMBER " + Environment.NewLine +
                                "set joindate = @joindate, " + Environment.NewLine +
                                "firstname = @firstname, " + Environment.NewLine +
                                "lastname = @lastname, " + Environment.NewLine +
                                "address = @address, " + Environment.NewLine +
                                "city = @city, " + Environment.NewLine +
                                "state = @state, " + Environment.NewLine +
                                "zipcode = @zipcode, " + Environment.NewLine +
                                "phone = @phone, " + Environment.NewLine +
                                "member_status = @member_status, " + Environment.NewLine +
                                "login_name = @login_name, " + Environment.NewLine +
                                "password = @password, " + Environment.NewLine +
                                "email = @email, " + Environment.NewLine +
                                "contact_method = @contact_method, " + Environment.NewLine +
                                "subscription_id = @subscription_id, " + Environment.NewLine +
                                "photo = @photo " + Environment.NewLine +
                                "WHERE number = @number";
                    //sqlString = "UPDATE MEMBER set joindate = @joindate, firstname = @firstname, lastname = @lastname, address = @address, city = @city, state = @state, zipcode = @zipcode, phone = @phone, member_status = @member_status, login_name = @login_name, password = @password, email = @email, contact_method = @contact_method, subscription_id = @subscription_id, photo = @photo, number = @number";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@number", objMember.number);
                        objCommand.Parameters.AddWithValue("@joindate", objMember.joindate);
                        objCommand.Parameters.AddWithValue("@firstname", objMember.firstname);
                        objCommand.Parameters.AddWithValue("@lastname", objMember.lastname);
                        objCommand.Parameters.AddWithValue("@address", objMember.address);
                        objCommand.Parameters.AddWithValue("@city", objMember.city);
                        objCommand.Parameters.AddWithValue("@state", objMember.state);
                        objCommand.Parameters.AddWithValue("@zipcode", objMember.zipcode);
                        objCommand.Parameters.AddWithValue("@phone", objMember.phone);
                        objCommand.Parameters.AddWithValue("@member_status", objMember.member_status);
                        objCommand.Parameters.AddWithValue("@login_name", objMember.login_name);
                        objCommand.Parameters.AddWithValue("@password", objMember.password);
                        objCommand.Parameters.AddWithValue("@email", objMember.email);
                        objCommand.Parameters.AddWithValue("@contact_method", objMember.contact_method);
                        objCommand.Parameters.AddWithValue("@subscription_id", objMember.subscription_id);
                        objCommand.Parameters.AddWithValue("@photo", objMember.photo);

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

        public static bool DeleteMemberList(MEMBER objMember)
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
                    sqlString = "DELETE MEMBER where number = @number";

                    using (objCommand = new SqlCommand(sqlString, mycon))
                    {
                        objCommand.Parameters.AddWithValue("@number", objMember.number);

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
