using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2Adv.Models
{
    public class Kurs
    {
        [Key]
        public int KursId { get; set; }
        public int LärId { get; set; }
        public int StudId { get; set; }
        public string KursNamn { get; set; }
        public string Betyg { get; set; }
        public bool IsActive { get; set; }

   
        public static List<Kurs> GetKurs()
        {
            return new List<Kurs>()
            {
                new Kurs{ LärId = 1, StudId = 1, KursNamn = "Matte", Betyg = "", IsActive = true},
                new Kurs{ LärId = 1, StudId = 2, KursNamn = "Matte", Betyg = "G", IsActive = false},
                new Kurs{ LärId = 1, StudId = 3, KursNamn = "Engelska", Betyg = "G", IsActive = false},
                new Kurs{ LärId = 1, StudId = 4, KursNamn = "Engelska", Betyg = "", IsActive = true},
                new Kurs{ LärId = 2, StudId = 1, KursNamn = "Programmering1", Betyg = "G", IsActive = false},
                new Kurs{ LärId = 2, StudId = 2, KursNamn = "Programmering1", Betyg = "", IsActive = true},
                new Kurs{ LärId = 3, StudId = 3, KursNamn = "Programmering2", Betyg = "", IsActive = true},
            };
        }
    }
}
