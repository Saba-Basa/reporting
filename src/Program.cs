using ReportingChallenge;
using ReportingChallenge.src;

namespace ReportingChallenge.App;

public class Program
{
    public static void Main(string[] args)
    {
        var requests = new List<FundingRequest>
        {
            new(1, 25_000m, "Approved", DateTime.Now.AddDays(-10)),
            new(2, 75_000m, "Approved", DateTime.Now.AddDays(-5)),   // should trigger warning
            new(3, 12_000m, "Review",   DateTime.Now),
            new(4, 0m,      "Rejected", DateTime.Now.AddDays(-20)),
            new(5, 60_000m, "Approved", DateTime.Now.AddDays(-1))    // should trigger warning
        };

        var reporter = new FundingCenterReporter();

        // In your practice branches, implement GenerateReport to call the
        // helper methods and print a nicely formatted console report.
        reporter.GenerateReport(requests);

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
