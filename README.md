# EnterBridge Procurement Portal

This is a simple procurement web app I built for the EnterBridge full-stack case study. It helps users create orders for building supplies by pulling real-time product and pricing data from EnterBridge’s public API.

The UI is designed to be mobile-friendly and easy to use on tablets (like iPads) or desktops. It lets users browse products, build up an order cart, and export past orders to CSV.

---

## Features

- Pulls product and price data from EnterBridge APIs
- Captures latest price when adding to order
- Cart with quantity controls and subtotal calculation
- Submits full order to a local backend (simulated database)
- Displays past orders grouped by order ID and date
- One-click CSV export for record-keeping
- Clean and responsive layout using Bootstrap

---

## Tech Stack

- HTML, CSS (Bootstrap), and vanilla JS for the frontend
- .NET 8 backend API for handling orders
- No authentication (per case study scope)
- All state is stored in-memory – no database needed

---

## How to Run

**1. Open a terminal and go to the project folder:**

```bash
cd your/path/EnterBridgeApp
```

**2. Run the backend (pick one):**

- To run from project directory:

```bash
dotnet build Enterbridge.sln; dotnet run EnterBridgeApp.csproj
```

**3. Open the frontend:**

The script should open the default webbrowswer autmatically, in case it does not. Open your browser and go to:

```
http://localhost:5000/index.html
```
---

## CSV Format

Exports a CSV that groups orders by ID and includes:

- Order ID
- Product Name
- SKU
- Quantity
- Unit Price
- Total Price
- Timestamp

Each group also shows the total at the bottom.

---

## Notes

I used in-memory storage to keep things simple since persistence wasn't required. Prices are pulled fresh when items are added to the cart. No user login is implemented since it was out of scope, but each order includes a unique ID and timestamp.

The app is responsive and works great on iPads and desktops. I added some basic visual polish like spinners, alerts, and grouped display of orders to make it easier to use.

---

## Recording

I’ve included a short video walkthrough (`recording.mp4`) showing how the app works from start to finish.

---

## About Me

Built by Christopher Gallegos  
[chris-gallegos.com](https://portfolio-website-chgallegos.herokuapp.com/)  
Salt Lake City, UT
