//Написать программу преобразования десятичного числа в двоичное
Console.Write("Enter the decimal number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int bit = 0;
int result = 0;
int i = 1;
while(number>0)
{
    bit=number%2;
    number = number/2;
    result = result + bit * i;
    i = i*10;
}
Console.Write(result);

/*Перевести число в двоичное
Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int Bit = Number % 2;
int NewNumber = Bit;
Number = Number / 2;
int i = 1;
while (Number > 0)
{
Bit = Number % 2;
Number = Number / 2;
NewNumber = NewNumber + Bit * (int)Math.Pow(10,i);
i++;
}
Console.WriteLine(NewNumber);*/