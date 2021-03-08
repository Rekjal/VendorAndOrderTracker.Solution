# Vendor and Order Tracker

##### Date: **03/05/2021**

#### By **_Salim Mayan_**

## Description

#### An MVC app to track various _Vendors_ and _Order (s)_ belonging to those vendors. User will be able to create Vendors and place vendor specific orders as well as see details of order and navigate between different pages. Project demonstrates knowledge of MVC design pattern and related concepts to successfully build web application. 

| **Spec** |

#### Running Tests:

-  To install packages listed in `.csproj` file, from command line navigate to `VendorAndOrderTracker.Tests`  directory and then run  `dotnet restore` (**'obj'** directory would get created in both `VendorAndOrderTracker.Tests`  and  `VendorAndOrderTracker`  directories)

-  To create internal content for build, from command line navigate to `VendorAndOrderTracker.Tests`  directory and then run  `dotnet build` (**'bin'** directory would get created in both `VendorAndOrderTracker.Tests`  and  `VendorAndOrderTracker`  directories)

-  To run MS tests, from command line navigate to `VendorAndOrderTracker.Tests` directory and run `dotnet test`



## Setup/Installation Requirements

1. Clone this repository from GitHub using `git clone https://github.com/Rekjal/VendorAndOrderTracker.Solution`

2. Open directory `VendorAndOrderTracker.Solution` in VS Code

3. Navigate to `./VendorAndOrderTracker` directory and enter `dotnet run`

⚠️  *Note*: To run project locally you need to have .NET Core (confirm running of .NET Core using command `dotnet --version` in command line)

## Known Bugs

* This project is a practice exercise in building web applications with ASP.NET MVC and Razor. Due to lack of Database connectivity, there is no data persistance and hence all data will be deleted as soon as app is closed/refreshed. 
* 
## Improvement opportunities

* Add more styling to UI.
* Improve routing/navigation between pages

## Technologies Used

-   C# 9
-   ASP.NET MVC
-   .NET Core v5.0
-   Razor View Engine
-   RESTful Routing
-   CRUD & HTTP
-   Bootstrap
-   MSTest
-   REPL
-   Git and GitHub

## Support and contact details

_For questions, comments, or concerns *[email author](mailto:mailsalim@gmail.com?subject=[GitHub: Vendor and Order Tracker])*_

### License

*{This software is licensed under the MIT license}*

Copyright (c) 2021 **_{Salim Mayan}_**