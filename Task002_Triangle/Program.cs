// Выяснить являются ли три числа сторонами треугольника
Console.Write("Enter the first number: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter the second number: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter the third number: ");
int c = int.Parse(Console.ReadLine() ?? "0");
if(a<(b+c) && b<(a+c) && c<(a+b)) Console.WriteLine($"{a},{b},{c} are sides of the triangle.");
else
{
    Console.WriteLine($"{a},{b},{c} aren't sides of the triangle.");
}