using Microsoft.AspNetCore.Authorization;

namespace Shared.Integration.Authorization.Attributes;

public class AuthorizeRoles : AuthorizeAttribute
{
    public AuthorizeRoles(params string[] roles)
    {
        Roles = string.Join(",", roles);
    }
}