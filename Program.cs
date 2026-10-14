
// Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

// for (int i = days.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

// Задание 1.2
// double[] temps = { -5.5, -3.0, 0.5, 3.5, 7.8, 10.1, 4.4 };
// foreach (double t in temps)
// {
// Console.Write(t + " ");
// }
// Console.WriteLine();

// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int countOver100 = 0;
// foreach (int p in prices)
// {
// sum += p;
// if (p > 100) countOver100++;
// }
// double res = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}");
// Console.WriteLine($"Средняя цена: {res}");
// Console.WriteLine($"Товаров дороже 100: {countOver100}"); 

// Задание 3
// int min = prices[0];
// int maxIndex = 0;
// for (int i = 1; i < prices.Length; i++)
// {
// if (prices[i] < min) min = prices[i];
// if (prices[i] > prices[maxIndex]) maxIndex = i;
// }
// Console.WriteLine($"Минимальная цена: {min}");
// Console.WriteLine($"Индекс самого дорогого товара: {maxIndex}");  

// Задание 4
int[] balance = { 100, -50, 20, -5, 0, 75 };
for (int i = 0; i < balance.Length; i++)
{
    if (balance[i] < 0) balance[i] = 0;
}
foreach (int b in balance)
{
    Console.Write(b + " ");
}
Console.WriteLine;

// Задание 5 
