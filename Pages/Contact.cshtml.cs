using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using MailKit.Net.Smtp;
using NETcore.MailKit.Core;

namespace WillardSoftware.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        private readonly IEmailService _emailService;
        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }



        [BindProperty]
        public ContactForm Contact { get; set; }

        public void Send(ContactForm Contact)
        {
            MimeMessage message = new MimeMessage();
        }

    }

    public class ContactForm
    {
    [Required]
    public string Name { get; set; } = default!;
    [Required]
    public string LastName { get; set; } = default!;
    [Required]
    public string Email { get; set; } = default!;
    [Required]
    public string Message { get; set; } = default!;
    }
}