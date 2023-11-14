using System.ComponentModel.DataAnnotations;

namespace WarsztatApi.Entities {
    public class Category{
        [Key]
        public int id_category { get; set;}
        public string name { get; set;}
        public string image_url { get; set;}
    }
}