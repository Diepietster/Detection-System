# Detection-System
**Vehicle number plate detection system**, enter a number plate to see if the vehicle is allowed access, if the vehicle is not allowed access the system sends an email to appropriate users. This application also makes use of OCR to read text from a imported picture, and run it through the database.   
## How to use the program
The user is prompt with a login form, the username and password is both **user**, if the user fails to log in succesfully, an email is sent to appropriate user alerting them that the password authentication failed. The program has two **databases** 
1. One for the users of the program. 
2. Then one for the vehicles, with their security clearance.
After login is successful, the user can search through the vehicles, add vehicles, delete vehicles or use the number plate field to detect wether the vehicle is allowed access or not. 
### Number plate detection
The user has two options to detect wether the vehicle is granted with access or not.
- **Enter text manually into a textbox**
- **Upload an image** 

The system uses a **OCR** object to read the image that is uploaded. If the vehicle has a status of *ALLOWED*, the system displays a message to alert the user the vehicle is granted with access to the premises. If the vehicle has a status of *STOLEN*, the system displays a message to alert the the user that the vehicle is denied access to the premises, and the system sends a appropriate message via email to the user alerting the user that the vehicle is stolen. 
### Demonstration
To view a demonstration of the system please click on this link --> https://youtu.be/WBKaWvyr9-k 

