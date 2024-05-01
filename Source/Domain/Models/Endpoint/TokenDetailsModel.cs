using Domain.Models.Api;
using Domain.Models.Api.Response;

namespace Domain.Models.Endpoint;


    /// <summary>
    /// Domain model representing the Token details used for token generation.
    /// </summary>
    public class TokenDetailsModel
    {
        /// <summary>
        /// Gets or sets a value indicating the user model.
        /// </summary>
        public virtual UserModel User { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the Client model.
        /// </summary>
        public virtual ClientsModel Client { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the list of identity resources for token generation.
        /// </summary>
        public virtual IList<IdentityResourcesModel> IdentityResources { get; set; } = new List<IdentityResourcesModel>();

        /// <summary>
        /// Gets or sets a value indicating the list of Api resources for token generation.
        /// </summary>
        public virtual IList<ApiResourcesModel> ApiResources { get; set; } = new List<ApiResourcesModel>();

        /// <summary>
        /// Gets or sets a value indicating the list of Api scopes for token generation.
        /// </summary>
        public virtual IList<ApiScopesModel> ApiScopes { get; set; } = new List<ApiScopesModel>();

        /// <summary>
        /// Gets or sets a value indicating the list of Identity Resources By Scopes for token generation.
        /// </summary>
        public virtual IList<IdentityResourcesByScopesModel> IdentityResourcesByScopes { get; set; } = new List<IdentityResourcesByScopesModel>();

        /// <summary>
        /// Gets or sets a value indicating the list of Api Resources By Scopes for token generation.
        /// </summary>
        public virtual IList<ApiResourcesByScopesModel> ApiResourcesByScopes { get; set; } = new List<ApiResourcesByScopesModel>();

        /// <summary>
        /// Gets or sets a value indicating the list of user role claim types.
        /// </summary>
        public virtual IList<UserRoleClaimTypesModel> UserRoleClaimTypes { get; set; } = new List<UserRoleClaimTypesModel>();

        /// <summary>
        /// Gets or sets a value indicating the list of user roles for token generation.
        /// </summary>
        public virtual IList<string> UserRoles { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets a value indicating the list of role permissions for token generation.
        /// </summary>
        public virtual IList<UserRoleClaimsModel> RolePermissions { get; set; } = new List<UserRoleClaimsModel>();
    }