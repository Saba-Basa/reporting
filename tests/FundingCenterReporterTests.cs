using ReportingChallenge;
using ReportingChallenge.src;
using Xunit;

namespace ReportingChallenge.Tests;

public class FundingCenterReporterTests
{
    private static List<FundingRequest> CreateSampleData() =>
        new()
        {
            new(1, 25_000m, "Approved", DateTime.Today.AddDays(-10)),
            new(2, 75_000m, "Approved", DateTime.Today.AddDays(-5)),  // > 50k
            new(3, 12_000m, "Review",   DateTime.Today),
            new(4, 0m,      "Rejected", DateTime.Today.AddDays(-20)),
            new(5, 60_000m, "Approved", DateTime.Today.AddDays(-1))   // > 50k
        };

    [Fact]
    public void GroupByStatus_CreatesExpectedGroups()
    {
        // arrange
        var data = CreateSampleData();
        var reporter = new FundingCenterReporter();

        // act
        var grouped = reporter.GroupByStatus(data);

        // assert
        Assert.Equal(3, grouped.Count);  // Approved, Review, Rejected

        Assert.True(grouped.ContainsKey("Approved"));
        Assert.True(grouped.ContainsKey("Review"));
        Assert.True(grouped.ContainsKey("Rejected"));

        Assert.Equal(3, grouped["Approved"].Count);
        Assert.Single(grouped["Review"]);
        Assert.Single(grouped["Rejected"]);
    }

    [Fact]
    public void GetBudgetWarnings_FindsAllRequestsOverLimit()
    {
        // arrange
        var data = CreateSampleData();
        var reporter = new FundingCenterReporter();
        const decimal limit = 50_000m;

        // act
        var warnings = reporter.GetBudgetWarnings(data, limit).ToList();

        // assert
        Assert.Equal(2, warnings.Count);
        Assert.Contains(warnings, w => w.Contains("Id=2"));
        Assert.Contains(warnings, w => w.Contains("Id=5"));
    }
}
