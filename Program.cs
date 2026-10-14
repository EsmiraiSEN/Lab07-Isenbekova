
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
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0) balance[i] = 0;
// }
// foreach (int b in balance)
// {
//     Console.Write(b + " ");
// }
// Console.WriteLine();

// Задание 5 
// int[] numbers = new int[5];
// Console.WriteLine("Введите 5 целых чисел:");
// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Число {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }
// Console.Write("Массив в обратном порядке: ");
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();
// int count = 0;
// foreach (int n in numbers)
// {
//     if (n % 2 == 0) count++;
// }
// Console.WriteLine($"Количество чётных чисел: {count}");

// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };

// Console.Write("Введите имя для поиска: ");
// string vvestiname = Console.ReadLine();

// int foundIndex = -1; 
// int index = 0;       

// foreach (string name in names)
// {
//     if (name == vvestiname)
//     {
//         foundIndex = index;
//         break; 
//     }
//     index++; 
// }

// if (foundIndex != -1)
// {
//     Console.WriteLine($"Имя \"{vvestiname}\" найдено на позиции {foundIndex}");
// }
// else
// {
//     Console.WriteLine("Не найдено");
// }

// Итоговая задача
// int[] grades = new int[8];
// Console.WriteLine("Введите 8 оценок (от 2 до 5):");
// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// Console.Write("Оценки: ");
// foreach (int g in grades) Console.Write(g + " ");
// Console.WriteLine();

// int sum = 0, min = grades[0], max = grades[0];
// int twos = 0, fives = 0;

// foreach (int g in grades)
// {
//     sum += g;
//     if (g < min) min = g;
//     if (g > max) max = g;
//     if (g == 2) twos++;
//     if (g == 5) fives++;
// }

// double crednee = (double)sum / grades.Length;

// Console.WriteLine($"Средняя оценка: {crednee:F2}"); //f2 тут округление
// Console.WriteLine($"Наибольшая: {max}, наименьшая: {min}");
// Console.WriteLine($"Двоек: {twos}, пятёрок: {fives}");

// if (crednee >= 4.5)
//     Console.WriteLine("Отличник");
// else if (crednee >= 3.5)
//     Console.WriteLine("Хорошист");
// else
//     Console.WriteLine("Есть над чем поработать");

// Дополнительное задание
// int[] arr = { 1, 2, 3, 4, 5, 6 };

// Console.Write("До:    ");
// foreach (int x in arr) Console.Write(x + " ");
// Console.WriteLine();

// for (int i = 0; i < arr.Length / 2; i++)
// {
//     int temp = arr[i];
//     arr[i] = arr[arr.Length - 1 - i];
//     arr[arr.Length - 1 - i] = temp;
// }

// Console.Write("После: ");
// foreach (int x in arr) Console.Write(x + " ");
// Console.WriteLine();