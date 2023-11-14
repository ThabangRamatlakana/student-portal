using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using POE.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using PartOneLibrary;
namespace POE.Controllers
{
    public class UserController : Controller
    {
        //calling the Functions class from the custom class library
        Functions function = new Functions();
        // this is used to read Settings and Connection Strings from AppSettings. json file
        private readonly IConfiguration configuration;

        public UserController(IConfiguration config)
        {
            this.configuration = config;
        }
        public IActionResult MainPage()
        {
            return View();
        }

        public IActionResult Login()
        {
            //using try catch in case of errors that might occur when running the application
            try
            {
                //declaring a variable which will contain the connection to my database
                string connectionstring = configuration.GetConnectionString("DefaultConnection");

                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();// openining the connection
                string add_data = "SELECT COUNT(USER_NAME) FROM dbo.USERS WHERE USER_NAME = @USER_NAME AND USER_PASSWORD = @USER_PASSWORD";
                SqlCommand cmd = new SqlCommand(add_data, con);
                cmd.Parameters.AddWithValue("@USER_NAME",Login.username.Text);// supposed to get the username the user input from the Login page
                string newPassword = function.HashPassword(Login.pass.Text);// supposed to get the password the user input from the Login page
                cmd.Parameters.AddWithValue("@USER_PASSWORD", newPassword);
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();// closing the connection
                Login.pass.Text = "";
                if (Count > 0)
                {
                    con.Open();
                    string query = "SELECT USER_ID FROM dbo.USERS WHERE USER_NAME = '" + Login.username.Text.Text.Trim() + "'";// supposed to get the data from the database where the userName is equal to the username the user inserted in the login page
                    SqlCommand cmd2 = new SqlCommand(query, con);
                    Int32 result = (Int32)cmd2.ExecuteScalar();
                    con.Close();
                }
                else
                {
                    ///this would be to clear the form when incorrect information is added
                    username.Clear();
                    pass.Clear();
                    //this would be to display that message saying that the password or information is incorrect
                    TempData["msg"] = "<script>alert('Password or username is not correct');</script>";
                    //if password or username is incorrect and 
                    //doesnt match that from the DB it will show the user this message telling them that what they
                    //entered is wrong
                }
            }
            catch (Exception )
            {
               
            }
             return View();
        }
        
        //this method will check in the databse, what the last user ID was then populate the next userID for 
        //a new student that wants to sign up
        public IActionResult SignUp()
        {
            //declaring a variable which will contain the connection to my datase
            string connectionstring = configuration.GetConnectionString("DefaultConnection");

            SqlConnection con = new SqlConnection(connectionstring);
       
            int userId;
            string query = "SELECT USER_ID FROM dbo.USERS ORDER BY USER_ID DESC";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                userId = id;
            }
            else if (Convert.IsDBNull(dr))
            {
                userId = 0000;
            }
            else
            {
                userId = 0001;
            }

            con.Close();
            //type of dictionary that stores the data internally to be displayed
            ViewData["UserId"] = userId.ToString();
            return View();
        }

        //public void SigningUp()
        //{
        //    string connectionstring = configuration.GetConnectionString("DefaultConnection");
        //    SqlConnection con = new SqlConnection(connectionstring);
        //    con.Open();
        //    string add_data = "INSERT INTO dbo.USERS VALUES( @USER_NAME, @USER_PASSWORD)";
        //    SqlCommand cmd = new SqlCommand(add_data, con);
        //    cmd.Parameters.AddWithValue("@USER_NAME", Username.text);
        //    //function.HashPassword executes the method that is in the class library for hashing a password
        //    cmd.Parameters.AddWithValue("@USER_PASSWORD", function.HashPassword(password.Password));
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

    }
        
    
}
