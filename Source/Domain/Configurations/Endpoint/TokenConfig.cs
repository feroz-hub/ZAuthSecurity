namespace Domain.Configurations.Endpoint
{
    /// <summary>
    /// Configuration settings related to tokens.
    /// </summary>
    public class TokenConfig
    {
        /// <summary>
        /// Gets or sets the issuer URI for tokens.
        /// </summary>
        public string IssuerUri { get; set; }

        /// <summary>
        /// Gets or sets the caching lifetime for tokens in seconds.
        /// </summary>
        public int CachingLifeTime { get; set; } = 3600;

        /// <summary>
        /// Gets or sets a value indicating whether to show the key set for tokens.
        /// </summary>
        public bool ShowKeySet { get; set; } = true;

        /// <summary>
        /// Gets or sets the token expiration time in minutes.
        /// </summary>
        public int TokenExpiration { get; set; } = 60;

        /// <summary>
        /// Gets or sets the length of the client secret for tokens.
        /// </summary>
        public int ClientSecretLength { get; set; } = 256;

        /// <summary>
        /// Gets or sets the expiration time for client secrets in days.
        /// </summary>
        public int ClientSecretExpirationInDays { get; set; } = 60;
    }

    /// <summary>
    /// Configuration settings related to various endpoints in the system.
    /// </summary>
    public class EndpointsConfig
    {
        // Properties indicating whether specific endpoints are enabled
        // or specific features related to endpoints are supported.

        /// <summary>
        /// Gets or sets a value indicating whether the authorize endpoint is enabled.
        /// </summary>
        public bool EnableAuthorizeEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the JSON Web Key (JWK) endpoint is enabled.
        /// </summary>
        public bool EnableJwkEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the token endpoint is enabled.
        /// </summary>
        public bool EnableTokenEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the user information (userinfo) endpoint is enabled.
        /// </summary>
        public bool EnableUserInfoEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the discovery endpoint is enabled.
        /// </summary>
        public bool EnableDiscoveryEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the end session endpoint is enabled.
        /// </summary>
        public bool EnableEndSessionEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the token revocation endpoint is enabled.
        /// </summary>
        public bool EnableTokenRevocationEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the introspection endpoint is enabled.
        /// </summary>
        public bool EnableIntrospectionEndpoint { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether front-channel logout is supported.
        /// </summary>
        public bool FrontChannelLogoutSupported { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether front-channel logout session is required.
        /// </summary>
        public bool FrontChannelLogoutSessionRequired { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether back-channel logout is supported.
        /// </summary>
        public bool BackChannelLogoutSupported { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether back-channel logout session is required.
        /// </summary>
        public bool BackChannelLogoutSessionRequired { get; set; } = false;
    }

    /// <summary>
    /// Configuration settings related to token expiration times.
    /// </summary>
    public class TokenExpiration
    {
        // Properties specifying the minimum and maximum expiration times for different types of tokens.

        /// <summary>
        /// Gets or sets the minimum expiration time for access tokens in seconds.
        /// </summary>
        public int MinAccessTokenExpiration { get; set; } = 1800;

        /// <summary>
        /// Gets or sets the maximum expiration time for access tokens in seconds.
        /// </summary>
        public int MaxAccessTokenExpiration { get; set; } = 86400;

        /// <summary>
        /// Gets or sets the minimum expiration time for identity tokens in seconds.
        /// </summary>
        public int MinIdentityTokenExpiration { get; set; } = 1800;

        /// <summary>
        /// Gets or sets the maximum expiration time for identity tokens in seconds.
        /// </summary>
        public int MaxIdentityTokenExpiration { get; set; } = 86400;

        /// <summary>
        /// Gets or sets the minimum expiration time for refresh tokens in seconds.
        /// </summary>
        public int MinRefreshTokenExpiration { get; set; } = 1800;

        /// <summary>
        /// Gets or sets the maximum expiration time for refresh tokens in seconds.
        /// </summary>
        public int MaxRefreshTokenExpiration { get; set; } = 86400;

        /// <summary>
        /// Gets or sets the minimum expiration time for authorization codes in seconds.
        /// </summary>
        public int MinAuthorizationCodeExpiration { get; set; } = 1800;

        /// <summary>
        /// Gets or sets the maximum expiration time for authorization codes in seconds.
        /// </summary>
        public int MaxAuthorizationCodeExpiration { get; set; } = 86400;

        /// <summary>
        /// Gets or sets the minimum expiration time for logout tokens in seconds.
        /// </summary>
        public int MinLogoutTokenExpiration { get; set; } = 1800;

        /// <summary>
        /// Gets or sets the maximum expiration time for logout tokens in seconds.
        /// </summary>
        public int MaxLogoutTokenExpiration { get; set; } = 86400;
    }


}