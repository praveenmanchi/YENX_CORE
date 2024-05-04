using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Authentication;

public class AuthenticationModel : PageModel
{
    private readonly ILogger<AuthenticationModel> _logger;

    public AuthenticationModel(ILogger<AuthenticationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}
