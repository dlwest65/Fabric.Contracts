namespace Fabric.Contracts;

public class TenantContext
{
    public required string ClientId { get; set; }
    public required string[] AllowedDatabases { get; set; }
}
