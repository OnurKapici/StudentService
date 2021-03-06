﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudent" in both code and config file together.
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        void AddStudent(string FullName, string StudentNo, string ClassNo);

        [OperationContract]
        void EditStudent(int Id, string FullName, string StudentNo, string ClassNo);

        [OperationContract]
        void DeleteStudent(int Id);

        [OperationContract]
        List<Models.Student> GetStudents();
    }
}
