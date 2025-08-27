
using System;
using Microsoft.AspNetCore.Mvc;
using MyEmailApiService.Models;
using Azure;
using Azure.Communication.Email;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace MyEmailApiService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private IConfiguration _configuration;

        public EmailController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ContactRequest request)
        {
            Console.WriteLine($@"
            New Contact Request:
            Name: {request.Name}
            Email: {request.EmailAddress}
            Phone: {request.PhoneNumber}
            Subject: {request.Subject}
            Message: {request.Message}
            ");

            // TODO: Call Azure ACS Email Send here.
            string connectionString = _configuration["AzureCommunication:EmailConnectionString"];
            var emailClient = new EmailClient(connectionString);


            var emailMessage = new EmailMessage(
                senderAddress: "DoNotReply@redshoestechnology.com",
                content: new EmailContent("Test Email")
                {
                    PlainText = "Hello world via email.",
                    Html = @"
		                <html>
			                <body>
				                <h1>New RedShoesTechnology.com email:</h1><br>
                                <p><strong>Name:</strong> " + request.Name + @"</p>
                                <p><strong>Email:</strong> " + request.EmailAddress + @"</p>
                                <p><strong>Phone:</strong> " + request.PhoneNumber + @"</p>
                                <p><strong>Subject:</strong> " + request.Subject + @"</p>
                                <p><strong>Message:</strong> " + request.Message + @"</p>


			                </body>
		                </html>"
                },
                recipients: new EmailRecipients(new List<EmailAddress> { new EmailAddress("info@lydiabrown.com.au") }));


            EmailSendOperation emailSendOperation = emailClient.Send(
                WaitUntil.Completed,
                emailMessage);

            Console.WriteLine("Email successfully sent");

            return Ok(new
            {
                Message = "Email sent successfully",
                OperationId = emailSendOperation.Id,
                Status = "Email Sent."
            });

        }
    }
}
