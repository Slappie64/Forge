# Forge Workout Tracker

A web application to track users' workouts, monitor progression, and maintain a history of exercises. Users can create an account, log workouts, and optionally back up their data to the cloud.
<p align="center">
  <img src="https://github.com/user-attachments/assets/801f6d37-c055-451f-9f0c-53845872415e">
<p>

## Table of Contents
- [Features](#features)
- [Screenshots](#screenshots)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Contributing](#contributing)
- [License](#license)
- [Acknowledgments](#acknowledgments)
- [Contact](#contact)
- [Additional Notes](#additional-notes)
- [Resources](#resources)

## Features

- **User Authentication**: Secure registration and login functionality using ASP.NET Core Identity.
- **Workout Management**:
  - Create, view, and delete workouts.
  - Add exercises to workouts with details like sets, repetitions, and weight.
- **Progress Tracking**:
  - View workout history.
  - Monitor progress over time.
- **Responsive Design**: Accessible on both desktop and mobile browsers.
- **Data Backup (Optional)**:
  - Option to back up user data to the cloud.

## Screenshots

*(Include screenshots of key pages like the login screen, workout list, workout details, and exercise entry forms.)*

## Prerequisites

- **Operating System**: Windows / Linux
- **.NET SDK**: Version 6.0 or later
- **SQLite**: For database management
- **Visual Studio Code**: Recommended for development
- **Node.js and npm**: If you plan to incorporate frontend tooling or frameworks (optional)

## Installation

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/Forge Workout TrackerApp.git
cd Forge Workout TrackerApp
```

### 2. Install .NET SDK
Follow the instructions for your Linux distribution from the .NET Downloads page. For Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y dotnet-sdk-6.0
```
Verify the installation:
```bash
dotnet --version
```
### 3. Install SQLite
```bash
sudo apt-get install sqlite3 libsqlite3-dev
```
### 4. Install Node.jsand npm (Optional, if using frontend tooling)
```bash
sudo apt-get install -y nodejs npm
```
### 5. Restore NuGet Packages
```bash
dotnet restore
```
### 6. Apply Database Migrations
```bash
dotnet tool install --global dotnet-ef
dotnet ef database update
```
### 7. Run the Application
```bash
dotnet run
The application will be accessible at https://localhost:5001 or http://localhost:5000.
```

## Usage

### 1. Register a New Account

- Navigate to `https://localhost:5001`.
- Click on **Register**.
- Fill out the registration form and submit.

### 2. Log In

- Use your registered email and password to log in.

### 3. Create a Workout

- Click on **Workouts** in the navigation menu.
- Click on **Create New Workout**.
- Select the date and save.

### 4. Add Exercises to a Workout

- After creating a workout, click on **Details**.
- Click on **Add Exercise**.
- Fill in exercise details (name, sets, repetitions, weight) and save.

### 5. View Progress

- Navigate to **Workouts** to see a list of all your workouts.
- View details of each workout to monitor progress.

## Project Structure

The project structure is organized as follows:
```
Forge Workout TrackerApp/
├── Controllers/
│   ├── HomeController.cs
│   ├── WorkoutsController.cs
│   └── ExercisesController.cs
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Migrations/
├── Models/
│   ├── ApplicationUser.cs
│   ├── Workout.cs
│   └── Exercise.cs
├── Views/
│   ├── Home/
│   ├── Workouts/
│   ├── Exercises/
│   └── Shared/
├── wwwroot/
│   ├── css/
│   └── js/
├── appsettings.json
├── Program.cs
├── Startup.cs
└── README.md
```
## Technologies Used

- **C# and ASP.NET Core MVC**: Backend development
- **Entity Framework Core**: Database ORM for data access
- **SQLite**: Lightweight relational database management
- **ASP.NET Core Identity**: Authentication and user management
- **Bootstrap**: Styling and responsive design for the user interface
- **Visual Studio Code**: Code editor used for development
- **Linux**: Operating system for development and hosting


## Contributing

Contributions are welcome! Please follow these steps:

1. **Fork the Repository**

   Click on the **Fork** button at the top right of the repository page.

2. **Clone Your Fork**
```bash
git clone https://github.com/yourusername/Forge Workout TrackerApp.git
cd Forge Workout TrackerApp
```
3. **Create a Feature Branch**

```bash
git checkout -b feature/YourFeature
```
4. **Make Changes**

Implement your feature or fix.

5. **Commit Changes**

```bash
git add .
git commit -m "Add feature: YourFeature"
```
6. **Push to Your Fork**

```bash
git push origin feature/YourFeature
```
7. **Create a Pull Request**

Go to the original repository and click on Pull Requests, then New Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- **My Fiance, Amy**: For listening to me ramble on about random issues.
- **Microsoft Documentation**: For extensive resources on ASP.NET Core and Entity Framework Core.
- **Community Tutorials**: Various online tutorials and guides that assisted in the development process.
- **Open Source Libraries**: Thanks to all open-source contributors whose libraries and tools made this project possible.

## Contact

- **Project Maintainer**: Luigi
- **Email**: emails@luigi.marino.com
- **GitHub**: [Slappie64](https://github.com/slappie64)

## Additional Notes

- **Future Enhancements**:
  - Implement data visualization for progress tracking.
  - Add the ability to back up data to cloud services like Azure or AWS.
  - Integrate with external authentication providers (Google, Facebook, etc.).
  - Develop a mobile application using MAUI Blazor for cross-platform compatibility.

- **Issues and Bug Reports**:

  If you encounter any issues or bugs, please open an issue in the GitHub repository with detailed information.
  
## Resources

- **ASP.NET Core Documentation**: [docs.microsoft.com/aspnet/core](https://docs.microsoft.com/aspnet/core)
- **Entity Framework Core Documentation**: [docs.microsoft.com/ef/core](https://docs.microsoft.com/ef/core)
- **SQLite Documentation**: [sqlite.org/docs.html](https://www.sqlite.org/docs.html)
- **Bootstrap Documentation**: [getbootstrap.com](https://getbootstrap.com)
- **Visual Studio Code Documentation**: [code.visualstudio.com/docs](https://code.visualstudio.com/docs)
- **.NET SDK Downloads**: [.NET Downloads](https://dotnet.microsoft.com/download)

