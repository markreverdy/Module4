using System;

namespace Module4_Exercise1.ReqresApiExample.Models;

internal sealed class UserCreatedResponse
{
    public string Name { get; set; }

    public string Job { get; set; }
    public string Token { get; set; }

    public int? Id { get; set; }

    public DateTime? CreatedAt { get; set; }
}
