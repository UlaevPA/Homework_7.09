// 1)Пользователь вводит с клавиатуры M чисел. 2)Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3





Console.Write("Введите количество элементов массива: \t");
int elemQuant = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[elemQuant];

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:  ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Вывод массива: ");


for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]}, ");
}

int count = 0;
 
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Кол-во элементов > 0: {count}");