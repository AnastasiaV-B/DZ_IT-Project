// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// решение:
// 1. Делаем перебор значений из исходного массива;
// 2. Проверяем: длина строки меньше или равна 3;
// 3. Если строка удовлетворяет условию кладем значение в новый массив;
// 4. Повторяем пункты 2 и 3 до тех пор, пока не достигнем конца исходного массива;
// 5. Возвращаем новый заполненый массив как результат.


using System;
using static System.Console;
Clear();
string[] array = AskArray();
string[] result = FindLessThan(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
string[] FindLessThan(string[] input, int n)
{
    string[] output = new string[CountLessThan(input, n)];
    for(int i = 0, j = 0; i < input.Length; i++)
    {
        if(input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}
int CountLessThan(string[] input, int n)
{
    int count = 0;
    for(int i = 0; i < input.Length; i++)
    {
        if(input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}
string[] AskArray()
{
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}
