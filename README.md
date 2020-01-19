# HackAZ-SafeGuard
This is an app developed by:

* Alex Guha

* Casey Miller

* Kyle Zhou

The webapp can be seen here:
[casey-miller.com](https://casey-miller.com)

The application was developed with:
dotnet core 2.2 using the Jetbrains Rider IDE on Linux

The application is deployed on an Amazon EC2 instance in AWS with a MySQL backend database through Amazon RDS.

The concept behind this application is a app/web-app that a consumer uses during an emergency such as a hurricane or tornado. Ideally when they create an account and use the GetLocation page their current location (latitude and longitude) is fetched from their device and they can select the interval they want to send the data at(looping is future functionality). 

This data is then inserted into the RDS MySQL database and there is a stored procedure that can be called to populate another EMS (Emergency Services) database to fetch distinct usernames, their last location (latitude and longitude) and the latest timestamp (stored as datetime UTC).

Please see the following link for a brief presentation:
[Presentation](https://spark.adobe.com/page/FNbezKOKRGzSw/)
