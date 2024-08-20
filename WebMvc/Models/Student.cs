using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvc.Models
{
    public class Student
    {
        [Key]
        public int MaSinhVien { get; set; }
        public int HoTen { get; set; } 
        
    }

}