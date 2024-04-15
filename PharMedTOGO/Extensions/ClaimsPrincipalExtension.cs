using System.Security.Claims;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminConstant);
        }
    }
}
