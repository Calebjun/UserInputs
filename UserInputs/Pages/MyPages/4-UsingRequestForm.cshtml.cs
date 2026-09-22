using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class UsingRequestFormModel : PageModel
{
    public void OnPost()
    {
        // Request.Form is a collection of values submitted in a POST request.
        // The keys must match the HTML input names exactly.
        string? studentName = Request.Form["studentName"];
        string? studentId = Request.Form["studentId"];

        // ViewData sends a simple result back to the Razor markup.
        // Later examples will use stronger typing instead.
        ViewData["stdData"] =
            $"Student Name = {studentName}, Student Number = {studentId}";
    }
}