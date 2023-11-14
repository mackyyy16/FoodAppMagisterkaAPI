using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarsztatAPI.Entities
{
    public class Meal
    {
        [Key]
        public int id_meal { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string image_path { get; set; }
    }
}
