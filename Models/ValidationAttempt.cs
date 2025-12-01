namespace PasswordValidatorApi.Models;

public class ValidationAttempt
{
    public int Id { get; set; }
    public string PasswordHash { get; set; } = string.Empty;
    public bool IsValid { get; set; }
    public string ValidationErrors { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
