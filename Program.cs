using MethodsWithLoopsAndConditionals;


//Begain Exercise 3

var p1 = Methods.OneThousand();
Console.WriteLine(p1);

var p2 = Methods.MultiplesOf3();
Console.WriteLine(p2);

Console.WriteLine("Enter two nmbers to check if theyre equal");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
var p3 = Methods.ToF(a, b);

if (p3 == true)
{
    Console.WriteLine($"{a} is equal to {b}");
}
else
{
    Console.WriteLine($"{a} is not equal to {b}");
}

Console.WriteLine("Enter a Number to check if it is odd or even:");

var num1 = int.Parse(Console.ReadLine());
var p4 = Methods.IsItEven(num1);

Console.WriteLine("Enter a number to check if it is positive or negitive");

int num2 = int.Parse(Console.ReadLine());
var p5 = Methods.IsItPositive(num2);

Console.WriteLine("Please enter your age to see if you're \n" +
    "old enough to vote");


int num3 = int.Parse(Console.ReadLine());
var p6 = Methods.AreTheyLegal(num3);

Console.WriteLine("please enter a number between -10 and 10 \n" +
    "to check if it is range... of -10 and 10");

int num4 = int.Parse(Console.ReadLine());
var p7 = Methods.InRange(num4);

Console.WriteLine("Enter a number to see its multiplication table from 0 - 12");

int num5 = int.Parse(Console.ReadLine());
var p8 = Methods.MultiplicationTable(num5);










