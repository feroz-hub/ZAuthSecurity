namespace Domain.Models.Endpoint;

/// <summary>
/// Domain Model representing Allowed Scopes Parser.
/// </summary>
public class AllowedScopesParserModel
{
    /// <summary>
    /// Gets or sets Parsed Identity Resources.
    /// </summary>
    public List<string> ParsedIdentityResources { get; set; }

    /// <summary>
    /// Gets or sets Parsed Api Resources.
    /// </summary>
    public List<string> ParsedApiResources { get; set; }

    /// <summary>
    /// Gets or sets Parsed Api Scopes.
    /// </summary>
    public List<string> ParsedApiScopes { get; set; }

    /// <summary>
    /// Gets or sets Parsed Transaction Scopes.
    /// </summary>
    public List<string> ParsedTransactionScopes { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether Offline Access is allowed.
    /// </summary>
    public bool AllowOfflineAccess { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether Identity Token can be created.
    /// </summary>
    public bool CreateIdentityToken { get; set; }

    /// <summary>
    /// Gets or sets Invalid Scopes.
    /// </summary>
    public List<string> InvalidScopes { get; set; }

    /// <summary>
    /// Gets or sets Token Details.
    /// </summary>
    public TokenDetailsModel TokenDetails { get; set; }

    /// <summary>
    /// Gets Allowed scopes parsed for Identity resources and apiscopes combined.
    /// </summary>
    /// <returns>Parsed Allowed Scopes as list of string.</returns>
    public List<string> ParsedAllowedScopes
    {
        get
        {
            var parsedAllowedScopes = new List<string>();
            if (ParsedIdentityResources != null)
            {
                parsedAllowedScopes.AddRange(ParsedIdentityResources);
            }

            if (ParsedApiScopes != null)
            {
                parsedAllowedScopes.AddRange(ParsedApiScopes);
            }

            // TODO Refactor this property into a method.
            return parsedAllowedScopes.Distinct().ToList();
        }
    }
}