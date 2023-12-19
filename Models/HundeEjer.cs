using System.ComponentModel.DataAnnotations;

namespace DetRigtigeSemesterProjekt.Models
{
    // (Thomas) Her anvender vi vores base class, som er "person". 
    public class HundeEjer : Person
    {
        [Display(Name = "Addresse")]
        [Required(ErrorMessage = "Der skal angives en Addresse"), MaxLength(20)]
        public string Address { get; set; }


        public HundeEjer() { }
        // Her bliver der lavet en default constructor, samt en constructor med properties fra superclassen (ses efter base), hvorpå den eneste unikke her er "Address"
        public HundeEjer(int id, string address, string name, int tlf, string mail)
            : base(id, name, tlf, mail)
        {
            Address = address;
        }
    }
}
