# Proxy Design Pattern

This project is the implementation of the Proxy Design Pattern. This design pattern is used for controlling access to an object by acting as an interface to the real object. This design pattern is useful in cases where we want to add a level of control over access to the real object is resource-intensive to use or create.

*Example:* Image Loading.

## Intro to Software Design Pattens

Software design patterns are the solutions to the common problems in software design. These will helps us to write code that is easy to maintain, understand. There are three main types in design patterns:

1. Creational Patterns: Deal with object creation mechanisms.
2. Structural Patterns: Deal with object composition or the structure of the objects.
3. Behavioral Patterns: Deal with object collaboration and responsibility.

## Project Structure

This project conatains three main parts:
1. *Client:* Interacts with the proxy service which manages calls to the real service.
2. *ProxyObject:* Contains the proxy service which controls access to the real service.
3. *RealObject:* Contains the real service and its operations.
4. *UnitTests:* Contains unit tests to verify the behavior of the proxy, client and real services.

### Client

This namespace contains the client code that interacts with the proxy service.

### 
* Program.cs: Main class that takes console input to determine the user type (Admin or User) and performs the appropriate operations through the proxy service.

### ProxyObject

This namespace contains the proxy implementation which controls access to the real service.

### 
* ProxyService.cs: Class implementing the IService interface and controlling access to the RealService.

### RealObject

This namespace contains the actual implementation of the service (RealService) and its operations.

### 
* IService.cs: Interface defining the operations (Operation1 and Operation2).
* RealService.cs: Class implementing the IService interface.

### UnitTest

This namespace contains the unit tests to verify the behavior of the services.

### 
* RealObjectUnitTests.cs: Contains tests for the RealService.
* ProxyObjectUnitTests.cs: Contains tests for the ProxyService.
* ClientUnitTests.cs: Contains tests for the Program class.

## UML class diagram

![Class diagram](https://github.com/Harikak09/ProxyDesignPattern/blob/master/Images/ClassDiagram.jpg?raw=true)

## Design

In the UML class diagram for the Proxy Design Pattern, the ProxyService class implements the same interface as the RealObject to act as a substitute for it. The ProxyService maintains a reference to the RealObject (referred to as realService) and forwards requests to it by invoking methods like realService.operation(). This setup allows ProxyService to control access to RealObject, adding additional functionality such as access control, while still adhering to the interface contract that ensures interchangeable use of ProxyService and RealObject.

## Environment

The project builds and runs on Visual Studio Community 2022.

## Results

#### Admin as user
![Admin User](https://github.com/Harikak09/ProxyDesignPattern/blob/master/Images/Admin.png?raw=true)

#### User as user
![User user](https://github.com/Harikak09/ProxyDesignPattern/blob/master/Images/User.png?raw=true)

## Code Coverage

Client Module is a part of UX so code coverage is not 100%. 
![Code Coverage](https://github.com/Harikak09/ProxyDesignPattern/blob/master/Images/CodeCoverage.png?raw=true)