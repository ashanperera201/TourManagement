#region References
using System.Collections.Generic;
#endregion

#region Namespace
namespace TourManagement.API.Dtos
{
    public class TourWithShows : Tour
    {
        public ICollection<Show> Shows { get; set; } = new List<Show>();
    }
}
#endregion