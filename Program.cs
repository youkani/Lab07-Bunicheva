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

//Итоговая задача. «Журнал оценок»
// int[] grades = {4,5,3,2,5,4,3,4};
// double sum = 0;
// int mini = grades[0];
// int maxi = grades[0];
// int countMin = 0;
// int countMax = 0;
// foreach (int i in grades) {
//     Console.Write(i + " ");
//     sum += i;
//     if (mini > i) {
//         mini = i;
//     }
//     else if (maxi < i) {
//         maxi = i;
//     }
//     if (i == 2) {
//         countMin++;
//     }
//     else if (i == 5) {
//         countMax++;
//     }
// }
// double sred = sum / grades.Length;
// Console.Write($"Средняя оценка: {sred}\n");
// Console.Write($"Наименьшая оценка: {mini}\n");
// Console.Write($"Наибольшая оценка: {maxi}\n");
// Console.Write($"Количество двоек: {countMin}\n");
// Console.Write($"Количество пятёрок: {countMax}\n");
// if (sred >= 4.5) {
//     Console.Write("Отличник");
// } else if (sred >= 3.5) {
//     Console.Write("Хорошист");
// } else {
//     Console.Write("Есть над чем поработать");
// }

//Дополнительное задание ★★★
int[] arr = { 1, 2, 3, 4, 5, 6 };

for (int i = 0; i < 3; i++)
{
    int vrem = arr[i];

    int j = 5 - i;

    arr[i] = arr[j];
    arr[j] = vrem;
}
foreach (int i in arr) {
          Console.Write(i + " ");
      }
