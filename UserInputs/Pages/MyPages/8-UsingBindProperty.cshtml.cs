using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class UsingBindPropertyModel : PageModel
{
    // [BindProperty] copies the matching submitted field value
    // into this property during the POST request.
    [BindProperty]
    public string? StudentName { get; set; }

    [BindProperty]
    public string? StudentId { get; set; }

    public void OnPost()
    {
        // Model binding has populated these properties before OnPost runs.
        ViewData["stdData"] =
            $"Student Name = {StudentName}, Student Number = {StudentId}";
    }
}