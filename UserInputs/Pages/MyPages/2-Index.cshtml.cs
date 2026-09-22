using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class IndexModel : PageModel
{
    // This property holds a value that the Razor page can display.
    public string? StudentName { get; private set; }

    // OnGet runs when the user first requests this page with HTTP GET.
    public void OnGet()
    {
    }

    // OnPost runs when the form with method="post" is submitted.
    public void OnPost()
    {
        // "studentName" must match the HTML input name attribute.
        // This is manual, low-level access to submitted form data.
        StudentName = Request.Form["studentName"];
    }
}