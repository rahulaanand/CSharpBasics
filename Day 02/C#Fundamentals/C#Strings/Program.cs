//Basics of Strings
string name = "Rahul";
Console.WriteLine(name);

//using input
Console.WriteLine("Enter the Project Team:");
string project = Console.ReadLine();

Console.WriteLine("\n");
//using Concat
Console.WriteLine("Welcome to " + project + " Team -- using concatenation");

//using string interpolation
Console.WriteLine($"Welcome to {project} Team -- using interpolation");

//length returns number of character
Console.WriteLine($"The length of Project {project} has {project.Length} letters in it -- using length function");

string greeting = "     Good Morning..!     ";

Console.WriteLine("\n");
Console.WriteLine(greeting + "Input given");

//trimstart
string trimmedgreetingstart = greeting.TrimStart();
Console.WriteLine( trimmedgreetingstart + "Using Start trim");

//trimend
string trimmmedgreetingend = greeting.TrimEnd();
Console.WriteLine( trimmmedgreetingend + "Using End trim");

Console.WriteLine("\n");
//trim
string trimmedstring = greeting.Trim();
Console.WriteLine( trimmedstring + "Using Trim function here");

string welcome = "Hello, Welcome";
Console.WriteLine(welcome + "-- Assigned");

//using replace function
welcome = welcome.Replace("Welcome", "Welcome again");
Console.WriteLine(welcome + " -- Replaced word");

Console.WriteLine("\n");
//ToLower adn ToUpper function
Console.WriteLine(welcome.ToLower() + " -- ToLower function");
Console.WriteLine(welcome.ToUpper() + " -- ToUpper function");

Console.WriteLine("\n");
//Searching strings
string songlyrics = "Beggin' on her knees to be popular\nThat's her dream, to be popular \n\t -- The Weeknd";
Console.WriteLine(songlyrics);
Console.WriteLine(songlyrics.Contains("popular"));
Console.WriteLine(songlyrics.Contains("Weekend"));
Console.WriteLine(songlyrics.StartsWith("Beggin'"));



