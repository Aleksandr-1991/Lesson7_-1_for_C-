Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i < (number + 1))
{
    int result_division = i % 2;
    if (result_division == 0)
    {
        Console.Write(i + ", ");
    }
    i++;
}