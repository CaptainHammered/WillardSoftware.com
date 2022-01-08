using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using Microsoft.Extensions.Configuration;

namespace WillardSoftware.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ILogger<ContactModel> _logger;
        
        #nullable enable
        public ContactModel(ILogger<ContactModel> logger)
        {
            _logger = logger;
        }
        #nullable disable
        public void OnGet()
        {
        }

        

        [BindProperty]
        public ContactForm Contact { get; set; }

        



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