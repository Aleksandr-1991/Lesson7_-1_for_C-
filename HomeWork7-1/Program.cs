Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2)
{
    Console.WriteLine("Данные числа равны :-Р");
}
else if (number1 > number2)
{
    Console.WriteLine("Наибольшее из них: " + number1);
}
else
{
    Console.WriteLine("Наибольшее из них: " + number2);
}