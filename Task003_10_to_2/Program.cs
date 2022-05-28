//Написать программу преобразования десятичного числа в двоичное
Console.Write("Enter the decimal number: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 0;
string result = " ";
while(a>0)
{
    b=a%2;
    result = b+result;
    a=a/2;
}
Console.Write(result);