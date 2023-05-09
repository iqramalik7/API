using System.ComponentModel.DataAnnotations;

namespace practiceset.Models
{
    public class Student
    {
        [Key]
        public int Roll { get; set; }
        public string Name { get; set; }
        public string department { get; set; }
        public string section { get; set; }

    }
}
