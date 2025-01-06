namespace Moongazing.Signify.Entities;

public class UserEntity : Entity<Guid>
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string? PhoneNumber { get; set; }
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public AuthenticatorType AuthenticatorType { get; set; }
    public bool IsActive { get; set; }
    public virtual ICollection<UserOperationClaimEntity> UserOperationClaims { get; set; } = new HashSet<UserOperationClaimEntity>();
    public virtual ICollection<RefreshTokenEntity> RefreshTokens { get; set; } = new HashSet<RefreshTokenEntity>();
    public virtual ICollection<EmailAuthenticatorEntity> EmailAuthenticators { get; set; } = new HashSet<EmailAuthenticatorEntity>();
    public virtual ICollection<OtpAuthenticatorEntity> OtpAuthenticators { get; set; } = new HashSet<OtpAuthenticatorEntity>();
}
