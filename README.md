# LagerverwaltungAufgabe
DISCLAIMER:
As this project is stored in open source storage with big community, all information is given in English.

The application purpose is warehouse goods management.
It uses ASP.NET Core as a backend framework, MS SQL Server as a database, Entity Framework as an ORM and Docker application for deployment.

Data structure of the application is represented as four projects:

1. Lagerverwaltung.DataAccess – Data access layer which contains functionality to operate with data in the database.
2. Lagerverwaltung.Models – stores models of data which application operate with.
3. LagerverwaltungWeb – a startup project which stores application settings and initializes the work of application.
4. UnitTesting – a project that contains a test coverage of application functionality.

To interact with data in unifyed secure way the UnitOfWork pattern is implemented. So all operations with data can be performed via this interface.
Inside the UnitOfWork class we have two repositories which provide basic CRUD operations with two data types: Artikel & Artikelgruppe.

The functionality of DataAccess layer (only Artikelgruppe repo) is covered with Unit tests to allow the security of further development changes

Future propositions to improve the project:
-Implementaion of a buisness layer 
-Implementation of running unit tests
-Extesion of UnitOfWork functionality with other methods regarding operations with data
-Coverage of other parts of DataAccess layer
-Implementation of user interface
