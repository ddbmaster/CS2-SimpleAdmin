namespace CS2_SimpleAdmin.Models;

public record IpHistoryRow
{
    public long Steamid { get; init; }
    public string? Name { get; init; }

    /// <summary>
    /// Raw value of the address column. Read as Int64 because SQLite may hold
    /// IPv4 addresses >= 128.0.0.0 as negative numbers (stored via signed binding).
    /// </summary>
    public long Address { get; init; }

    /// <summary>
    /// IPv4 address as unsigned 32-bit integer (network order), independent of how the database stored it.
    /// </summary>
    public uint AddressUint => unchecked((uint)Address);

    public DateTime Used_at { get; init; }
}
