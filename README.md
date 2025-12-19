# Reporting Challenge Template

Practice project for a small C#/.NET reporting task.

## Task

You receive a list of `FundingRequest` objects.

Implement in `FundingCenterReporter`:

1. `GroupByStatus(IEnumerable<FundingRequest>)`
   - Group all requests by `Status`
   - Return `Dictionary<string, List<FundingRequest>>`

2. `GetBudgetWarnings(IEnumerable<FundingRequest>, decimal limit)`
   - Find all requests where `Amount` is greater than `limit`
   - Return human-readable warning strings, e.g.
     - `"Request Id=2: Amount 75000 exceeds limit 50000"`

3. `GenerateReport(IEnumerable<FundingRequest>)`
   - Use the two methods above to print a short console report:
     - status overview (count + total per status)
     - budget warnings

Focus on:

- Clean Code (small methods, meaningful names)
- LINQ instead of manual loops where appropriate
- Clear handling of edge cases (empty list, unknown status)

## How to run

dotnet test
dotnet run

Use this repository as a **template** and create a new repo for each practice attempt.