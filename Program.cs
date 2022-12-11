//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int AverageNumber(int num)
{
    int sot = num / 10;
    int ed = sot % 10;
    return ed;
}


Console.WriteLine("Enter a three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
int ResultNumber = AverageNumber(number);
Console.WriteLine($"First number: {number} Resolt number: {ResultNumber}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int AverageNumber(int num)
{
    int EdNum = num % 10;
    
    return EdNum;
}

Console.WriteLine("Enter number");

string Number = Console.ReadLine();

int IntNumber = Convert.ToInt32(Number);

int Checknum = IntNumber / 100;

Console.WriteLine(Number);

if(Checknum == 0)
{
    Console.WriteLine("Такого числа нет!");
}
if(Checknum > 0)
{
    string NewNumber = Number.Substring(0,3);
    
    int IntermediateNumber = Convert.ToInt32(NewNumber);
    
    int ResultNumber = AverageNumber(IntermediateNumber);
    
    Console.WriteLine($"Искомое число: {ResultNumber}");
}
*/
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
string Checknum(int num)
{
    if(num > 0 && num < 6)
    {
        return $"День недели под номером: {num} рабочий!";
    }
    else if(num > 5 && num < 8)
    {
        return $"День недели под номером: {num} выходной!!!";
    }
    else
    {
        return $"Дня недели под номером: {num} не существует!";
    }
}

Console.WriteLine("Введите номер дня недели");

int Day = Convert.ToInt32(Console.ReadLine());

string WeekDay = Checknum(Day);

Console.WriteLine(WeekDay);
*/