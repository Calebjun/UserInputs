using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class QueryStringDemoModel : PageModel
{
    public void OnGet()
    {
    }

    // IActionResult allows this handler to return a redirect response.
    public IActionResult OnPost(string? studentName)
    {
        // Model binding obtains studentName from the submitted form.

        // RedirectToPage safely creates the destination URL.
        // The anonymous object's property becomes a query-string value.
        //
        // Example destination:
        // ./DisplayInfo?studentName=Alex
        return RedirectToPage("./DisplayInfo", new { studentName });
    }
}