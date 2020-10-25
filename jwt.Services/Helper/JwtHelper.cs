using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace jwt.Services.Helper
{
    public static class JwtHelper
    {
        public static string GetClaimTokenByRequest(HttpRequest Request, string claim)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            string authHeader = Request.Headers["Authorization"];
            authHeader = authHeader.Replace("Bearer ", "");
            JwtSecurityToken token = handler.ReadToken(authHeader) as JwtSecurityToken;

            return token.Claims.First(cl => cl.Type == claim).Value;
        }
    }
}
