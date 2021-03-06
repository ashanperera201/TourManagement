﻿#region References
using System.ComponentModel.DataAnnotations;
#endregion

#region Namespace
namespace TourManagement.API.Dtos
{
    public class TourForUpdate : TourAbstractBase
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="When updating a tour,the description is required.")]
        public override string Description
        { get => base.Description; set => base.Description = value; }
    }
}
#endregion