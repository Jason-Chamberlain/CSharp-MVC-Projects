# NewsletterAppMVC

1. [Overview](#overview)
1. [Controllers](#controllers)
   - [HomeController](#homecontroller)
   - [AdminController](#admincontroller)
1. [Views](#views)
   - [Home/Index](#homeindex)
   - [Admin/Index](#adminindex)
1. [Entity Framework Database First](#entity-framework-database-first)
1. [Learning Outcomes](#learning-outcomes)
1. [Conclusion](#conclusion)

## Overview
This repository, developed as part of the C# and .NET course at [The Tech Academy](https://www.learncodinganywhere.com/), is a simple web application built using the <u>**ASP.NET MVC**</u> framework in C#. It serves as a newsletter signup system, allowing users to sign up for a newsletter and administrators to manage newsletter subscriptions. The core components of this project include:

<u>**Controllers**</u>: The application features two main controllers, **`HomeController`** for user sign-up and **`AdminController`** for administrative functions.

<u>**Views**</u>: There are two primary views, **`Home/Index`** for user sign-up and **`Admin/Index`** for displaying and managing subscriptions.

<u>**Models**</u>: Two models, **`NewsletterEntities`** and **`SignUp`**, are used to represent the database structure and data entities.

## Controllers
### HomeController
The **`HomeController`** handles user sign-up for the newsletter. It includes the following actions:

- **`Index()`**: This action renders the sign-up form for users to provide their first name, last name, and email address.

- **`SignUp(string firstName, string lastName, string emailAddress)`**: This action processes the user's sign-up request, validates the input, and stores it in the database if valid.

### AdminController
The **`AdminController`** is responsible for managing newsletter subscriptions. It provides the following actions:

- **`Index()`**: This action retrieves and displays a list of newsletter subscriptions. Administrators can view and unsubscribe users from this list.

- **`Unsubscribe(int Id)`**: This action allows administrators to unsubscribe a user by marking their subscription as removed in the database.

## Views
### Home/Index
The **`Home/Index`** view displays a sign-up form for users. It includes fields for first name, last name, and email address. Users can submit this form to subscribe to the newsletter.

### Admin/Index
The **`Admin/Index`** view is designed for administrators to manage newsletter subscriptions. It lists all current subscribers and provides an option to unsubscribe them individually.

## Entity Framework Database First
In this project, the Entity Framework Database First approach was used to interact with the database. This means that the database structure was defined first, and then the Entity Framework generated code and models based on that database structure.

## Learning Outcomes
In the process of completing this project as part of the course, valuable knowledge and skills in the following areas was learned:

- **ASP.NET MVC**: How to create a web application using the ASP.NET MVC framework, including creating controllers, views, and models.

- **Entity Framework Database First**: Experience gained in using Entity Framework to interact with an existing database schema, which includes reading and writing data.

- **Form Handling**: How to create and process HTML forms for user input and data submission.

- **Controller Actions**: Proficient gained in defining controller actions to handle user requests and perform necessary operations.

- **View Rendering**: Knowledge aquired in rendering views and passing data between controllers and views.

- **Validation**: How to validate user input to ensure data integrity and user-friendly error handling.

- **Routing**: Experience gained in defining and configuring routes to map URLs to controller actions.

- **Security**: Gained knowledge in fundamental security principles, including input validation and authentication, and also learned the importance of using ViewModels to prevent the exposure of sensitive Model data.

## Conclusion

This project has provided a solid foundation in C# development, ASP.NET MVC, Entity Framework Database First, and database interaction, which can be applied to more complex web application development tasks in the future.