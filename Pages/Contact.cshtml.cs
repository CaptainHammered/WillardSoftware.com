using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace WillardSoftware.Pages;

public class ContactModel : PageModel
{
    private readonly ILogger<ContactModel> _logger;

    public ContactModel(ILogger<ContactModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    [BindProperty]
    public ContactFormModel Contact { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        // create and send the mail here
        var mailbody = $@"Hi Willard,

        Someone is trying to reach you from your website!

        Name: {Contact.Name}
        LastName: {Contact.LastName}
        Email: {Contact.Email}
        Message: ""{Contact.Message}""
        ";

        SendMail(mailbody);
        

        return RedirectToPage("Index");
    }
    private void SendMail(string mailbody)
    {
        using (var message = new MailMessage(Contact.Email, "willard@willardsoftware.com"))
        {
            message.To.Add(new MailAddress("willard@willardsoftware.com"));
            message.From = new MailAddress(Contact.Email);
            message.Subject = "New E-Mail from my website";
            message.Body = mailbody;        
            
            using (var smtpClient = new SmtpClient("mail.willardsoftware.com"))
            {
                smtpClient.Send(message);
            }
        }

    }
}

public class ContactFormModel
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
