#region References
using System.Collections.Generic;
#endregion

#region Namespace
namespace TourManagement.API.Dtos
{
    public class TourWithShowsForCreation : TourForCreation
    {
        public ICollection<ShowForCreation> Shows { get; set; } = new List<ShowForCreation>();
    }
}
#endregion