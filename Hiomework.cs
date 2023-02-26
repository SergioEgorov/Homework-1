// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной 
// содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом 
// (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 
// должны быть расположены в разных коммитах)

string[] arrayStart = new string[ ] { "1234", "1567", "-2", "computer science"};
string[] arrayEnd = new string[arrayStart.Length];
int count = 0;
for (int i = 0; i < arrayStart.Length; i++)
{
    if (arrayStart[i].Length <= 3)
    {
        arrayEnd[count] = arrayStart[i];
        count++;
    }
}
Console.WriteLine($"Заданный массив: [{string.Join(", ", arrayStart)}]");
Console.WriteLine($"Полученный массив: [{string.Join(" ", arrayEnd)}]");