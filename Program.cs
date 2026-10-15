//Задание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
// for (int i = 6; i < days.Length; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }

//Задание 1.2
// double[] temps = { 16, 12, 9, -8, 0, 23, -3 };
// foreach (double i in temps) {
//         Console.Write(i + " ");
//     }

//Задание 2
// int sum = 0;
// int expensive = 0;
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// for (int i = 0; i < prices.Length; i++) {
//     sum += prices[i];
//     if (prices[i] > 100) {
//         expensive++;
//     }
// }
// Console.WriteLine($"общая сумма цен: {sum}");
// Console.WriteLine($"средняя цена: {sum / prices.Length}");
// Console.WriteLine($"количество товаров дороже 100: {expensive}");

//Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int minim = prices[0];
// int expensive = prices[0];
// int expIndex = 0;
// for (int i = 0; i < prices.Length; i++) {
//     if (prices[i] < minim) {
//         minim = prices[i];
//     }
//     if (prices[i] > expensive) {
//         expensive = prices[i];
//         expIndex = i;
//     }
// }
// Console.WriteLine($"минимальная цена: {minim}");
// Console.WriteLine($"индекс самого дорогого товара: {expIndex}");

//Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++) {
//     if (balance[i] < 0) {
//         balance[i] = 0;
//     }
// }
// foreach (int i in balance) {
//          Console.Write(i + " ");
//      }

//Задание 5
// int[] num = new int[5];
// for (int i = 0; i < num.Length; i++)
// {
//     Console.Write("Введите число: ");
//     int n = int.Parse(Console.ReadLine());
//     num[i] = n;
// }
// for (int i = 4; i >= 0; i--)
// {
//         Console.Write(num[i] + " ");
// }

//Задание 6
// string[] names = { "Анна", "Игорь",
// "Мария", "Олег", "Ольга" };
// bool flag = false;
// Console.Write("Введите имя: ");
// string n = Console.ReadLine();
// for (int i = 0; i < names.Length; i++) {
//     if (n == names[i]) {
//         Console.Write($"позиция в массиве: {i}");
//         flag = true;
//     }
// }
// if (flag == false) {
//         Console.Write("Не найдено");
// }