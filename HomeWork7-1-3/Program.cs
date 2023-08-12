Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result_division = number % 2;
if (result_division == 1)
{
    Console.WriteLine("Число является не чётным!");
}
else 
{
    Console.WriteLine("Число является чётным!");
};