# Project2_Sprint1CST4708

## About

This repository contains the Sprint 1 work for the Auto Rental Management System project.

Student: M. Balaev  
GitHub: mbalaev2020  
Course: CST4708

## Sprint 1 Overview

Sprint 1 focuses on setting up the Auto Rental Management System application structure and implementing the first working data flow for credit card management. The project is organized as a C# Visual Studio solution with separate client, business object, and data access layers.

The current implementation includes:

- A Windows Forms client application for the Auto Rental Management System.
- Main menu and portal forms for the rental/POS workflow.
- Credit card management screens.
- A business object layer for credit card records.
- A SQL Server data access layer that loads credit card records from the database.
- A data transfer object for moving credit card data between layers.
- A print/export method that writes credit card record output to `Network_Printer.txt`.
- A database project document included as `MBalaev_DBProjet1.docx`.

## Project Structure

```text
AutoRentalSystem.sln
ARMSClientApp/
ARMSBOLayer/
ARMSDALayer/
MBalaev_DBProjet1.docx
```

## Layers

### ARMSClientApp

The client layer contains the Windows Forms user interface. It starts from `Program.cs` and opens the rental/POS system form. The forms provide the visible entry points for rental, customer, vehicle, ERP, and credit card management workflows.

### ARMSBOLayer

The business object layer contains business-facing objects such as `CreditCard`. This layer loads credit card data from the data access layer and exposes it to the client layer. It also includes output logic for printing a credit card record to a text file.

### ARMSDALayer

The data access layer contains the SQL Server connection configuration, DAO factory, credit card DAO, interface, and DTO classes. The credit card DAO uses a parameterized SQL query to find a credit card record by credit card number.

## Database

The application is configured to connect to SQL Server using the `EzRentalDB` database. The connection string is stored in:

```text
ARMSDALayer/DbConfig.cs
```

If the SQL Server instance name is different on another computer, update the `Data Source` value in `DbConfig.cs`.

## Sprint 1 Deliverables

- Visual Studio solution setup.
- Multi-layer project organization.
- Initial WinForms navigation screens.
- Credit card business object.
- Credit card DAO and DTO implementation.
- SQL Server connection setup.
- Database project documentation file.

## How to Run

1. Open `AutoRentalSystem.sln` in Visual Studio.
2. Confirm that SQL Server is running and the `EzRentalDB` database exists.
3. Update `ARMSDALayer/DbConfig.cs` if the local SQL Server instance name is different.
4. Build the solution.
5. Run `ARMSClientApp`.

