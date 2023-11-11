Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = - number;
while (i < (number + 1))
{
    Console.Write(i + ", ");
    i++;
}