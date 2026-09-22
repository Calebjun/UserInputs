using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class DisplayMultipleModel : PageModel
{
    // These properties provide values to DisplayMultiple.cshtml.
    public string? StudentName { get; private set; }

    public string? StudentId { get; private set; }

    public void OnGet()
    {
        // Read query-string values by their parameter names.
        StudentName = Request.Query["studentName"];
        StudentId = Request.Query["studentId"];

        // Client-provided values must not be trusted for security decisions.
        // For example, use the authenticated user's identity and server-side
        // authorization before displaying protected student information.
    }
}