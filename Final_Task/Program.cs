// Остальные примеры использовал для проверки, можно по одному примеру использовать если убрать комментарий со строк.


string[] arrayFirst = new string[4] {"1234", "1567", "-2", "computer science"};
// string[] arrayFirst = new string[4] {"hello", "2", "world", ":-)"};       
// string[] arrayFirst = new string[3] {"Russia", "Denmark", "Kazan"};         
string[] arraySecond = new string[arrayFirst.Length];
void SecondArray(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    else Console.WriteLine($"Неверная длина > 3 : {arrayFirst[i]}");
    }
}
void PrintArray(string[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    
}


Console.WriteLine("Результат: ");
SecondArray(arrayFirst, arraySecond);
Console.Write("Правильная длина <= 3: ");

PrintArray(arraySecond);


