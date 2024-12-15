namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents the login credentials for a client, including username, password hash, security settings, and login history.
    /// </summary>
    public class LoginCredential
    {
        public Guid CredentialID { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime PasswordExpiryDate { get; set; }
        public string SecurityQuestion { get; set; } = string.Empty;
        public string SecurityAnswer { get; set; } = string.Empty;
        public int FailedLoginAttempts { get; set; } = 0;
        public string? TwoFactorSecretKey { get; set; } = string.Empty;
        public bool IsTwoFactorEnabled { get; set; } = false;
        public string RecoveryEmail { get; set; } = string.Empty;
        public string RecoveryPhone { get; set; } = string.Empty;
        public string LoginIP { get; set; } = string.Empty;



        // Foreign key for Clientes
        public string CientID { get; set; } = string.Empty;

        // Navigation property
        public Clientes Clientes { get; set; } = null!;
    }
}
