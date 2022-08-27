Console.WriteLine ("Введите количество элементов Вашего массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] ar = new int [N];
for (int i = 0; i < N; i++)
{
    ar[i] = new Random().Next(1, 21);
}
Console.Write("Вот произвольные числа (в диапозоне от 1 до 20) из Вашего массива: ");
for (int i = 0; i < N; i++)
{
   Console.Write(ar[i] + " "); 
}
int M = 0;
if (N%2==0)
{
    M = N/2;
}
else
{
    M = N/2 + 1;
}
int [] ar1 = new int [M];
int j = 0;
int k = 0;
while (j<M)
{
    ar1[j]=ar[k]*ar[N-(k+1)];
    j++;
    k++;
}
if (N%2!=0) ar1[M-1] = ar [(N-1)/2];
Console.WriteLine("");
Console.Write("Вот произведение пар чисел в Вашем массиве = ");
for (int p = 0; p < M; p++)
{
   Console.Write(ar1[p] + " "); 
}

