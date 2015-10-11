using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModel
{
    public class AuthLogin
    {
        [Required(ErrorMessage = "Please enter a valid username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a valid password."), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}