# 🔐 Day10 - SecureAuthAPI

## 📌 Overview
This project is an ASP.NET Core Web API that implements user authentication with secure password handling using SHA256 hashing.

---

## 🚀 Features
- User Registration
- Secure Password Hashing
- User Login with validation
- API testing using Swagger

---

## 🛠️ Tech Stack
- ASP.NET Core Web API
- C#
- Swagger (OpenAPI)
- System.Security.Cryptography

---

## 🔗 API Endpoints

### 🔹 Register
POST `/api/auth/register`  
Takes username and password, stores password in hashed format.

### 🔹 Login
POST `/api/auth/login`  
Validates user credentials by comparing hashed passwords.

---

## 🔐 Security
- Passwords are hashed using SHA256
- No plain text password storage

---

## 🧪 How to Run

1. Clone the repository
2. Navigate to project folder:
   cd Day10/Day10_SecureAuthAPI
3. Run the application:
   dotnet run
4. Open browser and access:
   http://localhost:5112/swagger

(Note: Swagger UI will work only when the application is running locally.)

---

## 🎯 Outcome
Developed a secure Web API for user authentication and gained understanding of backend API development and password security.