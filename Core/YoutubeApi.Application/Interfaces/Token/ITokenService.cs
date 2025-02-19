﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Interfaces.Token
{
    public interface ITokenService
    {
        Task<JwtSecurityToken> CreateToken(User user, IList<string> roles);

        string GenerateRefreshToken();

        ClaimsPrincipal? GetPrincipalFromExpiredToken();
    }
}
