using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class DisplayInfoModel : PageModel
{
    // This property makes the received value available to the Razor page.
    public string? StudentName { get; private set; }

    public void OnGet()
    {
        // Read the non-sensitive value sent in the URL query string.
        StudentName = Request.Query["studentName"];

        // In a production application, validate input and retrieve
        // trusted information from a database when appropriate.
    }
}