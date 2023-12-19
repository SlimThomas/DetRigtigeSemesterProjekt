namespace DetRigtigeSemesterProjekt.Models
{
    public class Location
    {
        public Location()
        { }
        public string Town { get; set; }
        public string Address { get; set; }
        public int postnr { get; set; }
        public string location { get; set; }


        public Location(string town, string adress, int postnr, string location)
        {
            Town = town;
            Address = adress;
            this.postnr = postnr;
            this.location = location;
        }

        // Her har vi lavet en get, set metode så vi kan lave en location samt give det en constructor nedenunder.

        //public override string ToString()
        //{
        //    return $"{{{nameof(Town)}={Town}, {nameof(Address)}={Address}, {nameof(postnr)}={postnr.ToString()}, {nameof(location)}={location}}}";
        //}
    }
}
