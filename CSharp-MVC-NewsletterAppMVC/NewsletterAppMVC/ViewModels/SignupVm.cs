using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMVC.ViewModels
{
    // ViewModel class to represent sign-up data
    public class SignupVm
    {
        // Properties to store sign-up information
        public int Id { get; set; }               // Unique identifier
        public string FirstName { get; set; }     // First name of the subscriber
        public string LastName { get; set; }      // Last name of the subscriber
        public string EmailAddress { get; set; }  // Email address of the subscriber
    }
}