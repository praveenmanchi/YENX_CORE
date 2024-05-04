using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ynex.Pages.Task;

public class TaskModel : PageModel
{
    private readonly ILogger<TaskModel> _logger;

    public TaskModel(ILogger<TaskModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    
}
