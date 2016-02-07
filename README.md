# Grid Search
Technical test for Sigma Seven

## Things that can be improved
As this is a test application there are some good practices that will be an overkill for the current requirements but should be considered in real applications.

**Domain**
* For the sake of simplicity  this application uses the same classes for data access and domain/business logic. In bigger applications this should be avoided as the 2 models might not map 1-to-1 and it generally violates the Single Responsibility Principle.
* Following the previous point, properly separating domain from data access will allow easier unit testing without the need of mocking the database connection.
* When checking for nearby addresses all entries are loaded into memory in order to apply a custom projection method. This allows the nice encapsulation of the `Square.IsInside()` method but sacrifices performance. For bigger datasets loading all of it into memory can be avoided but it would also mean sacrificing OOP design.

**REST API**
* Again, for the sake of simplicity the domain model is used as a response model for the REST API. In real applications ofter the domain model would be different from the one returned to client applications. Libraries like AutoMapper can be used to avoid boilerplate mapping code.
