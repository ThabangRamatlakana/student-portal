using System;

namespace PartOneLibrary
{
    public class Module
    {
        ///Constructor
        public Module()
        {

        }

        //properties
        private string code;
        
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int credits;

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        private int classHours;

        public int ClassHours
        {
            get { return classHours; }
            set { classHours = value; }
        }

       public int SelfStudyHours { get; set; }

        public override string ToString()
        {
            return "The module code: " + Code + "\n The module name: " + Name + "\n The number of credits: " + Credits + "\n Class hours: " + ClassHours;
        }

       

    }
}
