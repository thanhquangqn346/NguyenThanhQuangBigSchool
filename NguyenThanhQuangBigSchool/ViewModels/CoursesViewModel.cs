using NguyenThanhQuangBigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenThanhQuangBigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Coures> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}