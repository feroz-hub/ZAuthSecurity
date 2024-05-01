namespace Domain.Models.Endpoint.Response;

/// <summary>
/// Domain Model representing Json WebKey.
/// </summary>
public class JsonWebKeyResponseModel
{
    /// <summary>
    /// Gets or sets value indicating Kty. (Key type).
    /// </summary>
    public string Kty { get; set; }

    /// <summary>
    /// Gets or sets value indicating use.
    /// </summary>
    public string Use { get; set; }

    /// <summary>
    /// Gets or sets value indicating Kid.
    /// </summary>
    public string Kid { get; set; }

    /// <summary>
    /// Gets or sets value indicating X5t.
    /// </summary>
    public string X5t { get; set; }

    /// <summary>
    /// Gets or sets value indicating E.
    /// </summary>
    public string E { get; set; }

    /// <summary>
    /// Gets or sets value indicating N.
    /// </summary>
    public string N { get; set; }

    /// <summary>
    /// Gets or sets value indicating X5c.
    /// </summary>
    public IList<string> X5c { get; set; }

    /// <summary>
    /// Gets or sets value indicating Algorithm.
    /// </summary>
    public string Alg { get; set; }

    /// <summary>
    /// Gets or sets value indicating X.
    /// </summary>
    public string X { get; set; }

    /// <summary>
    /// Gets or sets value indicating Y.
    /// </summary>
    public string Y { get; set; }

    /// <summary>
    /// Gets or sets value indicating Crv.
    /// </summary>
    public string Crv { get; set; }
}