System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = number % 2;
if (x > 0)
{
    System.Console.WriteLine("Нечетное");
}
else 
{
    System.Console.WriteLine("Четное");
}