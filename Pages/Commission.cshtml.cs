using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WillardSoftware.Pages;

public class CommissionModel : PageModel
{
    private readonly ILogger<CommissionModel> _logger;

    public CommissionModel(ILogger<CommissionModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

