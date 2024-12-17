using BankingGatewayServices.Application.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankingGatewayServices.API.Controllers
{

    public class EmailsController : BaseController
    {
        private readonly IEmailServices _emailServices;

        public EmailsController(IEmailServices emailServices)
        {
            _emailServices = emailServices;
        }


        //[HttpPost]
        //public async Task<ActionResult> SendEmail(string receptor, string subject, string body)
        //{
        //    await _emailServices.SendEmail(receptor, subject, body);
        //    return Ok();


        //}

        /// <summary>
        /// Sends an email to the specified receptor.
        /// </summary>
        /// <param name="receptor">The recipient's email address.</param>
        /// <param name="subject">The subject of the email.</param>
        /// <param name="body">The body content of the email.</param>
        /// <returns>An HTTP response indicating the result of the operation.</returns>
        
        [HttpPost("send")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> SendEmail(string receptor, string subject, string body)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(receptor) || string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(body))
            {
                return BadRequest("All fields (receptor, subject, and body) are required.");
            }
            if (!IsValidEmail(receptor))
            {
                return BadRequest("The receptor email address is not valid.");
            }
            try
            {
                await _emailServices.SendEmail(receptor, subject, body);
                return Ok("Email sent successfully.");
            }
            catch (Exception ex)
            {
                // Log the exception (optional, if you decide to add logging later)
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error sending email: {ex.Message}");
            }
        }
        private static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
