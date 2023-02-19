//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!); 

string s = num.ToString();
char[] revnum = s.ToCharArray();
Array.Reverse(revnum);
string finalnum = new string(revnum);
if (s == finalnum)
{ Console.Write("Это число является палиндромом"); }
else { Console.Write("Заданное число палиндромом не является"); }