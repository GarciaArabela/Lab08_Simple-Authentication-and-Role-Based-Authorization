using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public sealed class RevokedToken
{
    [Key]
    public string Jti { get; set; } = default!;
    public DateTime ExpiresAtUtc { get; set; }
}