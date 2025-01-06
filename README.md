# Signify

This project is a modular and extensible authentication and security library built in .NET. It provides a comprehensive set of tools and helpers for handling secure authentication, authorization, token management, and encryption. The library supports various authentication methods, including JWT, OTP, and email-based authentication.
Project Structure
1. Attributes

    ApiKeyAttribute.cs
    A custom attribute for validating API key authentication at the controller or method level.

2. EmailAuthenticator

    EmailAuthenticatorHelper.cs
    Contains helper methods to handle email-based authentication operations, such as generating and validating email authentication tokens.

    IEmailAuthenticatorHelper.cs
    Interface defining the contract for EmailAuthenticatorHelper.

3. Encryption

    SecurityKeyHelper.cs
    Provides methods for generating and managing security keys used in encryption and signing processes.

    SigningCredentialsHelper.cs
    Contains methods for creating signing credentials using security keys for token generation.

4. Entities
Common

    Entity.cs
    Base class providing shared properties for all entities.

    IEntity.cs
    Interface ensuring entity implementations have a consistent structure.

    IEntityTimestamps.cs
    Interface for entities that require tracking of timestamps for creation and updates.

Specific Entities

    AuthenticatorType.cs
    Enum representing different authenticator types supported by the library.

    EmailAuthenticatorEntity.cs
    Represents an email authenticator entity.

    OperationClaimEntity.cs
    Represents operation claims for authorization.

    OtpAuthenticatorEntity.cs
    Represents an OTP-based authenticator entity.

    RefreshTokenEntity.cs
    Represents refresh tokens used for session management.

    UserEntity.cs
    Represents a user entity with authentication and authorization details.

    UserOperationClaimEntity.cs
    Represents the relationship between users and their operation claims.

5. Extensions

    ClaimExtensions.cs
    Helper methods for working with claims in authorization.

    ClaimsPrincipalExtensions.cs
    Extensions to simplify working with ClaimsPrincipal for extracting user and role information.

6. Hashing

    HashingHelper.cs
    Contains methods for hashing and verifying passwords or other sensitive data.

7. Jwt (JSON Web Tokens)

    AccessToken.cs
    Represents an access token containing token details and expiration information.

    ITokenHelper.cs
    Interface defining the contract for token generation and validation.

    JwtHelper.cs
    Implementation of JWT token generation and validation.

    TokenOptions.cs
    Represents configurable options for token generation, such as issuer, audience, and expiration.

8. OtpAuthenticator

    IOtpAuthenticatorHelper.cs
    Interface defining the contract for OTP (One-Time Password) authenticator helpers.

    OtpNetOtpAuthenticatorHelper.cs
    Implementation of OTP-based authentication using the OtpNet library.

Features

    Authentication: Support for JWT and OTP-based authentication mechanisms.
    Authorization: Role and claim-based authorization using OperationClaimEntity and UserOperationClaimEntity.
    Security: Encryption and signing utilities to ensure secure token management.
    Modular Design: Interfaces and helper classes for extensibility and maintainability.
    Email-Based Authentication: Seamlessly generate and validate email authentication tokens.
    Timestamps Tracking: Automatic tracking of creation and update timestamps for entities.
    Extensions: Simplified handling of claims and user information via extension methods.
    Hashing: Secure password hashing and verification.

Requirements

    .NET Version: .NET 6 or higher.
    NuGet Packages:
        OtpNet (for OTP-based authentication)
        Newtonsoft.Json (if applicable for JSON serialization/deserialization)

Usage
1. JWT Authentication

To use JWT for authentication:

    Configure TokenOptions with issuer, audience, and expiration details.
    Use JwtHelper to generate access tokens.

var tokenHelper = new JwtHelper();
var accessToken = tokenHelper.CreateToken(user, operationClaims);

2. Email Authentication

Generate and validate email authentication tokens using EmailAuthenticatorHelper.

var emailHelper = new EmailAuthenticatorHelper();
var token = emailHelper.GenerateEmailToken(userEmail);
var isValid = emailHelper.ValidateEmailToken(token, userEmail);

3. OTP Authentication

Integrate OTP authentication using OtpNetOtpAuthenticatorHelper.

var otpHelper = new OtpNetOtpAuthenticatorHelper();
var otpCode = otpHelper.GenerateOtp(secretKey);
var isOtpValid = otpHelper.ValidateOtp(secretKey, otpCode);

Contributing

Contributions are welcome! Please follow these steps:

    Fork the repository.
    Create a new branch for your feature/bug fix.
    Submit a pull request with detailed information.

License

This project is licensed under the MIT License. See the LICENSE file for more details.
