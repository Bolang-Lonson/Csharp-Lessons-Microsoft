// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Ya mami pima");

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code");

Console.WriteLine(0.25F); // create a float by appending F to the end of the number
Console.WriteLine(2.625);  // without a suffix, c# defaults to a double
Console.WriteLine(12.39816m);  // a value of decimal type

// A verbatim string literal will keep all whitespace and characters without the need to escape the backslash.
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

// Combine verbatim literals and string interpolation
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");