## Task Allocation Table

|Name| Git Username | Gre username| Task |
|---|---|---|---|
|Juan|jjuanda19|jg8115y|Gantt Chart|
|Juan | jjuanda19 | jg8115y|Login System|
|Warwick|janOliku|wm2109c|Wages payment System|
|Chris|chrisreilly706|cr6314|Payment Fees System|
|Chris|chrisreilly706|cr6314|Student Page|
|Warwick|janOliku|wm2109c|Administrator Page|
|Juan | jjuanda19 | jg8115y|Staff Page|


## Inmplementation
### Login Sytem
<p>The main activity of this system is to provide the login form for the online university application. The code takes the username and password entered by the user and checks if the user is a student, employee or admin. If the login is successful, the code will open the appropriate page for the user.</p>
 The most importan method in this part comes with the login botton that retrieves usernames and passwords entered by users and compares them with the arrays of usernames and passwords for students, staff, and administrators and with the idex. If index is not -1 and the input username equals the username at the index position of of any ot the arrays,the sistem recognize the what is the user(studdent, staff or amindistrator) If the input is correct, the modal opens the appropriate page for the user. <br>If the input is incorrect, the method displays a message box stating that the password is incorrect or the user is not recognized. 

 ### Staff page
<p>The main purpose of this page is to allow the staff to get registered when they start to work and allow them to clock out when they finish. This time it is registered for the use of the administrator to produce payments and payslips.</p>
 <p>The main methods are the link labels which the user will use to a new page where they can cheek their payslips after the administrator has uploaded them and also they will be able to see their P45 and P60 documents when they get generated in the admin system.</p>
<p>On this new page the methods are a dropdown list for selecting the payslip or p45/p60 in the case of the other link label, and a button to find the documents but in this case, as there is nothing generated yet, it will display an error message.</p>

 ## Testing
 For testing the login system, first, it was tried to log in without writing any user and the result is this:

 <img src="https://user-images.githubusercontent.com/114992140/228295813-2fbd19ec-d796-4b67-ad18-d9b7f85dfa11.png">

 Then I was tested with a user not registered:
 
 <img src="https://user-images.githubusercontent.com/114992140/228296189-601b4a68-d51d-4b39-9fc7-484038d44c63.png">

 Now as the user registered but the password is wrong:
 <img src="https://user-images.githubusercontent.com/114992140/228296399-23656ab5-d873-4320-b449-789e8fa47dd8.png">

 And as user register:

 <img src="https://user-images.githubusercontent.com/114992140/228296578-f35db66e-46ba-447a-8184-87cf947f6c94.png">
<p>
After login with a staff user, it takes us to this page:

<img src="https://user-images.githubusercontent.com/114992140/228297123-9cd8e2a3-928b-457e-af8b-cf8314591a41.png">

Where is the user presses clock in, the hour and day is registered:

<img src="https://user-images.githubusercontent.com/114992140/228297273-85a4e812-8627-40b3-a45d-b681ce1bbc40.png">

And after do clock out, it saved and registered the time when the user finished.

<img src="https://user-images.githubusercontent.com/114992140/228297383-690cc841-0ec3-4942-934b-8274c7821ce5.png">

The link to payslips is clicked in it, then will display a page to find out the payslips.

<img src="https://user-images.githubusercontent.com/114992140/228297580-71b5fbb2-57c2-4d05-b9d0-1d9446f6dcd5.png">

When the user chooses the payslip and clicks the button of 'Get payslip' it should receive his payslips or p45, depending on the link.
In this case as the payslips, It has been finished it will display only a message saying that there’s nothing.

<img src="https://user-images.githubusercontent.com/114992140/228297682-65cfbbbe-a7d6-467b-9b2a-b3336c4a9de1.png">

</p>


## Gantt Chart
<img src="https://user-images.githubusercontent.com/114992140/228252248-0254b650-57f4-4708-8fe2-e8b5b82ec1cc.png">

