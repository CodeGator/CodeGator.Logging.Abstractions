using Microsoft.Extensions.Compliance.Classification;

namespace CodeGator.Logging.Abstractions.UnitTests;

[TestClass]
public sealed class DataTaxonomyTests
{
    [TestMethod]
    public void TaxonomyName_matches_full_name_of_DataTaxonomy_type()
    {
        Assert.AreEqual(typeof(DataTaxonomy).FullName, DataTaxonomy.TaxonomyName);
    }

    [TestMethod]
    public void RedactedData_uses_taxonomy_name_and_expected_value_label()
    {
        var c = DataTaxonomy.RedactedData;
        Assert.AreEqual(DataTaxonomy.TaxonomyName, c.TaxonomyName);
        Assert.AreEqual(nameof(DataClassification), c.Value);
    }

    [TestMethod]
    public void ObfuscatedData_uses_taxonomy_name_and_expected_value_label()
    {
        var c = DataTaxonomy.ObfuscatedData;
        Assert.AreEqual(DataTaxonomy.TaxonomyName, c.TaxonomyName);
        Assert.AreEqual(nameof(DataTaxonomy.ObfuscatedData), c.Value);
    }

    [TestMethod]
    public void HashedData_uses_taxonomy_name_and_expected_value_label()
    {
        var c = DataTaxonomy.HashedData;
        Assert.AreEqual(DataTaxonomy.TaxonomyName, c.TaxonomyName);
        Assert.AreEqual(nameof(DataTaxonomy.HashedData), c.Value);
    }

    [TestMethod]
    public void All_taxonomy_classifications_share_the_same_taxonomy_name()
    {
        var taxonomy = DataTaxonomy.TaxonomyName;
        Assert.AreEqual(taxonomy, DataTaxonomy.RedactedData.TaxonomyName);
        Assert.AreEqual(taxonomy, DataTaxonomy.ObfuscatedData.TaxonomyName);
        Assert.AreEqual(taxonomy, DataTaxonomy.HashedData.TaxonomyName);
    }

    [TestMethod]
    public void Taxonomy_classifications_are_distinct_value_labels()
    {
        var redacted = DataTaxonomy.RedactedData;
        var obfuscated = DataTaxonomy.ObfuscatedData;
        var hashed = DataTaxonomy.HashedData;
        Assert.AreNotEqual(redacted, obfuscated);
        Assert.AreNotEqual(redacted, hashed);
        Assert.AreNotEqual(obfuscated, hashed);
    }
}
