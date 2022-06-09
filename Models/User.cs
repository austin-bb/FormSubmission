
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models;

public class User
{
    [Display(Name = "First Name")]
    [Required]
    [MinLength(4, ErrorMessage = "must be at least 4 characters")]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    [Required]
    [MinLength(4, ErrorMessage = "must be at least 4 characters")]
    public string LastName { get; set; } = null!;

    [Display(Name = "Age")]
    [Required]
    [Range(0, 1000, ErrorMessage = "cannot be a negative number")]
    public int Age { get; set; }

    [Display(Name = "Email Address")]
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "must be at least 8 characters")]
    public string Password { get; set; } = null!;
}
