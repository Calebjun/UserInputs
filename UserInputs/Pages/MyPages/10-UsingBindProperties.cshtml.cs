using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

// [BindProperties] applies model binding to eligible public properties.
// Use this only as a comparison example: explicit [BindProperty]
// is usually easier to understand and control.
[BindProperties]
public class UsingBindPropertiesModel : PageModel
{
    public string? StudentName { get; set; }

    public string? StudentId { get; set; }

    public void OnPost()
    {
        // Razor Pages binds matching form field names to these properties.
        ViewData["stdData"] =
            $"Student Name = {StudentName}, Student Number = {StudentId}";
    }
}