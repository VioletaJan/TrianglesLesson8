// Triangle Practical 6, lesson 8

/*
 * Write a program that defines triangle type based on user input.

●      Create three numerical variables (triangle sides) with some initial values

●      Write conditions using logical AND OR NOT operations to display message

if all sides are equal that triangle is 'isosceles triangle'

if two of tree sides are equal that triangle is 'equilateral triangle'

if all sides are different - 'scalene triangle'

if sum of two sides is smaller than third side - 'triangle don't exist'

●      * Please change the program adding the possibility to write the sizes of sides in the console. 


 */


Console.WriteLine("Please enter the first lenth of the triangle.");
int.TryParse(Console.ReadLine(), out var firstTriangle);

Console.WriteLine("Please enter the second lenth of the triangle.");
int.TryParse(Console.ReadLine(), out var secondTriangle);

Console.WriteLine("Please enter the third lenth of the triangle.");
int.TryParse(Console.ReadLine(), out var thirdTriangle);


var sumOne = firstTriangle + secondTriangle;
var sumTwo = firstTriangle + thirdTriangle;
var sumThree = secondTriangle + thirdTriangle;


if (firstTriangle == secondTriangle && thirdTriangle== secondTriangle && firstTriangle==thirdTriangle)
{
    Console.WriteLine("This is a isosceles triangle.");
}

else if (firstTriangle==secondTriangle || secondTriangle==thirdTriangle || firstTriangle == thirdTriangle)
{
    Console.WriteLine("This is a equilateral triangle.");
}

else if (sumOne < thirdTriangle || sumTwo < secondTriangle || sumThree < firstTriangle)
{
    Console.WriteLine("This kind of triangle does not exist.");
}
else
{
    Console.WriteLine("This is a scalene triangle.");
}