using System.ComponentModel.DataAnnotations;

namespace WarsztatApi.Entities {
    public class User{
        [Key]
        public int id_user { get; set;}
        public string password { get; set;}
        public string email { get; set;}
        public string phonenumber { get; set; }
    }
}