//Горлачев базовый уровень 
Console.WriteLine("Введите число N: ");
double N = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число X: ");
double X = double.Parse(Console.ReadLine());
double sum = 0;
for (int i = 0; i < N; i++)
{
    sum = -1 * N * X * 2 * N + 1 / (2 * N + 1);
}
Console.WriteLine("sum: " + sum);
