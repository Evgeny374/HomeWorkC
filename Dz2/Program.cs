/* Задача 10. Напишите программу, которая принимает на вход 
трехзначное число и на выходе показывает вторую цифру этого числа.*/

// Console.Write ("Введите трехзначное число: ");
// var number  = Console.ReadLine();
// if (number.Length == 3) 
// {
//     Console.WriteLine(number[1]);
// }
// else 
// {
//     Console.Write ("Введенное число не трехзначное: ");
// }


/*  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что 
третьей цифры нет.*/

// Console.Write ("Введите трехзначное число: ");
// string number  = Console.ReadLine();
// if (number.Length >= 3) 
// {
//     Console.WriteLine(number[2]);
// }
// else 
// {
//     Console.Write ("Третьей цифры в числе нет");
// }


/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/

Console.Write ("Введите номер дня недели: ");
int number  = int.Parse (Console.ReadLine());
if (number == 6 || number  == 7)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}