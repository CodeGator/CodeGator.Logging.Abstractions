
namespace CodeGator.Logging.Attributes;

/// <summary>
/// This class marks fields or properties whose logged values should be obfuscated.
/// </summary>
/// <remarks>
/// Apply this attribute to personally identifiable or otherwise sensitive members that may
/// appear in logs only in a masked or truncated form, not as raw text.
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class ObfuscateForLoggingAttribute : DataClassificationAttribute
{

    /// <summary>
    /// This constructor initializes a new instance of the ObfuscateForLoggingAttribute class.
    /// </summary>
    public ObfuscateForLoggingAttribute()
        : base(DataTaxonomy.ObfuscatedData)
    {

    }
}
