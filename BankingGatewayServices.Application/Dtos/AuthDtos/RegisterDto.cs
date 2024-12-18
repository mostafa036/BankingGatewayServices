using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BankingGatewayServices.Application.Dtos.AuthDtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; } =string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string NationalID { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d@$!%*?&]{8,}$",
        ErrorMessage = "Password must be at least 8 characters long, include one uppercase letter, " +
        "one lowercase letter, one digit, and may contain special characters.")]
        public string Password { get; set; } = string.Empty;

        [Required]
        public int CountryId { get; set; }

        [Required]
        public int LanguageId { get; set; }
    }

}
