Pratik13-Encapsulation
This project demonstrates the use of Encapsulation in C#. It involves defining a Car class with private fields and public properties to control access and validation. Encapsulation ensures that the internal state of the object is protected and only modified through controlled access.

Project Overview
Car Class
The Car class encapsulates the following properties and behaviors:

Private Fields
_marka: The car's brand.
_model: The car's model.
_color: The car's color.
_numberDoors: The number of doors.
Public Properties
NumberDoors:
Validates that the number of doors is either 2 or 4.
Prints an error message if an invalid value is assigned.
Does not update the field when an invalid value is provided.
Constructor
Parameterized Constructor:
Accepts marka, model, color, and numberDoors as arguments.
Initializes the private fields with the provided values.
Methods
DisplayCar():
Prints the car's details, including its brand, model, color, and the number of doors.
Program
The Program class demonstrates the usage of the Car class:

Creates a Car object with valid initial values.
Attempts to set an invalid value for the number of doors and prints an error message.
Updates the number of doors with a valid value and prints the updated details.

Key Concepts
Encapsulation:
Private fields protect the internal state.
Public properties control access and validation.
Validation:
Ensures that only valid data is assigned to the NumberDoors property.
Constructor:
Simplifies object initialization with required parameters.
Method:
DisplayCar() provides a way to display the object's current state.
