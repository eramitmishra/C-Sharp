#Welcome to Csharp Tutorial. 

----------

> Here I am using Visual Code for C
> **Some following Steps are Important for running C# code in Visual Code IDE**


 **Steps** 
 - Install [.NET Core](https://www.microsoft.com/net/core#windowscmd).
 - Install the  [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) from the VS Code Marketplace.
 - ref [Vedio](https://channel9.msdn.com/Blogs/dotnet/Get-started-with-VS-Code-using-CSharp-and-NET-Core)
 ----------
 **If you'd like to get started with a simple "Hello World" program on .NET Core, follow the steps below:**
 
  1. Initialize a C# project:
 - Open the command prompt (or terminal).
 - Navigate to the folder where you'd like to create the C# project.
 - Type dotnet new.
 - This creates a Program.cs file in your folder with a simple "Hello World" program already written.
 
 2. Resolve the build assets by typing dotnet restore.
 >Tip: If you are using the MSBuild-based .NET Core Tools, a .csproj project file will be created instead of a project.json, but the dotnet commands remain the same. .
 - Running restore pulls down the required packages declared in the project.json file.
 - You'll see a new project.lock.json file in your project folder.
 - This file contains information about your project's dependencies to make subsequent restores quicker.
 - There will be a notification that appears at the top of the window asking if you'd like to add the required assets to build and debug your project. Select Yes.
 
 3. Run the "Hello World" program by typing dotnet run.   
 

 **Important command for create and run**
 
  #### Let's initialize a sample Hello World application!

  ```command
  - mkdir hwapp
  - cd hwapp
  - dotnet new  
  ```
 
----------

## Run the app
  ```command
  - dotnet restore
  - dotnet run
  ```

 

 These are Important point or steps we must follow.

 Happy and enjoy Coding.......