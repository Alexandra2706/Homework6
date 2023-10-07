// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int EnterNumber(string msg)
{
    Console.Write(msg);
    if (!int.TryParse(Console.ReadLine(), out var number))
    {
        Console.Write("Ошибка ввода!");
        Environment.Exit(0);
    }
    return number;
}

int CountPositiveNumbers(int[] array_numbers)
{
    int sum_positive = 0;
    for (int i = 0; i < array_numbers.Length; i++)
    {
        if (array_numbers[i] > 0) sum_positive++;
    }
    return sum_positive;
}


int amount_numbers = EnterNumber("Введите количество чисел: ");
if (amount_numbers <= 0)
{
    Console.Write("Количество чисел должно быть больше 0!");
    Environment.Exit(0);
}
int[] numbers_arr = new int[amount_numbers];
for (int i = 0; i < amount_numbers; i++)
{
    numbers_arr[i] = EnterNumber($"Введите {i + 1} число: ");
}

Console.Write($"Количество положительных чисел = {CountPositiveNumbers(numbers_arr)}");