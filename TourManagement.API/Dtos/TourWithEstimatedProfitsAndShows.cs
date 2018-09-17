#region References
using System.Collections.Generic;
#endregion

#region Namespace
namespace TourManagement.API.Dtos
{
    public class TourWithEstimatedProfitsAndShows : TourWithEstimatedProfits
    {
        public ICollection<Show> shows { get; set; } = new List<Show>();
    }
}
#endregion
