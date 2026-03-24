using System;

namespace lab1
{
    class Demo
    {
        public static void Main()
        {
            int num1;
            Console.Write("Введите номер задания из списка \"1 2 3 4\": ");
            num1 = Convert.ToInt32(Console.ReadLine());
            switch (num1)
            {
                case 1:
                    {
                        int num2;
                        Console.Write("Введите номер задачи из списка \"1 3 5 7 9\": ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        switch (num2)
                        {
                            // МЕТОДЫ 1 задача
                            case 1:
                                {
                                    double x;
                                    Console.Write("Введите вещественное число x: ");
                                    //x = double.Parse(Console.ReadLine());
                                    x = Convert.ToDouble(Console.ReadLine());
                                    Methods pr1 = new Methods();
                                    double result = pr1.fraction(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            // МЕТОДЫ 3 задача 
                            case 3:
                                {
                                    char x;
                                    Console.Write("Введите один символ из списка \"0 1 2 3 4 5 6 7 8 9\": ");
                                    x = Convert.ToChar(Console.ReadLine());
                                    Methods pr3 = new Methods();
                                    int result = pr3.chatToNum(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            // МЕТОДЫ 5 задача 
                            case 5:
                                {
                                    int x;
                                    bool result;
                                    Console.Write("Введите число x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr5 = new Methods();
                                    result = pr5.is2Digits(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            // МЕТОДЫ 7 задача 
                            case 7:
                                {
                                    int a, b, num;
                                    bool result;
                                    Console.WriteLine("Введите значение a, b, num: ");
                                    a = Convert.ToInt32(Console.ReadLine());
                                    b = Convert.ToInt32(Console.ReadLine());
                                    num = Convert.ToInt32(Console.ReadLine());
                                    Methods pr7 = new Methods();
                                    result = pr7.isInRange(a, b, num);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            // МЕТОДЫ 9 задача 
                            case 9:
                                {
                                    int a, b, c;
                                    bool result;
                                    Console.WriteLine("Введите значение a, b, num: ");
                                    a = Convert.ToInt32(Console.ReadLine());
                                    b = Convert.ToInt32(Console.ReadLine());
                                    c = Convert.ToInt32(Console.ReadLine());
                                    Methods pr9 = new Methods();
                                    result = pr9.isEqual(a, b, c);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }


                        }
                        break;
                    }
                case 2:
                    {
                        int num3;
                        Console.Write("Введите номер задачи из списка \"1 3 5 7 9\": ");
                        num3 = Convert.ToInt32(Console.ReadLine());
                        switch (num3)
                        {
                            case 1:
                                {
                                    int x;
                                    int result;
                                    Console.Write("Введите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr1 = new Methods();
                                    result = pr1.abs(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 3:
                                {
                                    int x;
                                    bool result;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr3 = new Methods();
                                    result = pr3.is35(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 5:
                                {
                                    int x, y, z;
                                    int result;
                                    Console.WriteLine("Введите значение x, y, z: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    y = Convert.ToInt32(Console.ReadLine());
                                    z = Convert.ToInt32(Console.ReadLine());
                                    Methods pr5 = new Methods();
                                    result = pr5.max3(x, y, z);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 7:
                                {
                                    int x, y;
                                    int result;
                                    Console.WriteLine("Введите значение x, y: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    y = Convert.ToInt32(Console.ReadLine());
                                    Methods pr7 = new Methods();
                                    result = pr7.sum2(x, y);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 9:
                                {
                                    int x;
                                    string result;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr9 = new Methods();
                                    result = pr9.day(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        int num4;
                        Console.Write("Введите номер задачи из списка \"1 3 5 7 9\": ");
                        num4 = Convert.ToInt32(Console.ReadLine());
                        switch (num4)
                        {
                            case 1:
                                {
                                    int x;
                                    string result;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr1 = new Methods();
                                    result = pr1.listNums(x);
                                    Console.WriteLine("Результат: {0}", result);
                                    break;
                                }
                            case 3:
                                {
                                    int x;
                                    string result;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr3 = new Methods();
                                    result = pr3.chet(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 5:
                                {
                                    long x;
                                    int result;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr5 = new Methods();
                                    result = pr5.numLen(x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 7:
                                {
                                    int x;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr7 = new Methods();
                                    pr7.square(x);
                                    break;
                                }
                            case 9:
                                {
                                    int x;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr9 = new Methods();
                                    pr9.rightTriangle(x);
                                    break;
                                }
                        }
                        break;
                    }
                case 4:
                    {
                        int num5;
                        Console.Write("Введите номер задачи из списка \"1 3 5 7 9\": ");
                        num5 = Convert.ToInt32(Console.ReadLine());
                        switch (num5)
                        {
                            case 1:
                                {
                                    int n;
                                    Console.Write("Напишите количество чисел в массиве: ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    int[] arr = new int[n];
                                    int x;
                                    int result;
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.Write("Введите " + i + " значение в массиве: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        arr[i] = num;
                                    }
                                    Methods pr1 = new Methods();
                                    result = pr1.findFirst(arr, x);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 3:
                                {
                                    int n;
                                    Console.Write("Напишите количество чисел в массиве: ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    int result;
                                    int[] arr = new int[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.Write("Введите " + i + " значение в массиве: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        arr[i] = num;
                                    }
                                    Methods pr3 = new Methods();
                                    result = pr3.maxAbs(arr);
                                    Console.WriteLine("Результат: " + result);
                                    break;
                                }
                            case 5:
                                {
                                    int n1;
                                    Console.Write("Напишите количество чисел в массиве arr: ");
                                    n1 = Convert.ToInt32(Console.ReadLine());
                                    int n2;
                                    Console.Write("Напишите количество чисел в массиве ins: ");
                                    n2 = Convert.ToInt32(Console.ReadLine());
                                    int[] arr = new int[n1];
                                    int[] ins = new int[n2];
                                    int pos;
                                    int[] res = new int[n1 + n2];
                                    Console.Write("Напишите значение pos: ");
                                    pos = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 0; i < n1; i++)
                                    {
                                        Console.Write("Введите " + i + " значение в массиве arr: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        arr[i] = num;
                                    }
                                    Console.WriteLine();
                                    for (int i = 0; i < n2; i++)
                                    {
                                        Console.Write("Введите " + i + " значение в массиве ins: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        ins[i] = num;
                                    }
                                    Methods pr5 = new Methods();
                                    res = pr5.add(arr, ins, pos);
                                    Console.Write("Результат: [");
                                    for (int i = 0; i < (n1 + n2); i++)
                                    {
                                        Console.Write(res[i] + " ");
                                    }
                                    Console.Write("]");
                                    break;
                                }
                            case 7:
                                {
                                    int n;
                                    Console.Write("Напишите количество чисел в массиве: ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    int[] arr = new int[n];
                                    int[] res = new int[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.Write("Введите " + i + " значение в массиве arr: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        arr[i] = num;
                                    }
                                    Methods pr7 = new Methods();
                                    res = pr7.reverseBack(arr);
                                    Console.Write("Результат: [");
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.Write(res[i] + " ");
                                    }
                                    Console.Write("]");
                                    break;
                                }
                            case 9:
                                {
                                    int count;
                                    int n;
                                    Console.Write("Напишите количество чисел в массиве: ");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    int x;
                                    int[] arr = new int[n];
                                    for (int i = 0; i < n; i++)
                                    {
                                        Console.Write("Введите " + i + " значение в массиве arr: ");
                                        int num = Convert.ToInt32(Console.ReadLine());
                                        arr[i] = num;
                                    }
                                    Console.Write("Напишите значение x: ");
                                    x = Convert.ToInt32(Console.ReadLine());
                                    Methods pr9_help = new Methods();
                                    count = pr9_help.count_res(arr, x);
                                    int[] res = new int[count];
                                    Methods pr9 = new Methods();
                                    res = pr9.findAll(arr, x);
                                    Console.Write("Результат: [");
                                    for (int i = 0; i < res.Length; i++)
                                    {
                                        Console.Write(res[i] + " ");
                                    }
                                    Console.Write("]");
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}