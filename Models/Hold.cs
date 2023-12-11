using System.ComponentModel.DataAnnotations;

namespace DetRigtigeSemesterProjekt.Models
{
    public class Hold
    {
        [Display(Name = "Træner")]
        [Required(ErrorMessage = "Der skal være en træner til et hold")]
        //[RegularExpression("^[a-zA-z ]*$")]
        public string Træner { get; set; }

        [Display(Name = "Hund")]
        [Required(ErrorMessage = "Der skal være en hund i et hold")]
        //[RegularExpression("^[a-zA-z ]*$")]
        public string Hund { get; set; }

        [Display(Name = "Lokation")]
        [Required(ErrorMessage = "Der skal være en location til et hold")]
        public string Location { get; set; }

        [Display(Name = "HundeEjer")]
        [Required(ErrorMessage = "Der skal være en hundeejer i et hold")]
        //[RegularExpression("^[a-zA-z ]*$")]
        public string HundeEjer { get; set; }
        //[RegularExpression] er et forsøg på at sørge for at vores properties ikke kan indholde tal i deres strings.

        [Display(Name = "Hold ID")]
        [Required(ErrorMessage = "Et hold skal have et ID")]
        [Range(typeof(int), minimum: "0", maximum: "10000", ErrorMessage = "ID skal være mellem {1} og {2}")]
        public int Id { get; set; }

        public Hold(string træner, string hund, string location, string hundeEjer, int id)
        {
            Træner = træner;
            Hund = hund;
            Location = location;
            HundeEjer = hundeEjer;
            Id = id;
        }
        public Hold() { }
    }
}
