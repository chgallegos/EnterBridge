# 🚧 EnterBridge Procurement Portal

[![Built with HTML](https://img.shields.io/badge/Frontend-HTML%2FCSS%20%2B%20JS-blue)](#)
[![.NET 9](https://img.shields.io/badge/Backend-.NET%209-%23712cf9)](#)
[![Bootstrap](https://img.shields.io/badge/Styled%20With-Bootstrap%205-orange)](#)

This is a simple procurement web app I built for the **EnterBridge Full-Stack Case Study**.  
It allows users to create supply orders by pulling real-time product and price data from EnterBridge’s public APIs.

Designed to be responsive and tablet-friendly, it supports fast ordering workflows, grouped order history, and clean CSV export.

---

## 📋 Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [How to Run](#how-to-run)
- [CSV Format](#csv-format)
- [Notes](#notes)
- [Recording](#recording)
- [About Me](#about-me)

---

## ✨ Features

- 🔄 Real-time product + price data from EnterBridge APIs
- 🧭 Filter products by category
- 📦 Cart system with quantity control and subtotal
- 🧠 **Smart cart merging:** adding the same product combines quantities
- 📤 Submits order to local backend (in-memory)
- 🧾 Displays recent orders grouped by order ID
- 📄 One-click CSV export with totals
- ✅ Optimized for iPads and desktops
- 💡 Export tip: Easily filter CSV by category or date in Excel/Sheets

---

## 🧰 Tech Stack

| Layer        | Tech                     |
|--------------|---------------------------|
| Frontend     | HTML, CSS (Bootstrap), Vanilla JS |
| Backend      | .NET 9 API (`EnterBridgeApp.csproj`) |
| Persistence  | In-memory (no DB)         |
| Auth         | None (case study scoped)  |

---

## 🚀 How to Run

### 1. Clone the project and move into the folder:

```bash
cd your/path/EnterBridgeApp
```

### 2. Run the backend:

```bash
dotnet build Enterbridge.sln
dotnet run --project EnterBridgeApp.csproj
```

### 3. Open the frontend:

If it doesn’t open automatically, go to:

```
http://localhost:5000/index.html
```

---

## 📊 CSV Format

CSV export groups by Order ID and includes:

| Column        | Description                     |
|---------------|----------------------------------|
| Order ID      | Unique order identifier         |
| Category      | Product category (e.g., Plumbing, Tools) |
| Product       | Product name                    |
| SKU           | Stock Keeping Unit              |
| Quantity      | Ordered quantity                |
| Unit Price    | Price at time of order          |
| Total Price   | Unit Price × Quantity           |
| Date          | Timestamp of order placement    |

**Grouped totals** appear at the end of each order.

> 💡 Tip: In Excel or Google Sheets, use `Data → Create Filter` to sort or filter by category, date, or order.

---

## 🧠 Notes

- All state is stored in memory (no persistent database)
- Products are always priced based on the **latest value from the pricing API**
- Duplicate product entries are merged in the cart (e.g., 2 + 3 = 5 qty)
- CSV export is structured to support bookkeeping and filters
- Designed to be used without login or database for quick evaluation

---

## 🎥 Recording

A short walkthrough video is included in the repo:  
📁 `recording.mp4` – showing how the app works end-to-end

---

## 🙋 About Me

**Christopher Gallegos**  
Salt Lake City, UT  
[🌐 chris-gallegos.com](https://portfolio-website-chgallegos.herokuapp.com/)  
[📧 Contact me on LinkedIn](https://www.linkedin.com/in/christopher-gallegos-91231363/)
