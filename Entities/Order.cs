using System;
using System.ComponentModel.DataAnnotations;

namespace WarsztatAPI.Entities
{
    public class Order
    {
        [Key]
        public int id_order { get; set; }
        public int user_id { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string status { get; set; }
        public string meals_info { get; set; }
        public string order_price { get; set; }
        public string meals_price { get; set; }
        public string transport { get; set; }
    }
}
