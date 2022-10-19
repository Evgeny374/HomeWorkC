
Console.Clear();


/* Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее */

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе  число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 != number2)
// if (number1 > number2)
// {
//   Console.WriteLine("Первое число больше");  
//   Console.WriteLine("Второе число меньше");
// }
// else
// {
//   Console.WriteLine("Первое число меньше");  
//   Console.WriteLine("Второе число больше");  
// }
// else
// {
//   Console.WriteLine("Два числа равны");
// }

/* Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное
из этих чисел. */

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// if (number1 > number2)
// {
//     max = number1;
// }
// else
// {
//     max = number2; 
// }
// if (max > number3)
// {
//     max = max;
// }
// else
// {
//     max = number3; 
// }
// Console.WriteLine("Максимальное число: " + max);


/* Задача 6. Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка). */

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number%2 == 0)
// {
//    Console.WriteLine("Четное "); 
// }
// else
// {
//    Console.WriteLine("Не четное "); 
// }


/* Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все чётные числа от 1 до N. */

Console.Write ("Введите число: ");
int MaxNum = Convert.ToInt32(Console.ReadLine());
int num = 1;
if (MaxNum >= 0)
{
Console.Write ("Положительные четные числа до " + MaxNum + " это: ");
while (num <= MaxNum)
    {
    if (num %2 == 0)
    {
        Console.Write (num + " ");
    }
    num +=1;
    }
}
else
{
    Console.Write ("Отрицательные четные числа до " + MaxNum + " это: ");    
    num = -1;
  while (num >= MaxNum)
    {
    if (num %2 == 0)
    {
        Console.Write (num + " ");
    }
    num -=1;  
    }
}