using System;
using System.Collections.Generic;
using System.Text;

namespace PartOneLibrary
{
   public class SemesterModuleDetail
    {

        public SemesterModuleDetail()
        {

        }

        private string modulecCode;

        public string ModuleCode
        {
            get { return modulecCode; }
            set { modulecCode = value; }
        }

        private int semesterID;

        public int SemesterID
        {
            get { return semesterID; }
            set { semesterID = value; }
        }

        private int userID;

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private int selfStudyHours;

        public int SelfStudyHours
        {
            get { return selfStudyHours; }
            set { selfStudyHours = value; }
        }

        private int remainingHours;

        public int RemainingHours
        {
            get { return remainingHours; }
            set { remainingHours = value; }
        }

    }
}
