
namespace CodeGator.Logging.Attributes;

/// <summary>
/// This class marks fields or properties whose logged values should be erased.
/// </summary>
/// <remarks>
/// Apply this attribute to sensitive members that must not appear in logs at all; compliant
/// serializers should remove or replace the value entirely when writing log entries.
/// </remarks>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
public class RedactForLoggingAttribute : DataClassificationAttribute
{

    /// <summary>
    /// This constructor initializes a new instance of the RedactForLoggingAttribute class.
    /// </summary>
    public RedactForLoggingAttribute()
        : base(DataTaxonomy.RedactedData)
    {

    }
}
