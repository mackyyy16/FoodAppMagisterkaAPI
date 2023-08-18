using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarsztatAPI.Entities
{
    public class Food
    {
        [Key]
        public int id_food { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public string path_to_image { get; set; }
        public int amount { get; set; }
    }
}
