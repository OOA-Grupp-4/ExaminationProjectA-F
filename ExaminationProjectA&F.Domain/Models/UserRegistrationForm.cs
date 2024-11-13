
using System.ComponentModel.DataAnnotations;

namespace ExaminationProjectA_F.Domain.Models;

public class UserRegistrationForm
{
    [Required(ErrorMessage = "You must enter a firstname")]

    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a lastname")]

    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "You must enter an email")]

    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a password")]

    public string Password { get; set; } = null!;
}