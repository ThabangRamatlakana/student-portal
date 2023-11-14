using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POE.Models
{
    public class Module
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int ModuleCredits { get; set; }
        public int ClassHours { get; set; }
    }
}
