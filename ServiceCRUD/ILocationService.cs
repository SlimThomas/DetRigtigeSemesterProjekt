using DetRigtigeSemesterProjekt.Models;
namespace DetRigtigeSemesterProjekt.ServiceCRUD
{
    public interface ILocationService
    {
        
            List<Location> GetLocation();
            void AddLocation(Location location);

            void UpdateLocation(Location location);

            Location GetLocation(string id);

            Location DeleteLocation(string? id);
            
            Location EditLocation(string id);

        
    }
    // Her har vi en liste over det CRUD som hører til Location, samt det interface som snakker sammen med LocationService
}
