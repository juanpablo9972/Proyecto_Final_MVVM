using System.ComponentModel.DataAnnotations;

namespace API_PHONE.Models
{
    public class api_phone
    {
        [Key]
        public int PersonID { get; set; }

        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }

        [Required]
        public BloodType Type_B { get; set; }


    }

    public enum BloodType
    {
        A_Pos,
        A_Neg,
        B_Pos,
        B_Neg,
        AB,
        O,

    }
}