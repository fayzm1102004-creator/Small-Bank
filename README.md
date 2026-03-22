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
⚙️ How It Works (Code Example)
// 1. Initialize the reporting list
List<IReportable> Report = new List<IReportable>();

// 2. Instantiate various financial accounts
SavingsAccount s1 = new("fayez", 5000);     // Savings: 5000 balance
CurrentAccount c1 = new("zahree", 10000);   // Current: 10000 balance
Loan l1 = new("noor", 50000);               // Loan: 50000 amount

// 3. Populate the report list
Report.Add(s1);
Report.Add(c1);
Report.Add(l1);

// 4. Generate the unified financial report
foreach (IReportable t in Report) 
{
    Console.WriteLine(t.ToString());
}
📊 Expected Output
AccountNo[1001]||ClientName:[fayez] || Amount:[5250]
AccountNo[1002]||ClientName:[zahree] || Amount:[9950]
ClientName: noor | Amount: 50000 | Status: Pending