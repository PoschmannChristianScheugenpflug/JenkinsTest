// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Test");


while(true)
{
    Console.Write("Enter text: ");
    string? s = Console.ReadLine();

    if (s.ToLower() == "exit")
        break;
    Console.WriteLine("Your text: " + s);
}