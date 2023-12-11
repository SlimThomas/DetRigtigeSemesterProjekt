using System.ComponentModel.DataAnnotations;

namespace DetRigtigeSemesterProjekt.Models
{
    public class HundeEjer : Person
    {
        [Display(Name = "Addresse")]
        [Required(ErrorMessage = "Der skal angives en Addresse"), MaxLength(20)]
        public string Address { get; set; }


        public HundeEjer() { }

        public HundeEjer(int id, string address, string name, int tlf, string mail)
            : base(id, name, tlf, mail)
        {
            Address = address;
        }
    }
}
