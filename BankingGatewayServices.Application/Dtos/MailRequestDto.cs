using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BankingGatewayServices.Application.Dtos
{
    public class MailRequestDto
    {
        [Required]
        public string ToEmail { get; set; } = string.Empty;     
        [Required]
        public string Subject { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty ;
        public IList<IFormFile> Attachments { get; set; } = new List<IFormFile>();
    }
}
