# 🌿 LifeHub – Productivity & Wellness Suite

**LifeHub** is a .NET MAUI–based cross-platform application designed to help users manage habits, moods, daily plans, and overall well-being through four integrated modules.  
The project was developed as part of the *Windows Programming (Fall 2025–2026)* course at Ege University.

---

## 👥 Team Members
| Student No | Name |
|-------------|------|
| 05210000260 | Kutlu Çağan Akın |
| 05210000296 | Ali Osman Taş |

---

## 🧩 Project Overview

LifeHub consists of **four independent .NET MAUI apps**:
1. **DashboardApp** – Displays navigation cards to other apps.  
2. **HabitTrackerApp** – Tracks user habits with checkbox-based status and timestamp.  
3. **MoodJournalApp** – Lets users record daily moods and notes (max. 7 recent entries).  
4. **PlannerApp** – Daily planner with task creation, due dates, timestamps, and delete actions.

Each app implements **ICommand binding** directly in XAML and applies multiple **UX Laws** (Fitts, Hick, Miller, Aesthetic–Usability, etc.).

---

## ⚙️ Technologies Used

| Category | Tools / Frameworks |
|-----------|--------------------|
| Frontend | .NET MAUI (.NET 9.0), XAML |
| Backend | C# (.NET MAUI Code-behind) |
| IDE | Visual Studio 2022, Visual Studio Code |
| Version Control | Git & GitHub |
| Documentation | Microsoft Word, Markdown |
| AI Assistance | ChatGPT-5, Claude 4.5 Sonnet |
| OS Compatibility | Windows 10/11, macOS (Maui Catalyst) |

---

## 🏗️ Project Structure

LifeHub_Midterm_Project/
│
├── DashboardApp/
│ ├── MainPage.xaml
│ ├── MainPage.xaml.cs
│ ├── App.xaml
│ └── AppShell.xaml
│
├── HabitTrackerApp/
│ ├── MainPage.xaml
│ ├── MainPage.xaml.cs
│ ├── Habit.cs
│ └── App.xaml
│
├── MoodJournalApp/
│ ├── MainPage.xaml
│ ├── MainPage.xaml.cs
│ └── App.xaml
│
├── PlannerApp/
│ ├── MainPage.xaml
│ ├── MainPage.xaml.cs
│ └── App.xaml
│
└── README.md




---

🖥️ How to Run the Project

🪟 Option 1 – Run via .NET CLI (Windows)

Each app must be built from its outer folder and run from its inner project folder.


Example: DashboardApp

cd DashboardApp
dotnet build
dotnet run --project DashboardApp/DashboardApp.csproj -f net9.0-windows10.0.19041.0


 Example: PlannerApp
# Navigate to the app root folder
cd PlannerApp

# Build the project (creates the /bin output)
dotnet build

# Run the executable using the full path (note the double folder) (PlannerApp/PlannerApp)

dotnet run -f net9.0-windows10.0.19041.0




 Option 2 – Run on macOS (Mac Catalyst)
# Example for PlannerApp
cd PlannerApp
dotnet build
dotnet run --project PlannerApp/PlannerApp.csproj -f net9.0-maccatalyst


Make sure that Mac Catalyst workload is installed:

dotnet workload install maui



Option 3 – Run from Visual Studio

Open LifeHub_Midterm_Project.sln in Visual Studio.

In the Solution Explorer, right-click the app (e.g., PlannerApp) and select:

Set as Startup Project

Then press F5 or select Run ▶️.

Repeat for other apps (Dashboard, HabitTracker, MoodJournal).




Note: Ensure you have the latest .NET 9 SDK and installed MAUI workloads.
Check with:
dotnet workload list



