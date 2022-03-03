using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2Adv.Models
{
    public class Lärare
    {
       
        [Key]
        public int LärarId { get; set; }
        public string Name { get; set; }
        public string EfterNamn { get; set; }

        public static List<Lärare> GetLärares()
        {
            return new List<Lärare>()
            {
                new Lärare{ LärarId = 1, Name = "Anas", EfterNamn = "Hussain"},
                new Lärare{ LärarId = 2, Name = "Tobias", EfterNamn = "Karlsson"},
                new Lärare{ LärarId = 3, Name = "Reidar", EfterNamn = "Johansson"},
            };
        }

    }
}
