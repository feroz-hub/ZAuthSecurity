using System.Collections.Generic;

namespace Domain.Constants
{
    /// <summary>
    /// Constants related to API proxies.
    /// </summary>
    public class ProxyConstants
    {
        /// <summary>
        /// List of APIs accessible anonymously.
        /// </summary>
        public static readonly List<string> AnonymousApis = 
        [
            "AddAuditTrailAsync",
            "RegisterUserAsync"
        ];

        /// <summary>
        /// List of secure APIs requiring authentication.
        /// </summary>
        public static readonly List<string> SecureApis = [];
    }
}