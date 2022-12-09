// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] array = new int[100];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число или стоп слово");
    var data = Console.ReadLine();
    int inputdata;
    bool result = int.TryParse(data, out inputdata);
    if (data == "stop")
    {
        break;
    }

    if (result)
    {
        array[i] = inputdata;
    }
    else
    {
        Console.WriteLine("Введено не корректное значение");
        break;
    }
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Положительных чисел - " + count);
