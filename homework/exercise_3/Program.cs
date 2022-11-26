// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



<<<<<<< HEAD



int [] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}
int[] array = GetArray(8);

Console.WriteLine(String.Join(" ",array));
=======
int[] a = Enumerable.Range(1, 8).Select(x => 17 % x).ToArray(); 
foreach (int i in a)
  Console.WriteLine(i);
>>>>>>> 9b03bb345d503d57d4d6aa0f276fb3bc68a74410
