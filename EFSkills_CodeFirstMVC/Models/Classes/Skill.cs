using System.ComponentModel.DataAnnotations;

namespace EFSkills_CodeFirstMVC.Models.Classes
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string Desc { get; set; }
        public byte Value { get; set; }
    }
}