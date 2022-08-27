//Console.WriteLine ("Введите количество элементов Вашего массива: ");
//int N = Convert.ToInt32(Console.ReadLine());
int N = 123;
int [] ar = new int [N];
for (int i = 0; i < N; i++)
{
    ar[i] = new Random().Next(1, 500);
}
Console.Write("Вот произвольные 123 числа (в диапозоне от 1 до 500) из Вашего массива: ");
for (int i = 0; i < N; i++)
{
   Console.Write(ar[i] + " "); 
}
int count = 0;
for (int j = 0; j < N; j++)
{
    if (ar[j]>9 && ar[j]<100) count++;
}
Console.WriteLine("");
Console.Write("Количество чисел, на отрезке [10,99] в Вашем массиве = ");
Console.WriteLine(count);
