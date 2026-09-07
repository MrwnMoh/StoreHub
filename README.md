# 🛒 StoreHub - E-Commerce Platform

<p align="center">
  <img src="https://readme-typing-svg.herokuapp.com?font=Fira+Code&size=28&pause=1000&color=7C3AED&width=800&lines=StoreHub+E-Commerce+Platform;C%23+Windows+Forms+Application;ASP.NET+Core+Web+API;Secure+Desktop+Application" alt="Typing Animation" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-Project-purple?style=for-the-badge&logo=c-sharp">
  <img src="https://img.shields.io/badge/.NET-Windows+Forms-blue?style=for-the-badge&logo=.net">
  <img src="https://img.shields.io/badge/ASP.NET-Core+Web+API-blueviolet?style=for-the-badge&logo=dotnet">
  <img src="https://img.shields.io/badge/Database-SQL--Server-red?style=for-the-badge&logo=microsoft-sql-server">
  <img src="https://img.shields.io/badge/Entity+Framework-Core-green?style=for-the-badge">
  <img src="https://img.shields.io/badge/Security-JWT-yellow?style=for-the-badge">
</p>


---

# 📝 Introduction

**StoreHub** is an E-Commerce desktop application developed using **C# Windows Forms** connected with a backend **ASP.NET Core Web API**.

The system provides a complete shopping experience including products browsing, shopping cart, checkout, orders management, user profiles, stores management, seller dashboard, and admin dashboard.

The project follows a **3-Layer Architecture** to separate responsibilities between different layers, providing cleaner code structure, better maintainability, and easier future improvements.

The backend is developed using **ASP.NET Core Web API** with **Entity Framework Core** connected to **SQL Server**.

Security is implemented using:

- JWT Authentication
- Access Token & Refresh Token
- Authorization Rules
- Owner Validation

The desktop application communicates with the API using **HttpClient**.


---

# 🖼️ Project Screenshots


# 🔐 Authentication

| Login Interface |
| :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Login.png" width="925"> |


---


# 🏠 Home Screen

The home screen contains the main shopping experience with banner sections, categories, dynamic content, and animated sections.


| Main | Main Variation |
| :---: | :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Main1.png" width="450"> | <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Main2.png" width="450"> |


| Home Products | Home Products Variation |
| :---: | :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Home%20Products.png" width="450"> | <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Home%20Products2.png" width="450"> |


---


# 🛍️ Products Browsing


| All Products | All Products Variation |
| :---: | :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/All%20Products.png" width="450"> | <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/All%20Products2.png" width="450"> |


The products section supports:

- Product searching
- Category filtering
- Sorting
- Pagination


---


# 📦 Product Details


| Product Details | Product Details Variation |
| :---: | :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Product%20Details.png" width="450"> | <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Product%20Details2.png" width="450"> |


---


# 🛒 Cart & Checkout


| Shopping Cart | Checkout |
| :---: | :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Cart.png" width="450"> | <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Checkout.png" width="450"> |


---


# 👤 User Profile & Account Management


| My Profile |
| :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/My%20Profile.png" width="925"> |


| My Orders | My Reviews |
| :---: | :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/My%20Orders.png" width="450"> | <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/My%20Reviews.png" width="450"> |


---


# 🏪 Seller Dashboard


| Seller Dashboard |
| :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Seller%20Dashboard.png" width="925"> |


---


# 🛡️ Admin Dashboard


| Admin Dashboard |
| :---: |
| <img src="https://raw.githubusercontent.com/MrwnMoh/StoreHub/main/Pics/Admin%20Dashboard.png" width="925"> |


---

# 🚀 Key Features


## 🔐 1. Authentication & User Management

* Secure authentication using **JWT Authentication**
* Implemented **Access Token & Refresh Token**
* User authorization based on permissions
* Protected API operations using authorization rules

### User Profile Management

* View user profile information
* Update user information:
  - Name
  - Email
  - Phone
  - Country
  - Address
  - Birth Date
  - Profile Image

* Validate Email before update
* Validate Phone number before update
* Check that Email and Phone are not used by another user

* Profile images are stored locally using GUID file names to prevent duplicate file names


---


# 🛍️ 2. Products Management

* Add new products
* Update product information
* Delete products
* Display products
* Search products
* Filter products by category
* Sort products
* Pagination support

### Product Images

* Multiple images support
* Add product images
* Update product images
* Delete product images
* Display product images in product details and reviews

Images are stored locally using GUID names.


---


# 🏪 3. Stores Management

* Create stores
* Manage stores
* Change current store
* Connect products with stores
* Manage seller store operations


---


# 🛒 4. Shopping Cart & Checkout

* Add products to cart
* Update cart quantities
* Remove products from cart
* Validate product availability
* Checkout process
* Create orders from cart items


---


# 📦 5. Orders Management

## Customer Orders

Users can:

* View previous orders
* Display order status
* Display products and quantities
* Display total amount
* View complete order details

Using:

- Pagination
- View Details

Users can cancel orders.



## Seller Orders

Seller can:

* View orders related to his store only
* View order details
* View products and quantities
* Update order status



---


# ⭐ 6. Reviews & Ratings

* Add product reviews
* Add ratings
* Display user reviews
* Display product reviews
* Connect reviews with products

Users can:

* View their previous reviews
* Navigate directly to product details
* Add product to cart
* Buy product


Pagination is supported for reviews.


---


# 🏪 7. Seller Dashboard

A complete dashboard for sellers to manage their stores.

Seller Dashboard includes:

* Products count
* Orders count
* Total sales
* Quick shortcuts for main operations


Seller can:

* Manage stores
* Add products
* Update products
* Delete products
* Manage product images
* View store orders
* Update order status
* View customer reviews


Seller can view only orders that contain products from his store.


---


# 🛡️ 8. Admin Dashboard

Admin access is protected using authorization rules.

Non-admin users cannot see or access Admin Dashboard.


## Users Management

Admin can:

* View all users
* Add new users
* Update user information
* Change account status


During user creation:

* Validate Email uniqueness
* Validate Phone uniqueness


---


## Stores Management

Admin can:

* View all stores
* View store owners
* Display products count
* Display orders count
* Display store revenue


---


## Orders Management

Admin can:

* View all orders from all stores
* View order information
* Track order status


---


## Products Management

Admin can:

* View all products from all stores
* Display product information


---


# 🗄️ Database Implementation

* Microsoft SQL Server Database
* Entity Framework Core
* Entity Relationships
* LINQ Queries
* Data Validation


---


# 🏗️ Architecture & Development

The project follows a **3-Layer Architecture** to separate responsibilities between presentation, business, and data layers.

Implemented concepts:

* Object-Oriented Programming (OOP)
* DTO-based communication
* RESTful API Architecture
* Async/Await programming
* HttpClient communication between WinForms and Web API


---


# 🛠️ Technologies Used

* **Language:** C#

* **Desktop Application:** Windows Forms

* **Backend:** ASP.NET Core Web API

* **Database:** Microsoft SQL Server

* **ORM:** Entity Framework Core

* **Architecture:** 3-Layer Architecture

* **UI Design:** Guna.UI2

* **API Communication:** RESTful API & HttpClient

* **Security:** JWT Authentication, Refresh Token, Authorization

* **Image Storage:** Local File System using GUID

