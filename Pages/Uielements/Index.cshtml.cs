using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Uielements;

public class UielementsModel : PageModel
{
    private readonly ILogger<UielementsModel> _logger;

    public UielementsModel(ILogger<UielementsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

}
