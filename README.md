# 🏦 Small Bank Management System

## 📋 Overview
**Small Bank** is a robust, lightweight console application built with **C#**. It serves as a practical implementation of Object-Oriented Programming (OOP) principles to manage different types of bank accounts, calculate specific interest rates, and generate unified financial reports.

## ✨ Key Features
* **Multi-Account Management:** Supports various account types including Savings, Current, and Loans.
* **Automated Interest Calculation:** Unique interest and fee logic applied dynamically based on the specific account type.
* **Unified Reporting Interface:** Utilizes the `IReportable` interface to standardize outputs across all financial entities.
* **Data Validation:** Built-in safeguards to ensure balances remain positive.
* **Unique Identification:** Automated generation of sequential, unique IDs (starting from 1000) for every new account.

## 💻 Technical Concepts Applied
This project heavily emphasizes core C# and OOP fundamentals:
* **Inheritance:** `CurrentAccount` and `SavingsAccount` inherit from a base `BankAccount` class.
* **Abstract Classes:** `BankAccount` is structured as an abstract blueprint.
* **Polymorphism:** The `CalculateInterest()` method is overridden with custom logic in each derived class.
* **Interfaces:** Implementation of `IReportable` to enforce a contract for financial reporting.
* **Encapsulation:** Protecting data states using `private` fields and exposing them safely via `public` properties.

## 🏗️ Project Structure
```text
Small-Bank/
├── Program.cs             # Application Entry Point
├── BankAccount.cs         # Abstract Base Class
├── CurrentAccount.cs      # Derived Class (Fees logic)
├── SavingsAccount.cs      # Derived Class (Interest logic)
├── Loan.cs                # Loan Management Class
├── IReportable.cs         # Reporting Interface
└── Small-Bank.csproj      # Project Configuration
