// Показать числа Фибоначчи меньше заданного числа N
// f(1)= 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
//

double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int i = 1;
while(Fibonacci(i)<number)
{
    Console.Write(Fibonacci(i));
    Console.WriteLine();
    i++;
}

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine()?? "");

// int firstValue = 0;
// int secondValue = 1;
// int result = 0;
// Console.Write($"{firstValue} {secondValue} ");

// while(firstValue + secondValue < N)
// {
//     result = firstValue + secondValue;
//     Console.Write(result + " ");
//     firstValue = secondValue;
//     secondValue = result;
// }