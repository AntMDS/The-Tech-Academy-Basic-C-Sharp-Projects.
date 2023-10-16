using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentDatabase.ViewModels
{
    public class Student : Grade
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Grade Grade { get; set; }
    }
}