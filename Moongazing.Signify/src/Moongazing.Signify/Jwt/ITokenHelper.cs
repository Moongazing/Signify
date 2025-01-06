using Moongazing.Signify.Entities;

namespace Moongazing.Signify.Jwt;

public interface ITokenHelper
{
    AccessToken CreateToken(UserEntity user, IList<OperationClaimEntity> operationClaims);
    RefreshTokenEntity CreateRefreshToken(UserEntity user, string ipAddress);
}