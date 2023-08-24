namespace Module4_Exercise1.ReqresApiExample.Models;

internal sealed class CreateUserParametersRequest
{
    public string Name { get; set; }

    public string Job { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }
}
