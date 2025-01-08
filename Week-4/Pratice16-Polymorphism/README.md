Practice16: Polymorphism in Geometric Shapes

This project demonstrates the use of polymorphism in object-oriented programming through the implementation of various geometric shapes. Each shape calculates its area using a common base class and overrides the behavior where necessary.

Features

Base Class: BaseGeometricShape defines common properties and methods for geometric shapes.

Derived Classes:

Square: Calculates the area of a square.

Rectangle: Calculates the area of a rectangle.

RightTriangle: Calculates the area of a right triangle.

Polymorphism: Each shape overrides the base class's method to implement its specific area calculation logic.

Classes Overview

BaseGeometricShape

Properties:

Width: The width of the shape.

Height: The height of the shape.

Methods:

AreaCalculation(): Calculates the area using Width and Height.

Square

Inherits from BaseGeometricShape.

Overrides AreaCalculation() to calculate the area of a square.

Rectangle

Inherits from BaseGeometricShape.

Overrides AreaCalculation() to calculate the area of a rectangle.

RightTriangle

Inherits from BaseGeometricShape.

Overrides AreaCalculation() to calculate the area of a right triangle as (Width * Height) / 2.

Usage

Main Program

using System;
using Pratice16;

namespace Pratice16Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rectangle area calculation
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 10;
            rectangle.AreaCalculation(); // Output: Area = 50

            // Square area calculation
            Square square = new Square();
            square.Width = 4;
            square.Height = 4;
            square.AreaCalculation(); // Output: Area = 16

            // Right triangle area calculation
            RightTriangle rightTriangle = new RightTriangle();
            rightTriangle.Width = 6;
            rightTriangle.Height = 8;
            rightTriangle.AreaCalculation(); // Output: Area = 24
        }
    }
}

Output Example

Area = 50
Area = 16
Area = 24

How to Run

Clone the repository.

Open the project in your preferred IDE (e.g., Visual Studio).

Build and run the project.

Key Concepts

Inheritance: Derived classes inherit common properties and methods from the base class.

Polymorphism: Derived classes override the base class's methods to provide specific implementations.

Encapsulation: Properties like Width and Height are encapsulated within the class and used for calculations.

Author

This project is created as part of the Practice16 exercise to demonstrate polymorphism in C#.
