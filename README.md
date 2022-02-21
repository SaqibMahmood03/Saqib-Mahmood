# Saqib Mahmood
 Firstly i used a command which was dotnet new webapp -o RazorPagesCollege
 After that i used code -r RazorPagesCollege command
 Then i Trusted the HTTPS development certificate by running the dotnet dev-certs https --trust command
Then i added a Model
in that model i Added NuGet packages and EF tools
after adding this so many folders and files were created in which i added a folder named Models and in that i added a file calleed College.cs
For scaffolding my College model i used dotnet-aspnet-codegenerator razorpage -m College -dc RazorPagesCollegeContext -udl -outDir Pages/Colleges  --referenceScriptLibraries -sqlite command which created five folders 'Create, Delete, Details, Edit, and Index'.
One data folder is also created with this command in which RazorPagesCollegeContext.cs file is created.
then i used 'dotnet ef migrations add InitialCreate' 'dotnet ef database update' commands to update my Database.
Then i tested my app.
After testing i scaffolded my razor pages and College context ang done some work on my layout files.
Then i added on get method which initializes any state needed for the page.
If there is no error then our data is saved and browser is redirected to index page.
Then i updated my pages and added search bar.
After that my assignment is finished.


