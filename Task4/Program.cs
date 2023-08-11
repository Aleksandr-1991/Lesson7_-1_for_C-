Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0 - number;
while (i < (number + 1))
{
    Console.Write(i + ", ");
    i++;
}