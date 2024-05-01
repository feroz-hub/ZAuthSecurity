namespace Domain.Constants.Endpoint;

public class AuthenticationConstants
{
    private const string SecurityFrameworkName = "ZAuthSecurityFramework";
    public const string SecurityFrameworkType = SecurityFrameworkName;
    public const string ExternalAuthenticationMethod = "external";
    public const string DefaultHashAlgorithm = "SHA256";
    public const string LocalIdentityProvider = "local";
    public const string DefaultCookieAuthenticationScheme = "sf.Identity";
    public const string SignOutScheme = "sf.Identity";
    public const string ExternalCookieAuthenticationScheme = "sf.External";
    public const int DefaultVerificationCodeExpiration = 60;
    public const int QueryStringLength = 128;
    public const int KeySize16 = 16;
    public const int KeySize32 = 32;
    public const int KeySize24 = 24;
    public static readonly TimeSpan DefaultCookieTimeSpan = TimeSpan.FromHours(10);
    public static readonly TimeSpan DefaultCacheDuration = TimeSpan.FromMinutes(60);

    public static class EnvironmentPaths
    {
        public const string SecurityFrameworkBasePath = "sf:SecurityFrameworkServerBasePath";
        public const string SignOutCalled = "sf:SecurityFrameworkServerSignOutCalled";
    }

    public static class ParsedTypes
    {
        public const string NoSecret = "NoSecret";
        public const string SharedSecret = "SharedSecret";
        public const string JwtBearer = "urn:ietf:params:oauth:client-assertion-type:jwt-bearer";
    }

    public static class SecretTypes
    {
        public const string SharedSecret = "SharedSecret";
        public const string JsonWebKey = "JWK";
        public const string X509Certificate = "X509Certificate";
    }

    public static class ApplicationUiConstants
    {
        public const int CookieMessageThreshold = 2;

        public static class DefaultRoutePathParams
        {
            public const string Error = "errorId";
            public const string Login = "returnUrl";
            public const string Logout = "logoutId";
            public const string EndSessionCallback = "endSessionId";
        }

        public static class DefaultRoutePaths
        {
            public const string Login = "/account/login";
            public const string Logout = "/account/logout";
            public const string Error = "/home/error";
        }
    }

    public static class GrantTypes
    {
        public const string Hybrid = "hybrid";
        public const string AuthorizationCode = "authorization_code";
        public const string ClientCredentials = "client_credentials";
        public const string ResourceOwnerPassword = "password";
    }

    public static class ProtocolTypes
    {
        public const string OpenIdConnect = "oidc";
    }

    public static readonly List<string> CodeChallengeMethods =
    [
        OpenIdConstants.CodeChallengeMethods.Plain, OpenIdConstants.CodeChallengeMethods.Sha256,
        OpenIdConstants.CodeChallengeMethods.Hmac
    ];

    public static class IdentityScopes
    {
        public const string OpenId = "openid";
        public const string Profile = "profile";
        public const string Email = "email";
        public const string Address = "address";
        public const string Phone = "phone";
        public const string OfflineAccess = "offline_access";
    }

    public static class AuthCodeStore
    {
        public const string AuthCodeRequestObjectName = "authzId";
        public const string ReturnUrlCode = "returnUrlId";
        public const string UserVerificationCode = "UserCode";
    }

    public static readonly List<string> AllowedResponseTypes =
    [
        OpenIdConstants.ResponseTypes.Code,
        OpenIdConstants.ResponseTypes.Token,
        OpenIdConstants.ResponseTypes.IdToken,
        OpenIdConstants.ResponseTypes.IdTokenToken,
        OpenIdConstants.ResponseTypes.CodeIdToken,
        OpenIdConstants.ResponseTypes.CodeToken,
        OpenIdConstants.ResponseTypes.CodeIdTokenToken
    ];

    public static readonly Dictionary<string, string> AllowedGrantTypeForResponseType = new()
    {
        { OpenIdConstants.ResponseTypes.Code, GrantTypes.AuthorizationCode },
        { OpenIdConstants.ResponseTypes.CodeIdToken, GrantTypes.Hybrid },
        { OpenIdConstants.ResponseTypes.CodeToken, GrantTypes.Hybrid },
        { OpenIdConstants.ResponseTypes.CodeIdTokenToken, GrantTypes.Hybrid }
    };

