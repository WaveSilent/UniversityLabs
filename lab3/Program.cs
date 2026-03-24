using System;
using System.IO;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();
            int num1;
            Console.Write("Введите номер задания из списка \"1 2 3 4 5 6 7 8\": ");
            num1 = Convert.ToInt32(validator.check_int(Console.ReadLine()));
            switch (num1)
            {
                case 1:
                    {
                        Console.WriteLine("Введите n и m для размерности двумерного массива: ");
                        TwoDimensionalArray arr1 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));
                        Console.WriteLine();
                        Console.WriteLine(arr1);
                        // Для решения второго пункта
                        Console.WriteLine("Введите n для размерности двумерного массива: ");
                        TwoDimensionalArray arr2 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())));
                        Console.WriteLine();
                        Console.WriteLine(arr2);
                        // Для решения третего пункта
                        Console.WriteLine("Введите n для размерности двумерного массива: ");
                        TwoDimensionalArray arr3 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())));
                        Console.WriteLine();
                        Console.WriteLine(arr3);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Введите n и m для размерности двумерного массива: ");
                        TwoDimensionalArray arr1 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));
                        Console.WriteLine();
                        Console.WriteLine(arr1);

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Складывать или вычитать матрицы можно только одного порядка");
                        Console.Write("Если вы хотите работать с квадратными матрицами, введите 1, иначе введите 2: ");
                        int num2;                   
                        num2 = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        switch (num2)
                        {
                            case 1:
                                {
                                        Console.WriteLine("Введите n для размерности 1 двумерного массива: ");
                                        TwoDimensionalArray arr1 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())));
                                        Console.WriteLine();
                                        Console.WriteLine("Введите n для размерности 2 двумерного массива: ");
                                        TwoDimensionalArray arr2 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())));
                                        Console.WriteLine();
                                        Console.WriteLine("Введите n для размерности 3 двумерного массива: ");
                                        TwoDimensionalArray arr3 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())));
                                    try 
                                    { 
                                        arr1.Transposition();
                                        arr2.Transposition();

                                        arr1.Minus(arr2);
                                        Console.WriteLine();
                                        Console.Write("Введите число, на которое хотите умножить матрицу: ");
                                        arr3.MultiplicationOnNumber(validator.check_int(Console.ReadLine()));
                                        Console.WriteLine();
                                        arr1.Plus(arr3);

                                        Console.WriteLine();
                                        Console.WriteLine("Итоговая матрица:");
                                        Console.WriteLine(arr1);
                                    }
                                    catch 
                                    {
                                        Console.WriteLine("Нельзя складывать и вычитать матрицы не одного порядка");
                                        return;
                                    }
                                    break;
                                }
                            case 2:
                                {                                   
                                    Console.WriteLine("Введите n и m для размерности 1 двумерного массива: ");
                                    TwoDimensionalArray arr1 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));
                                    Console.WriteLine();
                                    Console.WriteLine("Введите n и m для размерности 2 двумерного массива: ");
                                    TwoDimensionalArray arr2 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));
                                    Console.WriteLine();
                                    Console.WriteLine("Введите n и m для размерности 3 двумерного массива: ");
                                    TwoDimensionalArray arr3 = new TwoDimensionalArray(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));
                                    try 
                                    {                                       
                                        arr1.Transposition();
                                        arr2.Transposition();
                                        
                                        arr1.Minus(arr2);

                                        Console.Write("Введите число, на которое хотите умножить матрицу: ");
                                        arr3.MultiplicationOnNumber(validator.check_int(Console.ReadLine()));
                                        Console.WriteLine();
                                        arr1.Plus(arr3);

                                        Console.WriteLine();
                                        Console.WriteLine("Итоговая матрица:");
                                        Console.WriteLine(arr1);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Нельзя складывать и вычитать матрицы не одного порядка");
                                        return;
                                    }
                                    break;
                                }
                        }
                        break;                        
                    }
                case 4:
                    {
                        BinaryFile.WriteDataBinary1();

                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат: ");
                        Console.WriteLine("Количество квадратов нечетных чисел = " + BinaryFile.CountOfSquaresOfOddNumbers());
                        break;
                    }
                case 5:
                    {
                        BinaryFile.WriteDataBinary2();

                        BinaryFile.FindMostExpensiveToyForChildrenYounger4();
                        break;
                    }
                case 6:
                    {
                        BinaryFile.WriteDataStream1();
                     
                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат: ");
                        Console.WriteLine("Среднее арифметическое максимального и минимального элементов = " + BinaryFile.AriphmeticMeanMaxAndMin());
                        break;
                    }
                case 7:
                    {
                        BinaryFile.WriteDataStream2();

                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат: ");
                        Console.WriteLine("Произведение чётных элементов = " + BinaryFile.ProductOfOddElements());
                        break;
                    }
                case 8:
                    {
                        BinaryFile.IfNotLatinLetters();
                        break;
                    }
            }
        }
    }
}


