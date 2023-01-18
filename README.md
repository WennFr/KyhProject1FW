# KyhProject1FW
Description: This is a three-part project that contains a shape-creator, calculator and rock paper scissors game. The user results of the applications are stored in a relational database using EntityFramework code first. The project contains CRUD funcionalites for the shape-creator and calcualator that allows the user to create results, view, edit and delete any registered results. For the game, users can create new game results and view previous results. 

The solution contains 4 projects and a class library. MainMenuApp is the startup project wich contains the applications main menu. From there, users can navigate to the other project applications named ShapeApp, CalculatorApp and GameApp. The class library, named ServiceLibrary, is responsible for code that is used by all applications, including Data classes for EF, Shared Interfaces and General Services. 

KyhProject1FW implements OOP as it's main principle. Classes and class methods are the cornerstone of the program's structure. Other techniques used are dependency injection and strategy pattern. One of the key components of KyhProject1FW is to avoid tight coupling and dependency on concretions across the entire application. For this purpose, the application is heavily reliant on interfaces and dependency injection. This enables the program to use relevant class methods without tight coupling, which also contributes to good maintainability for future changes.  

