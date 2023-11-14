using System;
using System.ComponentModel.DataAnnotations;

namespace WarsztatAPI.Entities
{
    public class Order
    {
        [Key]
        public int id_order { get; set; }
        public int user_id { get; set; }
        public DateTime order_date { get; set; }
        public string status { get; set; }
    }
}
