using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentAPI.data
{
    public class DummyData
    {
        public static List<Students> GetStudents()
        {
            List<Students> student = new List<Students>() {
                new Students {StudentId="A00111111", FirstName = "John",LastName = "Archer",Program="CIT"},
                new Students {StudentId="A00222222", FirstName = "Jane",LastName = "Baker",Program="CST"},
                new Students {StudentId="A00333333", FirstName = "Bill",LastName = "Carter",Program="BTECH"},
                new Students {StudentId="A00444444", FirstName = "Judy",LastName = "Fisher",Program="Nursing"}
            };
            return student;
        }
    }
}