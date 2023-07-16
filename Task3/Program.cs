Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    int num = i * i * i;
    Console.Write($"{num}, ");

}
