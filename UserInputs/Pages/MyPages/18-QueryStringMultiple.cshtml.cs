using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class QueryStringMultipleModel : PageModel
{
    public void OnGet()
    {
    }

    public IActionResult OnPost(string? studentName, string? studentId)
    {
        // Handler parameters are populated through model binding.

        // RedirectToPage safely creates a query string from route values.
        // This is better than manually concatenating user input into a URL.
        //
        // Example destination:
        // ./DisplayMultiple?studentName=Alex&studentId=123456
        return RedirectToPage("./DisplayMultiple",
            new { studentName, studentId });
    }
}