namespace Domain.Models.Api;

/// <summary>
/// Model for storing and configuring page information.
/// </summary>
public class PagingModel
{
    /// <summary>
    /// Gets or sets total Items count.
    /// </summary>
    public int TotalItems { get; set; }

    /// <summary>
    /// Gets or sets Items Per Page.
    /// </summary>
    public int ItemsPerPage { get; set; }

    /// <summary>
    /// Gets or sets Current Page.
    /// </summary>
    public int CurrentPage { get; set; }

    /// <summary>
    /// Gets total Pages.
    /// <para>Total pages is a mathematically calculated.</para>
    /// <para>Total pages is the quotient of TotalItems and ItemsPerPage.</para>
    /// </summary>
    public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);

    /// <summary>
    /// Gets or sets total Display Pages.
    /// </summary>
    public int TotalDisplayPages { get; set; }
}