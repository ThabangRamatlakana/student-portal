using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POE.Models
{
    public class SemesterModuleDetail
    {
        public string ModuleCode { get; set; }
        public int SemesterId { get; set; }
        public int UserId { get; set; }
        public int SelfStudyHours { get; set; }
        public int RemainingHours { get; set; }

    }
}
