using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace POE.Controllers
{
    public class StudyController : Controller
    {
        // this is used to read Settings and Connection Strings from AppSettings. json file
        private readonly IConfiguration configuration;

        public StudyController(IConfiguration config)
        {
            this.configuration = config;
        }
        

        public IActionResult AddModule()
        {
            //declaring a variable which will contain the connection to my database
            string connectionstring = configuration.GetConnectionString("DefaultConnection");

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();// opening the connection
            
            string moduleQuery = "SELECT MODULE_CODE FROM MODULES";
            SqlCommand cmd = new SqlCommand(moduleQuery, con);
            var modules = cmd.ExecuteReader();
            List<string> _moduleList = new List<string>();//declaring a list that will store the module codes from the database
            while (modules.Read())// creating a while loop that will loop through the module_code column from the database
            {
                _moduleList.Add(modules.GetValue(0).ToString());// getting the value of the code and adding the name to the list I declared to be displayed
            }
            ViewBag.data = _moduleList;//type of dictionary that stores the data internally to be displayed, this will store all the module codes from the database
            return View();
            
        }
        
        public IActionResult LogStudyHours()
        {
            try
            {
                //function.ConnectionString uses the ClassLibrary to get the method that was created in the Functions
                //class that stores the ConnectionString
                string connectionstring = configuration.GetConnectionString("DefaultConnection");

                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();// opening the connection 
                string sqlquery = "SELECT * FROM dbo.SEMESTER_MODULE_DETAILS " +
                    "WHERE USER_ID = '" + this.result + "'"; //this would be used to get the information for the logged in student
                SqlCommand cmd = new SqlCommand(sqlquery, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    LogStudyHours.inputModName.Items.Add(dr["MODULE_CODE"]);// this would be used to populate the form with the modules of that student and give them an option to choose
                }
                con.Close();// closing the connection
            }
            catch (Exception)
            {
                //this would be to display that message saying that theres an error that has occured
                TempData["msg"] = "<script>alert('An error has occured!');</script>";
            }
            return View();
        }
        public IActionResult ViewModules()
        {
            return View();
        }
    }
}
