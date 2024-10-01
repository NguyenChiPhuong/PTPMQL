using System.ComponentModel.DataAnnotations;
namespace WebMvc.Models
{
    public class Employee : Person
    {
        public string SDT { get; set; }

        public string Email { get; set; }
    }
}
