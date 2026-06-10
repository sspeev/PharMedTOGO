using System.Security.Claims;
using static PharMedTOGO.Core.Constants.MessageConstants;

namespace PharMedTOGO.Extensions;

public static class ClaimsPrincipalExtension
{
    public static string Id(this ClaimsPrincipal user) => user.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
    public static bool IsAdmin(this ClaimsPrincipal user) => user.IsInRole(AdminConstant);
}
