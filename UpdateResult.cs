namespace Fabric.Contracts;

public class UpdateResult
{
    public List<UpdateRowResult> Results { get; set; } = new();
    public bool HasConflicts => Results.Any(r => r.Status == "conflict");
}

public class UpdateRowResult
{
    public string Id { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;  // "unchanged", "updated", "conflict", "error"
    public List<string>? ColumnsChanged { get; set; }
    public string? Message { get; set; }
}
