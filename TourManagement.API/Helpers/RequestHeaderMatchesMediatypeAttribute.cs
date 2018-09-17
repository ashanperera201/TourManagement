#region References
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using System;
using System.Linq;
#endregion

#region Namespace
namespace TourManagement.API.Helpers
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = true)]
    public class RequestHeaderMatchesMediaTypeAttribute : Attribute, IActionConstraint
    {
        private readonly string[] _mediaTypes;
        private readonly string _requestHeaderToMatch;

        public RequestHeaderMatchesMediaTypeAttribute(string requestHeaderToMatch,
            string[] mediaTypes)
        {
            _requestHeaderToMatch = requestHeaderToMatch;
            _mediaTypes = mediaTypes;
        }

        public int Order
        {
            get { return 0; }
        }

        public bool Accept(ActionConstraintContext context)
        {
            var requestHeaders = context.RouteContext.HttpContext.Request.Headers;

            if (!requestHeaders.ContainsKey(_requestHeaderToMatch))
            {
                return false;
            }

            foreach (var mediaTypes in _mediaTypes)
            {
                var headerValues = requestHeaders[_requestHeaderToMatch].ToString().Split(',').ToList();
                foreach (var headerValue in headerValues)
                {
                    if (string.Equals(headerValue, mediaTypes, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
#endregion