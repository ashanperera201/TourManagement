#region References
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
#endregion

#region Namespace
namespace TourManagement.API.Dtos
{
    public class TourAbstractBase : IValidatableObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is required")]
        [MaxLength(200, ErrorMessage = "Title is too long")]
        public string Title { get; set; }
        public virtual string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!(StartDate < EndDate))
            {
                yield return new ValidationResult("The start date should be smalller than the end date.", new[] { "Tour" });
            }
        }
    }
}
#endregion