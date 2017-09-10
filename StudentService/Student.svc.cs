﻿using StudentService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Student" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Student.svc or Student.svc.cs at the Solution Explorer and start debugging.
    public class Student : IStudent
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public List<Models.Student> GetStudents()
        {

            List<Models.Student> Students = new List<Models.Student>();

            Students = db.Students.ToList();

            return Students;
        }

        public void AddStudent(string fullName)
        {
            
        }

        public void EditStudent(string Id)
        {

        }

        public void DeleteStudent(string Id)
        {

        }


        
    }
}
