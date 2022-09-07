//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
string stringNumber = Convert.ToString(num);                     
//Console.Write($"{stringNumber[2]}");
if (num > 9999 && num < 100000)
{
if  (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])
{
Console.WriteLine("Введённое Вами число является палиндромом");
}
else
{
Console.WriteLine("Введённое Вами число НЕ является палиндромом");
}
}
else
{
Console.WriteLine("Введённое Вами число НЕ является пятизначным");
}


// 1 2 8 2 1
// 0 1 2 3 4 индекс

