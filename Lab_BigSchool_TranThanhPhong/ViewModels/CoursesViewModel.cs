using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab_BigSchool_TranThanhPhong.Models;

namespace Lab_BigSchool_TranThanhPhong.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}