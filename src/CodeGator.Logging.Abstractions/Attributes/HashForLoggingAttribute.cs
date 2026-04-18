
namespace CodeGator.Logging.Attributes;

/// <summary>
/// This class marks fields or properties whose logged values should be hashed.
/// </summary>
/// <remarks>
/// Apply this attribute to members that must not appear in plain text in logs; compliant
/// serializers should emit a stable hash representation instead of the raw value.
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class HashForLoggingAttribute : DataClassificationAttribute
{

    /// <summary>
    /// This constructor initializes a new instance of the HashForLoggingAttribute class.
    /// </summary>
    public HashForLoggingAttribute()
        : base(DataTaxonomy.HashedData)
    {

    }
}
