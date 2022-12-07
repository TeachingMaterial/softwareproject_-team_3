# Phase 1 - Requirements Engineering

## Introduction

An online university requires the development of a payment system for their students and staff. They wish for compatibility with their existing systems and for a report generator within the system for easy access to aggregate data. They expect this to be delivered on the 23rd of March. This project's development will follow a plan-driven waterfall model, which will be explained in the next section.

## Task Allocation Table

|Name| Git Username | Gre username| task |
|---|---|---|---|
|Warwick|janOliku|wm2109c|Introduction|
|Warwick|janOliku|wm2109c|System requirements specification|
|Warwick|janOliku|wm2109c|User requirements definition|
|Chris|chrisreilly706|cr6314|Software Process Model|
|Chris|chrisreilly706|cr6314|A Gantt chart of the project plan|
|Juan | jjuanda19 | jg8115y|Glossary|
|Juan | jjuanda19 | jg8115y|Possible risks and risk planning|
|Juan | jjuanda19 | jg8115y|References and Acknowledgements |

## User Requirements Definition

The User (currently Finance Administrator Seb Blair) requires the following features to be developed within this payment system:

1. Students must be able to submit tuition payments and recieve invoices.
2. Staff (lecturer) payroll and payslips must be generated and managed.
3. Reports must be able to be generated to access overall data including income, expenses and student records.
4. This system must be compatible with the other systems used by the University, including abiding by security regulations.

## System Requirements Specification

1. 1. Students must be able to make tuition payments directly through the system, ensuring that various payment methods are available, including Visa and MasterCard.
    2. Invoices for these payments will be generated and stored on the system database, and will be accessible to the students and the Finance Administrator through the system.
    3. Students must also be able to submit notification of Student Loan payments in order to fund their studies.
2. 1. The system will show current and rolling hour counts for staff in order for the Finance Administrator to verify and confirm pay calculations
    2. The system, upon the Finance Administrator's verification, will calculate pay and generate payslips for all staff who are owed wages in the current payment period. 
    3. Payslips will be able to be generated from any past data range, in case an error causes payslips to be incorrect, or in case a final calculation is needed for P45 or P60 HMRC tax purposes.
    4. The system will pay the staff using BACS based on the aforementioned payslip data.
3. 1. Reports of income (primarily tuition), expenses (wages and teaching materials) and total profit will be generated upon the Finance Administrator's request in order to view overall financial data.
    2. Reports of student records (grades, attendance, academic status, etc) will be generated upon the Finance Administrator's request in order to view overall academic data.
4. 1. The system will use existing student login data from the main database, and should sync data between this database and itself to integrate itself into the existing systems.
    2. The system will utilise Two Factor Authentication upon all login attempts as well as minimum password security requirements to adhere to GDPR regulations.
    3. The system will use an alphanumeric identifier for all students in the format of their initials followed by a random 4 digit number (aa000).
    4. The system will be programmed in C# using the dotNET framework for compatibility between this system and the other university systems.
