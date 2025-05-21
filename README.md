# Blazor Dashboard Demo

A modern, responsive user dashboard built with **Blazor WebAssembly (.NET 9)**.

This project showcases component-based architecture, API integration, and clean UI design with a front-end focused full-stack approach.

## ✨ Features

- 📊 **Dashboard UI** with task cards, pinning, and carousel
- 🧩 **Reusable Blazor components** for layout and interaction
- 🔄 **State management** with cascading values and services
- 📡 **API-ready structure** with optional ASP.NET Core backend
- 🖼️ Responsive layout with dark mode, Font Awesome icons
- 🌐 Deployable to **Vercel** (static client) or **Azure** (full stack)

## 🚀 Live Demo

> _Coming soon — deployed to [Vercel](https://vercel.com)_

## 📁 Project Structure

```
BlazorDashboardDemo/
├── Client/        # Blazor WebAssembly front-end
├── Server/        # ASP.NET Core API (optional, for Azure)
├── Shared/        # Shared models (e.g., TaskItem.cs)
└── README.md
```

## 🛠️ Getting Started

1. Clone the repo  
   `git clone https://github.com/yourusername/blazor-dashboard-demo.git`

2. Run the app  
   `dotnet run --project Server`

3. Publish for static deploy  
   `dotnet publish Client/Client.csproj -c Release -o dist`

## 📦 Deployment

- For **Vercel**: Deploy `dist/wwwroot` as a static output
- For **Azure App Service**: Publish the Server project as a full-stack app

## 🧠 Tech Stack

- Blazor WebAssembly (.NET 9)
- ASP.NET Core (optional)
- Visual Studio 2022
- Tailwind (optional), Font Awesome
- Vercel, Azure, GitHub

## 📄 License

MIT

---

> Built by Luis Ramos — [Portfolio](https://your-portfolio-url) · [GitHub](https://github.com/luis0795)