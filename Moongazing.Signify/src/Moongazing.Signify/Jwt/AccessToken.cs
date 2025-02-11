﻿namespace Moongazing.Signify.Jwt;

public class AccessToken
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }

    public AccessToken()
    {
        Token = string.Empty;
    }
    public AccessToken(string token, DateTime expiration)
    {
        Token = token;
        Expiration = expiration;
    }
}
