using System;
using System.Collections.Generic;
using System.Text;

namespace PartOneLibrary
{
    public class Semester 
    {
        
        public Semester()
        {

        }

        private string semesterID;

        public string SemesterID
        {
            get { return semesterID; }
            set { semesterID = value; }
        }


        private int weeks;

        public int Weeks
        {
            get { return weeks; }
            set { weeks = value; }
        }

        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }


    }
}
