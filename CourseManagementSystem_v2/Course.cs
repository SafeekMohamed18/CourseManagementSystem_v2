using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v2
{
    internal class Course
    {
        public string CourseId { get; set; }
        public string title { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
    }
}
