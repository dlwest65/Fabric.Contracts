namespace Fabric.Contracts;

public interface IWeaveService
{
    Task<IEnumerable<Dictionary<string, object?>>> GetRowsAsync(
        TenantContext tenant, string database, string tableName);

    Task<Dictionary<string, object?>?> GetRowByIdAsync(
        TenantContext tenant, string database, string tableName, object id);

    Task<UpdateResult> UpdateRowsAsync(
        TenantContext tenant, string database, string tableName,
        IEnumerable<Dictionary<string, object?>> rows);
}
