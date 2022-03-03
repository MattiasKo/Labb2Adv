using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2Adv.Models
{
    public class Student
    {
        [Key]
        public int StudId { get; set; }
        public string StudName { get; set; }
        public string StudLname { get; set; }

        public static List<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student{ StudId = 1, StudName = "Olaf", StudLname = "Olofsson"},
                new Student{ StudId = 2, StudName = "Mattias", StudLname = "Arvidsson"},
                new Student{ StudId = 3, StudName = "Sanna", StudLname = "Isaksson"},
                new Student{ StudId = 4, StudName = "Regnar", StudLname = "Valhalla"},
            };
        }
    }
}
