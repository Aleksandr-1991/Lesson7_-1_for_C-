Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100==0 || number/1000 != 0)
{Console.WriteLine ("Число не является трёхзначным!");} 
else if (number>0)
{Console.Write (number % 10);}
else {Console.Write ((number % 10)*(-1));}