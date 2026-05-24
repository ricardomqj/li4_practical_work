# 🕰️ TimeTreasures

> A web-based auction platform for collectible **watches**, built as a practical assignment for the LI4 (Computer Laboratories IV) course — 3rd year of the Software Engineering degree at the **University of Minho**, Braga, Portugal.

---

## 📖 Table of Contents

- [About the Project](#about-the-project)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Database Configuration](#database-configuration)
- [Authors](#authors)
- [License](#license)

---

## 📌 About the Project

**TimeTreasures** is a full-stack web application that allows users to browse, bid on, and list collectible items, specifically watches, through a real-time auction system.

Users can create an account, authenticate securely, favourite auctions, place bids, receive notifications, and manage their own listings.

---

## ✨ Features

- 🔐 **Authentication & Authorization** — Custom session-based auth with protected routes
- 🏠 **Home Feed** — Browse active auctions with search functionality
- 🃏 **Collectible Categories** — Cards and Watches as auctionable item types
- 🔨 **Auction Management** — Create, view, and bid on auctions (`Leilão`)
- 💛 **Favourite Auctions** — Save auctions to a personal favourites list (`LeiloesFav`)
- 🔔 **Notifications** — Real-time alerts for auction activity (`Notificações`)
- 👤 **User Profile** — View and manage personal account details
- 📋 **Sell Items** — List collectibles for auction (`Leiloar`)

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| **Frontend** | [Blazor Server](https://learn.microsoft.com/en-us/aspnet/core/blazor/) (.NET 7) |
| **Backend** | ASP.NET Core 7 |
| **Database** | Microsoft SQL Server |
| **ORM / Data Access** | Dapper via raw SQL (`SqlDataAccess`) |
| **Auth** | Custom `AuthenticationStateProvider` with `ProtectedSessionStorage` |
| **Styling** | Vanilla CSS |

---

## 📁 Project Structure

```
li4_practical_work/
├── demo/                        # Blazor Server web application
│   ├── Authentication/          # Custom auth state provider & user session
│   ├── Features/                # UI feature modules (pages + components)
│   │   ├── Home/                # Landing / feed page
│   │   ├── Inicial/             # Initial/splash screen
│   │   ├── Leilao/              # Auction detail page
│   │   ├── Leiloar/             # Create auction page
│   │   ├── LeiloesFav/          # Favourite auctions
│   │   ├── Login/               # Login page
│   │   ├── Notificacoes/        # Notifications
│   │   ├── Perfil/              # User profile
│   │   ├── Registar/            # Registration page
│   │   └── SearchBar/           # Search component
│   ├── wwwroot/                 # Static assets (CSS, images)
│   ├── Program.cs               # App entry point & DI configuration
│   └── appsettings.json         # App configuration (connection strings)
│
├── DataLayer/                   # Data access layer (class library)
│   ├── Cards/                   # Card model & repository
│   ├── Watches/                 # Watch model & repository
│   ├── Leilao/                  # Auction model & repository
│   ├── Licitacao/               # Bid model & repository
│   ├── LeilaoFavorito/          # Favourite auction repository
│   ├── Notificacao/             # Notification model & repository
│   ├── Utilizador/              # User model & repository
│   └── SqlDataAccess.cs         # Generic Dapper SQL executor
│
├── LI4 - Relatório.pdf          # Project report (Portuguese)
└── README.md
```

---

## ✅ Prerequisites

Make sure you have the following installed:

- [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express / LocalDB)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (recommended) or VS Code with the C# extension

---

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/ricardomqj/li4_practical_work.git
   cd li4_practical_work
   ```

2. **Configure the database** (see [Database Configuration](#database-configuration) below)

3. **Run the application**
   ```bash
   cd demo
   dotnet run
   ```

4. Open your browser at `https://localhost:5001` (or the port shown in the terminal)

---

## 🗄️ Database Configuration

Update the connection string in `demo/appsettings.json` to match your local SQL Server instance:

```json
{
  "ConnectionStrings": {
    "Default": "Server=YOUR_SERVER_NAME;Database=cards;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
  }
}
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name (e.g. `localhost`, `.\SQLEXPRESS`, etc.).

> **Note:** The database schema and seed scripts are described in the project report (`LI4 - Relatório.pdf`).

---

## 👥 Authors

Developed by students of the **Software Engineering** degree at the **University of Minho**, Braga, Portugal.

---

## 📄 License

This project is licensed under the terms found in [LICENSE.md](LICENSE.md).
