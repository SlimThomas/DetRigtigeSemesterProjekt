using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace DetRigtigeSemesterProjekt.Models
{
    public class Location
    {
        public Location()
        { 
        }
        public string Town { get; set; }
        public string Address { get; set; }
        public int Postnr { get; set; }
        public string Name { get; set; }


        public Location(string town, string adress, int postnr, string name)
        {
            Town = town;
            Address = adress;
            Postnr = postnr;
            Name = name;
        }

        // Her har vi lavet en get, set metode så vi kan lave en location samt give det en constructor nedenunder.
    }
}
