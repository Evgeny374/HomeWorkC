/* Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее */

Console.Clear();

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе  число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 != number2)
if (number1 > number2)
{
  Console.WriteLine("Первое число больше");  
  Console.WriteLine("Второе число меньше");
}
else
{
  Console.WriteLine("Первое число меньше");  
  Console.WriteLine("Второе число больше");  
}
else
{
  Console.WriteLine("Два числа равны");
}