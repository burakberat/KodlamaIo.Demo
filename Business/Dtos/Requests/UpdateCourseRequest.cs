﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests
{
    public class UpdateCourseRequest
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
    }
}
