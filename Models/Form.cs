using System;
using System.ComponentModel.DataAnnotations;
    public class Form {
    // [Required]
    // [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
    // public string? FirstName {
    //     get;
    //     set;
    // }
    // [Required]
    // public string? LastName {
    //     get;
    //     set;
    // }
    // public int UserId {
    //     get;
    //     set;
    // }
    [EmailAddress (ErrorMessage="please enter valid email")]
    public string Email {
        get;
        set;
    }
    [Required]
[RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and must speacial character with No")]
    public string? Password {
        get;
        set;
    }
   [Compare(nameof(Password), ErrorMessage = "confirm password and password not match")]
      public string? confirmPassword {
        get;
        set;
    }
    // public string? Contact {
    //     get;
    //     set;
    // }
}