using ReportingChallenge.src;

namespace ReportingChallenge;

public class FundingCenterReporter
{
    // TODO: Implement in your practice runs

    // Groups requests by status (e.g. "Approved", "Review", "Rejected")
    public Dictionary<string, List<FundingRequest>> GroupByStatus(
        IEnumerable<FundingRequest> requests)
    {
        throw new NotImplementedException("Implement in your attempt.");
    }

    // Returns warning messages for all requests with Amount > limit
    public IEnumerable<string> GetBudgetWarnings(
        IEnumerable<FundingRequest> requests,
        decimal limit)
    {
        throw new NotImplementedException("Implement in your attempt.");
    }

    // High level report (can call the two methods above)
    public void GenerateReport(IEnumerable<FundingRequest> requests)
    {
        // This method is not tested directly – it is for console output.
        // You can implement it in your practice branches.
        throw new NotImplementedException("Implement in your attempt.");
    }
}
