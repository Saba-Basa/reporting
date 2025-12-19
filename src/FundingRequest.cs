namespace ReportingChallenge.src;

public record FundingRequest(
    int Id,
    decimal Amount,
    string Status,
    DateTime SubmissionDate
);
