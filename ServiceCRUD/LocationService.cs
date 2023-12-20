using static DetRigtigeSemesterProjekt.ServiceCRUD.LocationService;
using DetRigtigeSemesterProjekt.Models;
using DetRigtigeSemesterProjekt.MockData;
using DetRigtigeSemesterProjekt.Pages;

namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    public class LocationService : ILocationService
    {

        // Her har vi en liste over de CRUD til Location, og en foreach samt en return af alle CRUD´sne

        public List<Location> LocationListe { get; private set; }

        public List<Location> GetLocation()
        {
            return LocationListe;
        }

        public void AddLocation(Location location)
        {
            LocationListe.Add(location);
        }

        public void UpdateLocation(Location location)
        {
            if (location != null)
            {
                foreach (Location i in LocationListe)
                {
                    if (i.Address == location.Address)
                    {
                        i.Name = location.Name;
                        i.Postnr = location.Postnr;
                    }
                }
            }
        }

        public Location GetLocation(string id)
        {
            foreach (Location locationId in LocationListe)
            {
                if (locationId.Address == id)
                {
                    return locationId;
                }
            }
            return null;
        }

        public Location DeleteLocation(string? id)
        {
            foreach (Location location in LocationListe)
            {
                if (location.Address == id)
                {
                    LocationListe.Remove(location);
                    return location;
                }
            }
            return null;
        }

       public List<Location> GetLocationliste()
        {
            throw new NotImplementedException();
        }

        public LocationService GetLocation(int id)
        {
            throw new NotImplementedException();
        }

        public Location EditLocation(string id)
        {
            throw new NotImplementedException();
        }
    }
}

