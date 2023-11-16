using System.Globalization;
string yep = "";
do
{
    Console.WriteLine("Введите номер задания(1,4):");
    int g = int.Parse(Console.ReadLine());

    switch (g)
    {
        case 1:
            Console.WriteLine("Задание - 1");
            {
                Console.WriteLine("Введите кол-во строк: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите кол-во столбцов: ");
                int m = int.Parse(Console.ReadLine());

                double[,] matrix = new double[n, m];


                Console.WriteLine("Введите элементы матрицы: ");
                for (int i = 0; i < n; i++)
                {

                    for (int j = 0; j < m; j++)
                    {

                        Console.WriteLine($"Элементы [{i},{j}]:");
                        matrix[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Готовая матрица: ");
                for (int j = 0; j < m; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(matrix[j, i] + " ");

                    }
                    Console.WriteLine();
                }
            }
            break;
        case 4:
            {
                Console.WriteLine("Задание-4");

                Console.WriteLine("Введите кол-во строк: ");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите кол-во столбцов: ");
                int m = int.Parse(Console.ReadLine());

                double[,] matrix = new double[n, m];
                //Ввод элементов матрицы
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.WriteLine($"Элементы [{i},{j}]:");
                        matrix[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                //Создает новую матрицу для результата транспонирования

                double[,] trsM = new double[m, n];
                //Транспонировать матрицу
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        trsM[j, i] = matrix[i, j];
                    }
                }

                Console.WriteLine("Исходная матрица: ");
                PrintM(trsM, m, n);

                Console.WriteLine("Транспонированная матрица: ");
                PrintM(trsM, n, m);

                static void PrintM(double[,] matrix, int n, int m)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.WriteLine(matrix[j, i] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }break;
        default:
            Console.WriteLine("Вы вводите не значениея которых нет!!! ");
            break;

    }
    Console.WriteLine("Хотите продолжить: ");
    yep = Console.ReadLine();
} while (yep == "да");


