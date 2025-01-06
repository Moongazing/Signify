using Microsoft.Extensions.DependencyInjection;
using Moongazing.Signify.EmailAuthenticator;
using Moongazing.Signify.Jwt;
using Moongazing.Signify.OtpAuthenticatior;

namespace Moongazing.Signify;
public static class SignifyServiceRegistration
{
    public static IServiceCollection AddSignifyServices(this IServiceCollection services)
    {

        services.AddScoped<ITokenHelper, JwtHelper>();
        services.AddScoped<IEmailAuthenticatorHelper, EmailAuthenticatorHelper>();
        services.AddScoped<IOtpAuthenticatorHelper, OtpNetOtpAuthenticatorHelper>();

        return services;
    }
}