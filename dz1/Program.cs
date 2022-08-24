// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// 1, -7, 567, 89, 223-> 4

Console.Write(value: "Введи элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Кол-во элементов >: {count}");