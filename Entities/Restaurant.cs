using System.ComponentModel.DataAnnotations;

namespace WarsztatAPI.Entities
{
    public class Restaurant
    {
        [Key]
        public int id_restaurant { get; set; }
        public string name { get; set; }
        public string deliverytime { get; set; }
        public float deliveryprice { get; set; }
        public float rating { get; set; }
        public int ratingcount { get; set; }
        public string category { get; set; }
        public string image_url { get; set; }
        public string logo_url { get; set; }
    }
}
