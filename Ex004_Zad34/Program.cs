// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];

FillArray = RandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}
else

    Console.WriteLine($"В массиве {result} четных чисел");