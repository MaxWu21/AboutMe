The program makes an API call and returns information about me. The API is public and available on www.raw-labs.com because I was having
issues with making the API call locally while hosting the web server on the same port.

Requirements:
* Visual Studio 2022

Instructions:

1. Clone the repository
2. Open PowerShell and change into the AboutMe/Presentation directory
3. Run the command "npm install http-server -g"
4. Run the command "http-server --port 5273" and leave the PowerShell open
5. Open the solution in Visual Studio and run with "http"

Issues:
* The mocked data layer is not working correctly. This is my first C# project and I am not familiar with how to use Simple Injector for constructor injection between the API and a mocked data layer.
* Possible mistakes in defining some of the interfaces
