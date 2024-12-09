using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodefirstDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column("EmployeName", TypeName ="varchar(100)")]
        public string name { get; set; }
        public int age { get; set; }
        public string phone { get; set; }   

        public string email { get; set; }
        public string phoneNumber { get; set; } = string.Empty;
        public string city { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public string city_name { get; set;
    }
        public string country_name { get; set; }
}
    }