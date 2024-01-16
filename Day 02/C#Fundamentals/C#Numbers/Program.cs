int a = 10;
int b = 20;
Console.WriteLine("Numeric Datatypes\n");
Console.WriteLine("Sum of the two numbers are: "+ (a + b));
Console.WriteLine("Subtraction of the two numbers are: " + (b - a));
Console.WriteLine("Mutliplication of the two numbers are: " + (b * a));
Console.WriteLine("Division of the two numbers are: " + (b / a));

int result = b + a - (b - a) * (b * a) / b;
Console.WriteLine("Using BODMAS function in given numbers: "+result);
Console.WriteLine();
int c = (a + b) / a;
int d = (b + a) % a;
Console.WriteLine($"Quotient: {c}");
Console.WriteLine($"Remainder: {c}");

Console.WriteLine();
Console.WriteLine("Sizes of the Datatype");
Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
Console.WriteLine("Size of bool: " + sizeof(bool) + " bytes");
Console.WriteLine("Size of byte: " + sizeof(byte) + " bytes");
Console.WriteLine("Size of long: " + sizeof(long) + " bytes");
Console.WriteLine("Size of short: " + sizeof(short) + " bytes");
Console.WriteLine("Size of decimal: " + sizeof(decimal) + " bytes");

Console.WriteLine();

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers are form {min} and {max}!");

int radius = 3;
Console.WriteLine("circumference of the cicle is: "+ (2 * Math.PI * (radius * radius)));

