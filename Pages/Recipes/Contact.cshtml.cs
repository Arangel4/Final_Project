using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final_Project.Models;

namespace Final_Project.Pages.Recipes
{
    public class ContactModel : PageModel
    {
        private readonly ILogger _log;

        [BindProperty]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName {get; set;}

        [BindProperty]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName {get; set;}

        [BindProperty]
        [Required(ErrorMessage = "The E-Mail field is not a valid e-mail address.")]
        [Display(Name = "E-Mail")]
        [EmailAddress]
        public string Email {get; set;}

        [BindProperty]
        [Display(Name = "Message")]
        public string Message {get; set;}

        public ContactModel(ILogger<ContactModel> log)
        {
            _log = log;
        }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            _log.LogWarning($"{FirstName} {LastName} {Email} {Message}");
        }
    }
}