    public static readonly Dictionary<string, IEnumerable<string>> AllowedResponseModesForGrantType = new()
    {
        {
            GrantTypes.AuthorizationCode,
            new[]
            {
                OpenIdConstants.ResponseModes.Query, OpenIdConstants.ResponseModes.FormPost,
                OpenIdConstants.ResponseModes.Fragment
            }
        },
        { GrantTypes.Hybrid, new[] { OpenIdConstants.ResponseModes.Fragment, OpenIdConstants.ResponseModes.FormPost } },
    };

    public static readonly List<string> AllowedResponseModes =
    [
        OpenIdConstants.ResponseModes.FormPost,
        OpenIdConstants.ResponseModes.Query,
        OpenIdConstants.ResponseModes.Fragment
    ];

    public static readonly List<string> AllowedGrantTypesForAuthorizeEndpoint =
    [
        GrantTypes.AuthorizationCode,
        GrantTypes.Hybrid
    ];

    public static readonly List<string> AllowedPromptModes =
    [
        OpenIdConstants.PromptModes.None,
        OpenIdConstants.PromptModes.Login,
        OpenIdConstants.PromptModes.SelectAccount
    ];

    public enum ScopeRequirement
    {
        None,
        ResourceOnly,
        IdentityOnly,
        Identity
    }

    public static readonly Dictionary<string, ScopeRequirement> ResponseTypeToScope = new()
    {
        { OpenIdConstants.ResponseTypes.Code, ScopeRequirement.None },
        { OpenIdConstants.ResponseTypes.Token, ScopeRequirement.ResourceOnly },
        { OpenIdConstants.ResponseTypes.IdToken, ScopeRequirement.IdentityOnly },
        { OpenIdConstants.ResponseTypes.IdTokenToken, ScopeRequirement.Identity },
        { OpenIdConstants.ResponseTypes.CodeIdToken, ScopeRequirement.Identity },
        { OpenIdConstants.ResponseTypes.CodeToken, ScopeRequirement.Identity },
        { OpenIdConstants.ResponseTypes.CodeIdTokenToken, ScopeRequirement.Identity }
    };

    public class AccessTokenFilters
    {
        // filter for claims from an incoming access token (e.g. used at the user profile endpoint)
        public static readonly string[] ClaimsFilter =
        [
            OpenIdConstants.ClaimTypes.AccessTokenHash,
            OpenIdConstants.ClaimTypes.Audience,
            OpenIdConstants.ClaimTypes.AuthorizedParty,
            OpenIdConstants.ClaimTypes.AuthorizationCodeHash,
            OpenIdConstants.ClaimTypes.ClientId,
            OpenIdConstants.ClaimTypes.Expiration,
            OpenIdConstants.ClaimTypes.IssuedAt,
            OpenIdConstants.ClaimTypes.Issuer,
            OpenIdConstants.ClaimTypes.JwtId,
            OpenIdConstants.ClaimTypes.Nonce,
            OpenIdConstants.ClaimTypes.NotBefore,
            OpenIdConstants.ClaimTypes.ReferenceTokenId,
            OpenIdConstants.ClaimTypes.SessionId,
            OpenIdConstants.ClaimTypes.Scope
        ];
    }

    public static class CurveOid
    {
        public const string P256 = "1.2.840.10045.3.1.7";
        public const string P384 = "1.3.132.0.34";
        public const string P521 = "1.3.132.0.35";
    }

    public static readonly Dictionary<string, string> StandardClaims = new()
    {
        { "username", System.Security.Claims.ClaimTypes.Name },
        { "family_name", System.Security.Claims.ClaimTypes.Surname },
        { "given_name", System.Security.Claims.ClaimTypes.GivenName },
        { "gender", System.Security.Claims.ClaimTypes.Gender },
        { "pincode", System.Security.Claims.ClaimTypes.PostalCode },
        { "dateofbirth", System.Security.Claims.ClaimTypes.DateOfBirth },
        { "email", System.Security.Claims.ClaimTypes.Email },
        { "street ", System.Security.Claims.ClaimTypes.StreetAddress },
    };

}