📚 BookProject: A Comprehensive Online Bookstore Management System
🌟 About the Project
The BookProject is a full-stack web application designed for managing and interacting with an online bookstore. This project demonstrates a robust implementation of ASP.NET Core MVC, Entity Framework Core, and a layered architecture. With a focus on functionality, scalability, and clean code principles, the application serves multiple roles, such as administrators and end users, enabling them to manage and purchase books seamlessly.
![image](https://github.com/user-attachments/assets/973c04f9-dc5f-4f52-af72-1dabb2e6fe60)


🔧 Features
User Role Management:

Differentiated roles for Admins and Users.
Secure role-based access control implemented using ASP.NET Identity.
Comprehensive Book Management:

Admins can:
Add, update, or delete books with associated genres, prices, and stock details.
Manage book images, resized and validated for proper formats.
Update stock and associate books with genres dynamically.
User Cart and Orders:

Add, remove, and update items in the shopping cart.
Place orders and view order history.
Payment tracking and order status updates.
Admin Operations:

Manage user orders, toggle payment status, and update order statuses.
Filter and view orders by date or other criteria.
Genre Management:

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
