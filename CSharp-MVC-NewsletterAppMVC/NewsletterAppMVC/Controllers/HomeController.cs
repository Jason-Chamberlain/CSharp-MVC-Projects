using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: This action displays the sign-up form
        public ActionResult Index()
        {
            return View();
        }

        // POST: This action processes user sign-up requests
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            // Check if any of the provided information is empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                // If any field is empty, show an error view
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                // If all fields are filled, proceed with sign-up
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    // Create a new SignUp object with user-provided data
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    // Add the new sign-up to the database
                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }
                // Redirect to a success view after successful sign-up
                return View("Success");
            }
        }
    }
}