# PizzaRestotant
This is a template of work in resotourants using mvc fabric and observer patterns. This application contains short animation of cooking and posiability to make an order by click in table column name  

![image](https://github.com/SyperOlao/PizzaRestotant/assets/70114083/c9cba7b3-f2ee-43d7-a21e-2b40fe942a9e)

### The MVC (Model-View-Controller) folder structure typically consists of three main folders:

1. Models: This folder contains all the data models that represent the data and business logic of the application. These models are responsible for interacting with the database and performing CRUD (Create, Read, Update, Delete) operations on the data.

2. Views: This folder contains all the user interface components such as HTML, CSS, and JavaScript files. These files are responsible for rendering the data to the user and handling user interactions.

3. Controllers: This folder contains all the controller files that act as intermediaries between the models and views. The controllers receive requests from the user, retrieve data from the models, and pass that data to the views for rendering.

In addition to these three main folders, there may be other folders such as Config, Helpers, and Middleware that contain configuration files, helper functions, and middleware functions respectively. Overall, the MVC folder structure is designed to promote modularity and separation of concerns in web applications.

### Fabric Pattern:

The Fabric Pattern is a design pattern that provides a way to create objects without specifying the exact class of object that will be created. This pattern is useful when the type of object needed is not known at compile time but rather at runtime.

In the Fabric Pattern, a factory class is used to create objects. The factory class has a method that takes in a parameter which specifies the type of object to be created. Based on the type of object specified, the factory class creates an instance of the appropriate class and returns it to the caller.

The Fabric Pattern promotes loose coupling between classes and allows for easy extension of the codebase. It also simplifies the creation of objects by removing the need for conditional statements to determine the type of object to be created.

### Observer Pattern:

The Observer Pattern is a design pattern that allows an object, called the subject, to notify other objects, called observers, when its state changes. This pattern is useful when multiple objects need to be notified of changes to a single object.

In the Observer Pattern, the subject maintains a list of observers that are interested in its state. When the subject's state changes, it notifies all its observers by calling a method on each observer object.

The Observer Pattern promotes loose coupling between objects and allows for easy extension of the codebase. It also simplifies the implementation of event-driven systems by providing a standardized way for objects to communicate with each other.
