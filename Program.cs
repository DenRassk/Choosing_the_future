// Решение итогового задания курса Выбор специализации


// запрос количества вводимых строк
Console.Write("Укажите сколько строк будет введено - ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 0)
{
    string[] array = InitArrray(number);
    Console.WriteLine("Вы ввели следующие строки:");
    ViewArray(array);
    SeachArray(array);
} 
else {Console.WriteLine("Введите целое число больше нуля!");}

// организуем ввод строк в массив
string[] InitArrray(int number)
{
    string[] newArray = new string[number];
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите текст в {i+1} строку - ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}


// выводим содержимое получившегося массива на экран
void ViewArray (string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} \t");
    }
    Console.WriteLine("");
}

// ищем и выводим строки длинной короче 4х символов
void SeachArray(string[] firstArray)
{
    int n = 0; // если останется равно нулю, значит ни чего не нашлось
    Console.WriteLine("Выводим строки длиннее 3х симолов:");
    for (int i = 0; i < firstArray.GetLength(0); i++)
    {
        if (firstArray[i].Length < 4 )
        {
            Console.Write($"{firstArray[i]} \t");
            n ++;
        }
    
    }  
    if (n == 0) {Console.WriteLine("строк длиннее 3х символов - НЕТ!");} //строк короче 4х символов нет
}