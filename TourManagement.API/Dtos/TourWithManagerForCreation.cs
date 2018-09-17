#region References
#endregion

#region Namespace
namespace TourManagement.API.Dtos
{
    public class TourWithManagerForCreation : TourForCreation
    {
        public string ManagerId { get; set; }
    }
}
#endregion