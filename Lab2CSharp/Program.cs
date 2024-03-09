using System.Security;

namespace Lab2CSharp
{
    internal class Program
    {
        static void task1()
        {
            /*
            Зауваження. 
            Завдання з масивами вирішити двома способами, використовуючи одновимірний масив, а потім двовимірний. 
            Розмірність масиву вводиться з клавіатури.

            Завдання 1. Варіанти задач. Задано масив. 
                1.1. Замінити всі елементи, менші заданого числа, цим числом.
            */
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter m: ");
            int m = int.Parse(Console.ReadLine());

            int[] Arr1 = new int[n];
            int[,] Arr2 = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}][0]: ", i);
                Arr1[i] = int.Parse(Console.ReadLine());
                Arr2[i, 0] = Arr1[i];
                for (int j = 1; j < m; j++)
                {
                    Console.Write("Arr[{0}][{1}]: ", i, j);
                    Arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++) 
            {
                if (Arr1[i] < number)
                {
                    Arr1[i] = number;
                }

                for(int j = 0; j < m; j++)
                {
                    if (Arr2[i, j] < number)
                    {
                        Arr2[i, j] = number;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Arr1[{0}]: {1}", i, Arr1[i]);
            }
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine("Arr2[{0}][{1}]: {2}", i, j, Arr2[i, j]);
                }
            }
        }
        static void task2()
        {
            /*
             Зауваження. При вирішенні завдання використовувати одновимірний масив. 
            Розмірність масиву вводиться з клавіатури.

            Завдання 2. Варіанти задач. Дана послідовність з n дійсних чисел.
            2.1. Вивести на екран номери всіх мінімальних елементів.
            */

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            double[] Arr1 = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}]: ", i);
                Arr1[i] = double.Parse(Console.ReadLine());
            }

            List<int> minIndexs = new List<int>();
            minIndexs.Add(0);
            double currentMin = Arr1[0];

            for (int i = 0; i < n; i++)
            {
                if (Arr1[i] < currentMin)
                {
                    minIndexs.Clear();
                    minIndexs.Add(i);
                    currentMin = Arr1[i];
                }
                else if (Arr1[i] == currentMin)
                {
                    minIndexs.Add(i);
                }
            }

            for(int i = 0; i < minIndexs.Count(); i++)
            {
                Console.Write("{0}   ", minIndexs.ElementAt(i));
            }
        }
        static void task3()
        {
            /*
            Зауваження. При вирішенні завдання використовувати двовимірний масив.

            Завдання 3. Варіанти задач. Дано масив розміром n×n, елементи якого цілі числа.
            3.1. Підрахувати середнє арифметичне парних елементів, 
            розташованих нижче головної діагоналі.  
            */

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] Arr2 = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Arr[{0}][{1}]: ", i, j);
                    Arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int Sum = 0;
            int evenCounter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Arr2[i, j] % 2 == 0)
                    {
                        Sum += Arr2[i, j];
                        evenCounter++;
                    }
                }
            }

            Console.Write("Answer: {0}", Sum / evenCounter);
        }
        static void task4()
        {
            /*
            Завдання 4. Варіанти задач. Дано східчастий масив з n рядків, у рядках по mj (j=1..n) елементів.
            4.1. Знайти мінімальний елемент в кожному стовпці і записати дані в новий масив.
            */

            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[][] Arr = new int[n][];

            for (int i = 0; i < n; ++i)
            {
                Arr[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("Arr[{0},{1}]= ", i, j);
                    Arr[i][j] = int.Parse(Console.ReadLine());
                }
            }
            int[] result = new int[n]; 
            for(int i = 0; i < n; i++)
            {
                int min = Arr[n - 1][i];
                for(int j = n - 1 - i; j >= 0; j--)
                {
                    if (Arr[j][i] < min)
                    {
                        min = Arr[j][i];
                    }
                }
                result[i] = min;
            }
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("result[{0}]: {1}", i, result[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 C#");
            Console.Write("Enter task number: ");
            int task_number = int.Parse(Console.ReadLine());
            
            switch(task_number)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                default:
                    Console.WriteLine("No task under such number!");
                    break;
            }
        }
    }
}
