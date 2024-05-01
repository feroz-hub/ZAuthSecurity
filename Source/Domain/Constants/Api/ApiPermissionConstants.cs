namespace Domain.Constants.Api;

/// <summary>
/// Constants related to API permissions.
/// </summary>
public static class ApiPermissionConstants
{
    // Base name for all permissions
    private const string BaseName = "sf.";

    // Permissions for anonymous users
    public const string Anonymous = BaseName + "anonymous";

    // Permissions for API resource operations
    
    /// <summary>
    /// Permission to read API resources.
    /// </summary>
    public const string ApiResourceRead = BaseName + "apiresource.read";

    /// <summary>
    /// Permission to write (create or update) API resources.
    /// </summary>
    public const string ApiResourceWrite = BaseName + "apiresource.write";

    /// <summary>
    /// Permission to delete API resources.
    /// </summary>
    public const string ApiResourceDelete = BaseName + "apiresource.delete";

    /// <summary>
    /// Permission to manage (perform all CRUD operations) API resources.
    /// </summary>
    public const string ApiResourceManage = BaseName + "apiresource.manage";


    // Permissions for user operations
   
    ///<summary>
    /// Permission to read user data.
    ///</summary>
    public const string UserRead = BaseName + "user.read";

    ///<summary>
    /// Permission to write (create or update) user data.
    ///</summary>
    public const string UserWrite = BaseName + "user.write";

    ///<summary>
    /// Permission to delete user data.
    ///</summary>
    public const string UserDelete = BaseName + "user.delete";

    ///<summary>
    /// Permission to manage (perform all CRUD operations) user data.
    ///</summary>
    public const string UserManage = BaseName + "user.manage";

    // Permissions for IdentityResource operations
    
    ///<summary>
    /// Permission to read identity resources.
    ///</summary>
    public const string IdentityResourceRead = BaseName + "identityresource.read";

    ///<summary>
    /// Permission to write (create or update) identity resources.
    ///</summary>
    public const string IdentityResourceWrite = BaseName + "identityresource.write";

    ///<summary>
    /// Permission to delete identity resources.
    ///</summary>
    public const string IdentityResourceDelete = BaseName + "identityresource.delete";

    ///<summary>
    /// Permission to manage (perform all CRUD operations) identity resources.
    ///</summary>
    public const string IdentityResourceManage = BaseName + "identityresource.manage";
   
    // Permissions for Role operations
    
    ///<summary>
    /// Permission to read roles.
    ///</summary>
    public const string RoleRead = BaseName + "role.read";

    ///<summary>
    /// Permission to write (create or update) roles.
    ///</summary>
    public const string RoleWrite = BaseName + "role.write";

    ///<summary>
    /// Permission to delete roles.
    ///</summary>
    public const string RoleDelete = BaseName + "role.delete";

    ///<summary>
    /// Permission to manage (perform all CRUD operations) roles.
    ///</summary>
    public const string RoleManage = BaseName + "role.manage";
    
    // Permissions for Admin operations
    
    ///<summary>
    /// Permission to read admin users.
    ///</summary>
    public const string AdminRead = BaseName + "adminuser.read";

    ///<summary>
    /// Permission to write (create or update) admin users.
    ///</summary>
    public const string AdminWrite = BaseName + "adminuser.write";

    ///<summary>
    /// Permission to delete admin users.
    ///</summary>
    public const string AdminDelete = BaseName + "adminuser.delete";

    ///<summary>
    /// Permission to manage (perform all CRUD operations) admin users.
    ///</summary>
    public const string AdminManage = BaseName + "adminuser.manage";
    
    // Permissions for Audit operations
    
    ///<summary>
    /// Permission to read audit trails.
    ///</summary>
    public const string AuditRead = BaseName + "audittrail.read";

    ///<summary>
    /// Permission to manage (perform all CRUD operations) audit trails.
    ///</summary>
    public const string AuditManage = BaseName + "audittrail.manage";

    
    // Permissions for Client operations
   
    ///<summary>
    /// Permission to read clients.
    ///</summary>
    public const string ClientRead = BaseName + "client.read";

    ///<summary>
    /// Permission to write (create or update) clients.
    ///</summary>
    public const string ClientWrite = BaseName + "client.write";

    ///<summary>
    /// Permission to delete clients.
    ///</summary>
    public const string ClientDelete = BaseName + "client.delete";

    ///<summary>
    /// Permission to manage (perform all CRUD operations) clients.
    ///</summary>
    public const string ClientManage = BaseName + "client.manage";
    
    // Permissions for SecurityToken operations
    
    ///<summary>
    /// Permission to manage (perform all CRUD operations) security tokens.
    ///</summary>
    public const string SecurityTokenManage = BaseName + "securitytoken.manage";

    ///<summary>
    /// Permission to read security tokens.
    ///</summary>
    public const string SecurityTokenRead = BaseName + "securitytoken.read";

    
    

    
}