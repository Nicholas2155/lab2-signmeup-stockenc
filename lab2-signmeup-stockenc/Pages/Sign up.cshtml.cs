using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;            //Used AI to show me meta data attributes to ensure email is valid and to make field a required section
using System.ComponentModel.DataAnnotations;

namespace lab2_signmeup_stockenc.Pages
{
    public class Sign_upModel : PageModel
    {
        [BindProperty]
        public SignupForm SignupData { get; set; }
        public string ConfirmationMessage { get; set; }
        public void OnGet()
        {
            SignupData = new SignupForm();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ConfirmationMessage = $"Thanks for signing up, {SignupData.Name}! We’ll see you at the bonfire!";
            return Page();
        }
    }
    public class SignupForm
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Year { get; set; }

        public string Major { get; set; }

        [Required]
        public string RSVP { get; set; }

        public string TshirtSize { get; set; }
    }
} 
