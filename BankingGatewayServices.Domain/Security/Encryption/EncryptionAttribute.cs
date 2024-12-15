namespace BankingGatewayServices.Domain.Security.Encryption
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class EncryptionAttribute : Attribute
    {
        public EncryptionAttribute() { }
    }
}
