
namespace CodeGator.Logging;

/// <summary>
/// This class defines shared names and DataClassification values used when logging.
/// </summary>
/// <remarks>
/// Use these <see cref="DataClassification"/> values with attributes such as
/// <see cref="CodeGator.Logging.Attributes.HashForLoggingAttribute"/> so compliance-aware pipelines classify
/// log payloads consistently.
/// </remarks>
public static class DataTaxonomy
{

    /// <summary>
    /// This property exposes the taxonomy key derived from this type's full name.
    /// </summary>
    public static string TaxonomyName { get; }
        = typeof(DataTaxonomy).FullName!;

    /// <summary>
    /// This property labels values that must be fully redacted in log output.
    /// </summary>
    public static DataClassification RedactedData { get; }
        = new(TaxonomyName, nameof(DataClassification));

    /// <summary>
    /// This property labels values that should be obfuscated in log output.
    /// </summary>
    public static DataClassification ObfuscatedData { get; }
        = new(TaxonomyName, nameof(ObfuscatedData));

    /// <summary>
    /// This property labels values that should be hashed in log output.
    /// </summary>
    public static DataClassification HashedData { get; }
        = new(TaxonomyName, nameof(HashedData));
}
