## Introduction

This report details the model of the system that will be developed. It includes various critical diagrams which illustrate the scope and logistics of the implementation of the system.
These are:
- Overall Architecture,
- Use Case Diagrams, for documenting the various usage requirements from different groups of users,
- Sequence Diagrams, which show in-depth explanation of the processes within the system,
- Class Diagrams, showing the relationships between different entities within the system,
- Activity Diagrams, highlighting the overall flow of the system,
- State Diagrams, designating the different states and state transitions of the system.

## Task Allocation Table

|Name| Git Username | Gre username| Task |
|---|---|---|---|
|Warwick|janOliku|wm2109c|Introduction|
|Juan|jjuanda19|jg8115y|Gantt Chart|
|Warwick|janOliku|wm2109c|State diagrams|
|Chris|chrisreilly706|cr6314|Class diagrams|
|Chris|chrisreilly706|cr6314|Activity diagram|
|Juan | jjuanda19 | jg8115y|Use Case diagrams|
|Juan | jjuanda19 | jg8115y|Sequence digrams|



# Apepndix
## Use case diagram
<div align=center>
<img src="https://user-images.githubusercontent.com/114992140/213960846-f6c1c81c-ee7e-4464-ac2e-02fc31440de8.png"></div>

## Tabular representation of the use cases for Payroll System

| Actors | Students, Staff and Finace administrator|
|---|---|
|Description| Students will be registered in the system and they will have their username and the will be able to pay their tution fees throug any card payment. After the payment is produced they will notify the payment and after this is accepted by the finance administrator, they will recive an invoice. Staff also will be registed at the system on this way, the Finace adminstrinistrator could check their hours an produce staff payments at the same time that payslisp, P45 and P60.|
|Data| Students usernames and passwords, paymets information as card numbers, adress. Staff usernames and passwords, information por payslips as adress, salary, Nationnal Number Insurance, bank account numbers.|
|Stimulus|Students produces a payment, Finace administrator produce staff payments.|
|Responses|Students get invoices with the confirmation of the payment, staff recives they payments and payslips|
|Comments|To accest to the system it is needed to verifiy  identification via a Two Factor Authentication, Finance administrator have to cheeck the staff hours to very paymets.|

## Sequence diagrams
<div align=center>
<img src="https://user-images.githubusercontent.com/114992140/213960984-1a33c72c-b721-4ba0-bf81-3dd198be2b2b.png"></div>
<div align=center>
<img src="https://user-images.githubusercontent.com/114992140/213960951-fecf8b94-d30e-47ab-822c-b8af7066bc4d.png" alt="drawing" width="500"/>></div>
 <div align=center>
<img src="https://user-images.githubusercontent.com/114992140/213961037-5c076f6a-25b9-4e7d-b6e7-16e29f632707.png"alt="drawing" width="500"/></div>


## Class Diagrams
  *Class diagrams act as the blueprints for your system.They are communly used by business's to show correlations between groups of objects or activitys*


 ![graph 1 class](https://user-images.githubusercontent.com/115148130/213920107-deb60659-2778-4d18-8f1e-24a5e7cefdb0.png)


  ## Activity Diagram
  *An activity diagram is similar to a state diagram in which it shows the flow of a system in less technical term. In an activty diagram you can see where and how errors can be corrected and how each part will work in to the overall system *


 *The activity diagrams for our system can be shown below*       
![graph 2 activity diagram(Admin)](https://user-images.githubusercontent.com/115148130/213920165-9003744e-277c-47f4-8f66-48782c53d737.png)
![graph 2 activity diagram(student)](https://user-images.githubusercontent.com/115148130/213920168-311e156d-a0a7-4227-b1a3-05905659d9d3.png)
![graph 2 activity diagram](https://user-images.githubusercontent.com/115148130/213920170-8370fc5b-36b5-494a-b315-26b09a43755f.png)


## Gantt Chart

![Gantt chart](https://user-images.githubusercontent.com/114992140/214053162-79cb0a52-29eb-4a40-93f8-323f0be35231.jpg)



## State Diagram
  A State Diagram is a diagram used to show the various states of a system, and the relation and criteria to transition between these states.

![graph state diagram](https://github.com/TeachingMaterial/softwareproject_-team_3/blob/phase/2/graph%20state%20diagram.png)

## Gantt Chart

<img src="https://user-images.githubusercontent.com/114992140/214053162-79cb0a52-29eb-4a40-93f8-323f0be35231.jpg">
