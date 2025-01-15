# DashboardCorilus

## Overview
DashboardCorilus is a comprehensive web-based dashboard for managing and visualizing financial and operational data. The project includes a backend implemented in .NET and a frontend built with modern web technologies, making it a powerful and user-friendly solution for data visualization and management.

## Features
### Backend
- Developed using ASP.NET Core.
- RESTful APIs for data handling and communication with the frontend.
- Secure authentication and authorization mechanisms.
- Database integration for storing and retrieving financial and operational data.

### Frontend
- Built using React with TypeScript.
- Modern and responsive user interface.
- Interactive data visualization using ApexCharts.
- Dynamic filtering and user customization options.
- Clean and professional design for an optimal user experience.

## Prerequisites
- **Backend**: .NET 6 or later.
- **Frontend**:
  - Node.js (v16 or later).
  - Yarn or npm for dependency management.

## Installation and Setup

### Clone the Repository
```bash
git clone https://github.com/YourUsername/DashboardCorilus.git
cd DashboardCorilus
```

### Backend Setup
1. Navigate to the backend folder:
   ```bash
   cd DashboardCorilus
   ```
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
3. Apply database migrations:
   ```bash
   dotnet ef database update
   ```
4. Run the backend server:
   ```bash
   dotnet run
   ```
   The backend server will start on `http://localhost:5000` by default.

### Frontend Setup
1. Navigate to the frontend folder:
   ```bash
   cd dashboard-corilus-front
   ```
2. Install dependencies:
   ```bash
   yarn install
   # or
   npm install
   ```
3. Start the development server:
   ```bash
   yarn dev
   # or
   npm run dev
   ```
   The frontend will be available at `http://localhost:3000`.

## Usage
1. Access the dashboard at `http://localhost:3000`.
2. Log in with your credentials.
3. Explore the features such as filtering, data visualization, and exporting reports.

## Project Structure
### Backend
- **Controllers**: Handles API endpoints.
- **Models**: Defines data structures.
- **Services**: Contains business logic.
- **Data**: Handles database operations and migrations.

### Frontend
- **public/**: Static assets.
- **src/**:
  - `components/`: Reusable UI components.
  - `pages/`: Main pages of the application.
  - `services/`: API communication logic.
  - `assets/`: Styles, images, and other assets.

## Technologies Used
### Backend
- ASP.NET Core
- Entity Framework Core
- SQL Server

### Frontend
- React
- TypeScript
- ApexCharts
- Vite.js


## License
This project is licensed under the MIT License. See the `LICENSE` file for details.



