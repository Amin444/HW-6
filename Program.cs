using System;

namespace Новая_папка
{
    class Program
    {
        static void Main(string[] args)
        {
        //      Console.Write("Введите значение массива:");
        //     int array = int.Parse(Console.ReadLine());
        //     int[] N = new int[array];
        //     int f=0,Max=N[0],Min=N[0],W=0;
        //     System.Console.WriteLine("Общая сумма всех элементов");
        //     for (int i = 0; i < array; i++)
        //     {
        //         N[i]=i+1;
        //         f+=N[i];
        //         Console.WriteLine(f);
        //             W=f/N[i];
        //     }
        //         System.Console.WriteLine("Значение Max and Min");
        //     for (int i = 0; i < array; i++)
        //     {
        //         if(Max<N[i])
        //         {
        //             Max = N[i];
        //         }
        //         if(Min>N[i]){
        //             Min = N[i];
        //         }
               
        //     }
        //     Console.WriteLine(Max);
        //     Console.WriteLine(Min);

        //             System.Console.WriteLine("нечетные значения");
        //      for (int i = 0; i < array; i++)
        //     {
        //        if(N[i]%2!=0)
        //        {
        //            System.Console.WriteLine(N[i]);
        //        }
        //     }
        //         System.Console.WriteLine("Среднее арифметическое");
        //    System.Console.WriteLine(W);

            ///////////////////////////////////////////////////////////////////////////
           
                    // int array=int.Parse(Console.ReadLine());
                    // int[] N=new int[array];
                    // for (int i = array-1; i <= array; i--)
                    // {
                    //     N[i]=i+1;
                    //     System.Console.WriteLine(N[i]);
                    // }
                ////////////////////////////////////////////////////////////////////////
                
              System.Console.Write("Введите число:");
              int num=int.Parse(Console.ReadLine());
              int[] N=new int[num];
              for (int i = 0; i < num; i++)
              {
                   int Random = new Random().Next(0, 999);
                   N[i]=Random;
              }
              foreach (int item in N)
              {
                  System.Console.WriteLine(item);
              }
              System.Console.Write("Введите Index:");
              int Index=int.Parse(Console.ReadLine());
            System.Console.Write("count:");
            int count = int.Parse(Console.ReadLine());
              int[] count1=new int[count];
               int count9 = 0;
              for (int i = Index; i < count + Index; i++)
              {
                       if (i <= N.Length-1)
                {
                    count1[count9] = N[i];
                    count9++;
                }
                else
                {
                    count1[count9] = 1;
                }
              }
              foreach (var item in count1)
            {
                System.Console.WriteLine(item);
            }
          Console.ReadKey();
        }


    }
}

