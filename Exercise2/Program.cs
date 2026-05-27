int n1, doubl, triple, quadruple;

Console.WriteLine("Enter a number: ");
n1 = int.Parse(Console.ReadLine()!);

doubl = n1 * 2;
triple = n1 * 3;
quadruple = n1 * 4;

Console.WriteLine($"Double is {doubl}");
Console.WriteLine($"Triple is {triple}");
Console.WriteLine($"Quadruple is {quadruple}");