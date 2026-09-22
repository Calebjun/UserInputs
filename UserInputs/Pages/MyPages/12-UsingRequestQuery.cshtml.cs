using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class UsingRequestQueryModel : PageModel
{
    // OnGet runs when the page is requested using HTTP GET.
    // It runs both when the page first opens and after the GET form is submitted.
    public void OnGet()
    {
        // Request.Query reads values from the URL query string.
        // These keys must match the input name attributes in the Razor page.
        string? studentName = Request.Query["studentName"];
        string? studentId = Request.Query["studentId"];

        // ViewData passes a simple result from the PageModel to the Razor page.
        ViewData["stdData"] =
            $"Student Name = {studentName}, Student Number = {studentId}";

        // Teaching reminder:
        // Query-string values are visible in the URL, browser history,
        // bookmarks, and potentially server logs.
        // Never use them for passwords, grades, access tokens,
        // or other sensitive personal information.
    }
}