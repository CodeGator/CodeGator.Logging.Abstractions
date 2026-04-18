
using System.Reflection;
using CodeGator.Logging.Attributes;

namespace CodeGator.Logging.Abstractions.UnitTests;

[TestClass]
public sealed class LoggingAttributesTests
{
    [TestMethod]
    public void HashForLoggingAttribute_reports_hashed_taxonomy_classification()
    {
        var attr = new HashForLoggingAttribute();
        Assert.AreEqual(DataTaxonomy.HashedData, attr.Classification);
    }

    [TestMethod]
    public void RedactForLoggingAttribute_reports_redacted_taxonomy_classification()
    {
        var attr = new RedactForLoggingAttribute();
        Assert.AreEqual(DataTaxonomy.RedactedData, attr.Classification);
    }

    [TestMethod]
    public void ObfuscateForLoggingAttribute_reports_obfuscated_taxonomy_classification()
    {
        var attr = new ObfuscateForLoggingAttribute();
        Assert.AreEqual(DataTaxonomy.ObfuscatedData, attr.Classification);
    }

    [TestMethod]
    public void Logging_attributes_target_fields_and_properties_only()
    {
        foreach (var type in new[]
                 {
                     typeof(HashForLoggingAttribute),
                     typeof(RedactForLoggingAttribute),
                     typeof(ObfuscateForLoggingAttribute),
                 })
        {
            var usage = type.GetCustomAttribute<AttributeUsageAttribute>();
            Assert.IsNotNull(usage);
            var expected = AttributeTargets.Field | AttributeTargets.Property;
            Assert.AreEqual(expected, usage!.ValidOn);
        }
    }
}
