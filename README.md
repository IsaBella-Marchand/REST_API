Here are the steps to run the Rocket Elevator Rest Api:

Start you debugger in Visual Studio Code.
Open Postman
Postman Collection:  See Isabelle Marchand to have the link.

1.Returns all fields of all Service Request records that do not have a start date and are in "Pending" status.
Select the first option(GET) and click Send(Blue button on the right corner).  You will get all the information about the Pending interventions.

Ex: 
https://yourapiurlname.azurewebsites.net/api/interventions/pending←

2. Change the status of the intervention request to "InProgress" and add a start date and time (Timestamp).  Select GET and modify "pending" for the intervention id. Click SEND button. Copy the body part of the response and paste it in the body part of the request section (selection Raw and JSON). Switch the request from GET to PUT. Change status to "InProgress" and put "{{current_timestamp}}" at the start_at field. Then click the SEND button.  Once you sent the request, switch the request once again for GET and send the request.  You should be able to see that the status and the start_at have now been changed.

Ex:
https://yourapiurlname.azurewebsites.net/api/interventions/1←

3. Change the status of the request for action to "Completed" and add an end date and time (Timestamp).Select GET and modify "pending" for the intervention id. Click SEND button. Copy the body part of the response and paste it in the body part of the request section (selection Raw and JSON). Switch the request from GET to PUT. Change status to "Complete" and put "{{current_timestamp}}" at the end_at field. Then click the SEND button.  Once you sent the request, switch the request once again for GET and send the request.  You should be able to see that the status and the end_at have now been changed.

Ex:
https://yourapiurlname.azurewebsites.net/api/interventions/1←
