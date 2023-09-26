# Car Insurance Web Application 

1. [Overview](#overview)
1. [Controllers](#controllers)
    - [HomeController](#homecontroller)
    - [InsureeController](#insureecontroller)
1. [Models/ViewModels](#modelsviewmodels)
    - [Admin](#admin)
    - [QuoteVM](#quotevm)
1. [Views](#views)
    - [Insuree/Index](#insureeindex)
    - [Insuree/Admin](#insureeadmin)
    - [Insuree/Create](#insureecreate)
    - [Insuree/Delete](#insureedelete)
    - [Insuree/Details](#insureedetails)
    - [Insuree/Edit](#insureeedit)
1. [Entity Framework Database First](#entity-framework-database-first)
1. [Learning Outcomes](#learning-outcomes)
1. [Conclusion](#conclusion)

## Overview
Welcome to the Car Insurance Web Application README. This project is the result of a comprehensive C# training course, designed to teach key concepts in web application development using ASP.NET MVC and Entity Framework. In this README, we'll explore the project's structure and highlight the major components.

## Controllers

### HomeController
The `HomeController` is responsible for managing basic actions, including:
- **Index**: Displays the home page.
- **About**: Renders the about page.
- **Contact**: Displays the contact page.

### InsureeController
The InsureeController handles insurance-related functionalities, including:
- **Index**: Lists all insured customers and their details.
- **Details**: Shows detailed information about a specific customer.
- **Create**: Allows the creation of new insurance records.
- **Edit**: Permits the modification of existing insurance records.
- **Delete**: Enables the removal of insurance records.
- **Admin**: Displays an admin page with insurance quotes issued to customers.

## Models/ViewModels

### Admin
The `Admin` model serves as a container for insurance-related data. It facilitates the presentation of quotes issued to customers.

### QuoteVM
The `QuoteVM` model represents a quote issued to a customer, including their name, email address, and the calculated quote amount.

## Views

### Insuree/Index
The `Insuree/Index` view lists all insured customers and their details, offering a user-friendly display of insurance records.

### Insuree/Admin
The `Insuree/Admin` view presents a list of insurance quotes issued to customers. It leverages the Admin and QuoteVM models to present the data.

### Insuree/Create
The `Insuree/Create` view allows users to input data and create new insurance records. It helps in expanding the database of insured customers.

### Insuree/Delete
The `Insuree/Delete` view confirms the deletion of insurance records, ensuring users make informed decisions about removing data from the system.

### Insuree/Details
The `Insuree/Details` view provides in-depth information about a specific customer's insurance record, aiding in understanding their coverage details.

### Insuree/Edit
The `Insuree/Edit` view allows users to modify existing insurance records, ensuring that customer information remains up-to-date.

## Entity Framework Database First
In this project, the Entity Framework Database First approach was used to interact with the database. This means that the database structure was defined first, and then the Entity Framework generated code and models based on that database structure.

## Learning Outcomes

Throughout the development of this web application, several key concepts were covered, including:

- ASP.NET MVC architecture.
- Entity Framework Database First approach.
- Creating and managing controllers.
- Designing and rendering views.
- Utilizing models and view models.
- Handling user input and validation.
- Building interactive web applications.

## Conclusion

This Car Insurance Web Application project not only demonstrates proficiency in ASP.NET MVC and Entity Framework but also serves as a practical example of building a web-based insurance management system. The skills and knowledge gained during its development can be applied to various web development scenarios, making this project a valuable learning experience.