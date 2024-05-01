namespace Domain.Enums
{

    ///<summary>
    /// Enum representing the type of application.
    ///</summary>
    public enum ApplicationType
    {
        ///<summary>
        /// Regular web application.
        ///</summary>
        RegularWeb = 1,

        ///<summary>
        /// Single page application.
        ///</summary>
        SinglePageApp = 2,

        ///<summary>
        /// Native application.
        ///</summary>
        Native = 3,

        ///<summary>
        /// Service application.
        ///</summary>
        Service = 4
    }

    ///<summary>
    /// Enum representing the grant types used in OAuth 2.0 authorization flows.
    ///</summary>
    public enum GrantType
    {
        ///<summary>
        /// Authorization Code grant type.
        ///</summary>
        AuthorizationCode = 1,

        ///<summary>
        /// Password grant type.
        ///</summary>
        Password = 2,

        ///<summary>
        /// Client Credentials grant type.
        ///</summary>
        ClientCredentials = 3,

        ///<summary>
        /// Refresh Token grant type.
        ///</summary>
        RefreshToken = 4
    }

    ///<summary>
    /// Enum representing the type of access token used in authentication.
    ///</summary>
    public enum AccessTokenType
    {
        ///<summary>
        /// JSON Web Token (JWT) access token type.
        ///</summary>
        Jwt = 1
    }

    ///<summary>
    /// Enum representing the Content Security Policy (CSP) level.
    ///</summary>
    public enum CspLevel
    {
        ///<summary>
        /// Content Security Policy Level One (CSP 1).
        ///</summary>
        One = 0,

        ///<summary>
        /// Content Security Policy Level Two (CSP 2).
        ///</summary>
        Two = 1
    }

    ///<summary>
    /// Enum representing various signing algorithms used in token generation.
    ///</summary>
    public enum SigningAlgorithm
    {
        ///<summary>
        /// RSA using SHA-256 hash algorithm.
        ///</summary>
        RS256 = 1,

        ///<summary>
        /// RSA using SHA-384 hash algorithm.
        ///</summary>
        RS384 = 2,

        ///<summary>
        /// RSA using SHA-512 hash algorithm.
        ///</summary>
        RS512 = 3,

        ///<summary>
        /// HMAC using SHA-256 hash algorithm.
        ///</summary>
        HS256 = 4,

        ///<summary>
        /// HMAC using SHA-384 hash algorithm.
        ///</summary>
        HS384 = 5,

        ///<summary>
        /// HMAC using SHA-512 hash algorithm.
        ///</summary>
        HS512 = 6,

        ///<summary>
        /// Elliptic Curve Digital Signature Algorithm (ECDSA) using SHA-256 hash algorithm.
        ///</summary>
        ES256 = 7,

        ///<summary>
        /// Elliptic Curve Digital Signature Algorithm (ECDSA) using SHA-384 hash algorithm.
        ///</summary>
        ES384 = 8,

        ///<summary>
        /// Elliptic Curve Digital Signature Algorithm (ECDSA) using SHA-512 hash algorithm.
        ///</summary>
        ES512 = 9,

        ///<summary>
        /// RSASSA-PSS using SHA-256 hash algorithm.
        ///</summary>
        PS256 = 10,

        ///<summary>
        /// RSASSA-PSS using SHA-384 hash algorithm.
        ///</summary>
        PS384 = 11,

        ///<summary>
        /// RSASSA-PSS using SHA-512 hash algorithm.
        ///</summary>
        PS512 = 12
    }

    ///<summary>
    /// Enum representing different methods for parsing tokens during authentication.
    ///</summary>
    public enum ParseMethods
    {
        ///<summary>
        /// Basic parsing method.
        ///</summary>
        Basic = 0,

        ///<summary>
        /// Parsing method using POST request.
        ///</summary>
        Post = 1,

        ///<summary>
        /// Parsing method using JWT secret.
        ///</summary>
        JwtSecret = 2,

        ///<summary>
        /// Parsing method using private key JWT.
        ///</summary>
        PrivateKeyJwt = 3,

        ///<summary>
        /// No parsing method specified.
        ///</summary>
        None = 4
    }
}