using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UserInputs.Pages.MyPages;

public class UsingBuiltInDataBindingModel : PageModel
{
    // Model binding matches form field names to handler parameter names.
    // No manual Request.Form lookup is required.
    public void OnPost(string? studentName, string? studentId)
    {
        // The values have already been assigned by Razor Pages model binding.
        ViewData["stdData"] =
            $"Student Name = {studentName}, Student Number = {studentId}";
    }
}