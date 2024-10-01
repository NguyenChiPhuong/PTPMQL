using System.ComponentModel.DataAnnotations;

namespace WebMvc.Models
{
    public class Person
    {
        [Key]
        public string CCCD { get; set; }

        public string HoTen { get; set; }

        public string DiaChi { get; set; }

    }

}