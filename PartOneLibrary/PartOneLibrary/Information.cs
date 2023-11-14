using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PartOneLibrary
{
    public class Information 
    {

        public Information()
        {

        }


        private int remainingHours;

        public int RemainingHours
        {
            get { return remainingHours; }
            set { remainingHours = value; }
        }

        Semester semester;
       // ModuleHours moduleHours = new ModuleHours();
        Module module;
       
        public void SemesterInput(Semester semester)
        {
            this.semester = semester;
        }

        public void ModuleInput(Module module)
        {
            this.module = module;
        }

        public string DisplaySemester()
        {
            return semester.ToString();
        }

        
        public int CalculateSelfStudyHours(Module module, int weeks)
        {
            return ((module.Credits * 10) / weeks) - module.ClassHours;
        }

        //this method is taking in all the information of a module as parameters and will be used in the application to display the values
        public string DisplayInfo(string modCode, string modName, int credits, int hours, int weeks, DateTime startDate, int selfStudyHours, int remainingHrs)
        {
            return "\n Module Code: " + modCode + "\n Module Name: " + modName + "\n Module Credits: " + credits
                + "\n Class Hours per week: " + hours + "\n Semester weeks: " + weeks + "\n Semester start date: "
                + startDate + "\n Weekly self study hours: " + selfStudyHours + "\n Remaining weekly hours: " + remainingHrs;
        }

       

        //this will calculate the remaining hours for that module
        public int CalculateRemainingHours(int selfStudyHours, int hours)
        {
            return selfStudyHours - hours;
        }

    }


}




