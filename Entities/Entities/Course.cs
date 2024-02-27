using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Course : BaseEntity<int>
    {
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
    }
}
