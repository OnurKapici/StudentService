using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentService.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string StudentNo { get; set; }
        public string ClassNo { get; set; }
    }
}