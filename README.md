# Coursera Blazor Final Project

## Project Description

This is a Blazor Server web application developed as a final project for a Coursera course. The application allows users to browse a list of events, view event details, register for events, and view the list of registered users for each event. It demonstrates Blazor Server concepts such as component-based architecture, dependency injection, state management, form validation, and session tracking.

**Key Features:**
- Browse and search upcoming events
- Register for events with validation
- View registered users per event
- Session-based welcome messages for first-time and returning visitors
- Clean, responsive UI using Bootstrap

---

## How to Run the Project

### Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) (or update the project to match your installed SDK version)
- A modern web browser

### Steps

1. **Clone the repository:**
    ```bash
    git clone https://github.com/yourusername/Coursera_BlazorFinalProject.git
    cd Coursera_BlazorFinalProject
    ```

2. **Restore dependencies:**
    ```bash
    dotnet restore
    ```

3. **Build the project:**
    ```bash
    dotnet build
    ```

4. **Run the application:**
    ```bash
    dotnet run --project Coursera_BlazorFinalProject/Coursera_BlazorFinalProject.csproj
    ```

5. **Open your browser and navigate to:**
    ```
    https://localhost:5001
    ```
    or as indicated in the terminal output.

---

## Notes

- If you encounter SDK version errors, update the `<TargetFramework>` in the `.csproj` file to match your installed .NET SDK.
- For development, you can use Visual Studio, VS Code, or the `dotnet` CLI.
- The application uses in-memory storage for registrations; data will be lost when the server restarts.

---

## License

This project is for educational purposes.