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

        
    }
}
