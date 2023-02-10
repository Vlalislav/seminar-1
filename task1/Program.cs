// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3, b = 9 -> нет
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница
Console.WriteLine("Введите число a ");

string answerA = Console.ReadLine();
int a = Convert.ToInt32(answerA); 

Console.WriteLine("Введите число b ");

string answerB = Console.ReadLine();
int b = Convert.ToInt32(answerB); 

if (a == (b * b))
{
    Console.WriteLine("ДА");
}
else Console.WriteLine("НЕТ");

Console.WriteLine("Начало второй задачи");

Console.WriteLine("Введите число  ");

string answer = Console.ReadLine();
int number = Convert.ToInt32(answer); 

if (number == 1){Console.WriteLine("Понедельник");}
if (number == 2){Console.WriteLine("Вторник");}
if (number == 3){Console.WriteLine("Среда");}
if (number == 4){Console.WriteLine("Четверг");}
if (number == 5){Console.WriteLine("Пятница");}
if (number == 6){Console.WriteLine("Суббота");}
if (number == 7){Console.WriteLine("Воскресение");}
if (number > 7){Console.WriteLine("НЕТ ТАКОГО ДНЯ НЕДЕЛИ");}
if (number < 1){Console.WriteLine("НЕТ ТАКОГО ДНЯ НЕДЕЛИ");}

Console.WriteLine("start third task");
Console.Write("Input number: ");
string daysString = Console.ReadLine();
int numberDay = Convert.ToInt32(daysString);
string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine(days[numberDay-1]);