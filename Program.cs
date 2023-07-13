/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

int CutNumber(int cutnum)
{
    int hundreds = cutnum/100;
    int units = cutnum%10;
    int result = (cutnum-((hundreds*100)+units))/10;
    return result;
}

int randNumber=new Random().Next(100,1000);
int newNumber= CutNumber(randNumber);
Console.WriteLine($"New version of {randNumber} is {newNumber}");
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
*/
/*
int Prompt(string message)
{
    Console.WriteLine(message);
    string value=Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThidRank(int number)
{
    while (number > 999)
    {
        number=number/10;
    }
    return number%10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("The third rank is empty");
        return false;
    }
    return true;
}

int number = Prompt("Введите число> ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThidRank(number));
}
*/

/*
//Задача 15: Напишите программу, которая принимает на 
вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.
*/

bool Weekendnum(int day)
{
    if (day < 6) return false;
    else return true;
}

Console.Write("Input number of a day: ");
string daynum=Console.ReadLine();
int statday=Convert.ToInt32(daynum);
Console.WriteLine(Weekendnum(statday));

