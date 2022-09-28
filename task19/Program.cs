/*Задача 19 Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

int GetReverseNumber(int number)
{
    int reverseNumber = 0;
    while(number > 0)
    {
        reverseNumber = (reverseNumber * 10) + (number % 10);
        number = number / 10;
    }  
    return reverseNumber;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 9999 & number < 100000)
{
    if(GetReverseNumber(number) == number) 
    {
    Console.WriteLine("Это палиндром");
    }
    else Console.WriteLine("Это не палиндром");
}
else
{
    Console.WriteLine("Число не пятизначное");
}