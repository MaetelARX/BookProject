📚 BookProject:

A Comprehensive Online Bookstore Management System

🌟 About the Project:

The BookProject is a full-stack web application designed for managing and interacting with an online bookstore. This project demonstrates a robust implementation of ASP.NET Core MVC, Entity Framework Core, and a layered architecture. With a focus on functionality, scalability, and clean code principles, the application serves multiple roles, such as administrators and end users, enabling them to manage and purchase books seamlessly.


![image](https://github.com/user-attachments/assets/973c04f9-dc5f-4f52-af72-1dabb2e6fe60)



🔧 Features

User Role Management:

Differentiated roles for Admins and Users.
Secure role-based access control implemented using ASP.NET Identity.
Comprehensive Book Management:

Admins can:

Add, update, or delete books with associated genres, prices, and stock details.

![image](https://github.com/user-attachments/assets/2a69d786-3a2d-4a6d-ae07-56182311f7fb)
![image](https://github.com/user-attachments/assets/8e6667b5-74a7-4e70-afe2-281a45c67acb)

Manage book images, resized and validated for proper formats.

![image](https://github.com/user-attachments/assets/21bd504a-5e96-4425-8f68-0070405fb12d)

Update stock and associate books with genres dynamically.

![image](https://github.com/user-attachments/assets/27ad33e0-8d36-48bb-85c4-81b030133c71)

Manage user orders, toggle payment status, and update order statuses as well as to filter and view orders by date or other criteria..

![image](https://github.com/user-attachments/assets/f726ed92-1a9c-4c30-b3fc-8f1644b8c164)
![image](https://github.com/user-attachments/assets/297822bd-1021-47e3-8d61-21116f4e1c5a)
![image](https://github.com/user-attachments/assets/66693348-25eb-4ce0-9897-ec4007d51b09)

Genre Management.

![image](https://github.com/user-attachments/assets/451dd761-1475-4e25-a138-fa49a901670f)

User can :

Add, remove, and update items in the shopping cart.

Place orders and view order history.

Payment tracking and order status updates.

![image](https://github.com/user-attachments/assets/dcf4e3d8-b706-40ac-8d41-dd1fa26914e2)
![image](https://github.com/user-attachments/assets/bf57af6e-71ec-4a25-8a40-3e7f5c9d616e)
![image](https://github.com/user-attachments/assets/50ecb1c3-5c7f-4670-84e8-c704bec609e3)

Admin Operations:

CRUD operations for book genres.
Dynamically assign genres to books.
Search and Sort Functionality:

Search books by title or author.
Sort books by price, title, or author for better user experience.
External Login Integration:

External login providers like Google for user authentication.
Seamless user account creation and external login callbacks.
Detailed Error Handling:

Graceful error handling with user-friendly messages for both frontend and backend.
🛠️ Tech Stack
Frontend:
Razor Views with clean and dynamic user interfaces.
Responsive design principles for better usability.
Backend:
ASP.NET Core MVC for building scalable web applications.
Entity Framework Core for database interactions.
Database:
SQL Server with a normalized schema for managing books, genres, users, orders, and more.
Authentication:
ASP.NET Identity for secure user management.
External login integration (Google).
🎯 Highlights
Clean, maintainable codebase with well-structured services, repositories, and controllers.
Comprehensive unit tests for critical components like controllers and repositories using Moq and xUnit.
Modular and scalable architecture for adding new features easily.
Extensive use of dependency injection for testability and decoupling.
Data validation using FluentValidation and ASP.NET Core model validation.
🤝 Contribution
This project is open for contributions! Whether it's fixing bugs, adding features, or optimizing the codebase, feel free to fork the project, submit a pull request, or raise an issue.

🚀 Getting Started
Clone the repository.
Restore the NuGet packages.
Update the database connection string in appsettings.json.
Run the Update-Database command to apply migrations.
Build and run the application.

💡 Future Enhancements
Implement a recommendation system based on user preferences.
Add reviews and ratings for books.
Introduce an admin dashboard for better analytics.
Optimize the search functionality with advanced filters.
📂 Folder Structure
Controllers: Handle user requests and manage the application's workflow.
Models: Define the application's data structures.
Repositories: Abstract database interactions for clean separation of concerns.
Services: Provide additional business logic and helper functions.
Views: Razor templates for the frontend interface.
🧑‍💻 Author
Plamen Jelev - Developer and designer of this project
