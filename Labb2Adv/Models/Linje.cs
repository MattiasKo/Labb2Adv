using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Labb2Adv.Models
{
    public class Linje
    {
        [Key]
        public int LinjeId { get; set; }
        public string LinjeNamn { get; set; }
        public int StudID { get; set; }



        public static List<Linje> GetLinjes()
        {
            return new List<Linje>()
            {
                new Linje{ LinjeId=1, LinjeNamn ="SUT21", StudID = 1},
                new Linje{ LinjeId=2, LinjeNamn ="SUT21", StudID = 2},
                new Linje{ LinjeId=3, LinjeNamn ="SUT21", StudID = 3},
                new Linje{ LinjeId=4, LinjeNamn ="SUT21", StudID = 4},
                new Linje{ LinjeId=5, LinjeNamn ="SUT20", StudID = 5},
            };
        }
    }
    
}
