using System;

namespace lab3
{
    internal class TwoDimensionalArray
    {
        double[,] _array;
        int _n;
        int _m;
     
        
        public double[,] Array
        {
            get { return _array; }
            set { _array = value; }
        }

        public int N
        {
            get { return _n; }
            set 
            { 
                if (value > 0)
                {
                    _n = value;
                }
                else
                {
                    Validator validator = new Validator();
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Число строк и столбцов в квадратной матрице или число строк в прямоугольной матрице не может быть меньше 1");
                        Console.Write("Введите число: ");
                        value = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        if (value > 0)
                        {
                            _n = value;
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }

                }     
            }
        }

        public int M
        {
            get { return _m; }
            set
            {
                if (value > 0)
                {
                    _m = value;
                }
                else
                {
                    Validator validator = new Validator();
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Число строк и столбцов в квадратной матрице или число столбцов в прямоугольной матрице не может быть меньше 1");
                        Console.Write("Введите число: ");
                        value = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        if (value > 0)
                        {
                            _m = value;
                            flag = false;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                }
            }
        }

        public TwoDimensionalArray(int n)
        {
            Validator validator = new Validator();
            int num;
            Console.WriteLine("Введите пункт из списка \"2 3\" для 1 задания: ");
            Console.WriteLine("Если хотите решить 3 задачу, то введите 1: ");
            num = Convert.ToInt32(validator.check_int(Console.ReadLine()));
            switch (num)
            {
                case 2:
                    {
                        this.Array = new double[n, n];
                        Console.WriteLine();
                        Random rand = new Random();
                        int count = 1;
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < n; ++j)
                            {
                                int el = rand.Next(count, count + 9);
                                Array[j, i] = el;
                            }
                            count = count + 10;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат:");
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < n; ++j)
                            {
                                Console.Write(Array[i, j] + "\t");
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
                case 3:
                    {
                        this.Array = new double[n, n];
                        Console.WriteLine();
                        int[] primes =
                        {
                            2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                            73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151,
                            157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233,
                            239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317,
                            331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419,
                            421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503,
                            509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607,
                            613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701,
                            709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811,
                            821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911,
                            919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997
                        };
                        int k = 0;
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < n; ++j)
                            {
                                Array[i, j] = primes[k + i + j];
                            }
                            k += (n - 1);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат:");
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < n; ++j)
                            {
                                Console.Write(Array[i, j] + "\t");
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
                case 1:
                    {
                        this.N = n;
                        this.Array = new double[N, N]; 
                        Console.WriteLine();
                        double el;
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < n; ++j)
                            {
                                Console.Write("Введите число для индекса {0},{1}: ", i, j);
                                el = Convert.ToDouble(validator.check_double(Console.ReadLine()));
                                Array[i, j] = el;
                            }
                        }
                        break;
                    }
            }
            
        }

        public TwoDimensionalArray(int n, int m)
        {
            Validator validator = new Validator();
            int num;
            
            Console.Write("Введите номер задания из списка \"1 2 3\": ");
            num = Convert.ToInt32(validator.check_int(Console.ReadLine()));
            switch (num)
            {
                case 1:
                    {
                        this.Array = new double[n, m];
                        Console.WriteLine();
                        double el;
                        for (int i = 0; i < m; ++i)
                        {
                            for (int j = n - 1; j >= 0; j--)

                            {
                                Console.Write("Введите число для индекса {0},{1}: ", j, i);
                                el = Convert.ToDouble(validator.check_double(Console.ReadLine()));
                                Array[j, i] = el;
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат:");
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < m; ++j)
                            {
                                Console.Write(Array[i, j] + "\t");                          
                            }
                            Console.Write("\n");
                        }
                        break;
                    }
                case 2:
                    {
                        this.Array = new double[n, m];
                        Console.WriteLine();
                        int[] numberSchoolboy = new int[n];
                        int el;
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < m; ++j)
                            {
                                Console.Write("Введите {0} оценку {1} школьника: ", j+1, i+1);
                                el = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                                Array[i, j] = el;
                            }
                        }

                        for (int i = 0; i < n; ++i)
                        {
                            double counter = 0;
                            for (int j = 0; j < m; ++j)
                            {
                                counter += Convert.ToInt32(Array[i, j]);
                            }
                            if ((counter/m) > 4.5)
                            {
                                numberSchoolboy[i] = i + 1;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат: ");
                        Console.WriteLine("Номера школьников, средняя оценка которых больше 4.5: ");
                        for (int i = 0; i < numberSchoolboy.Length; ++i)
                        {
                            if (numberSchoolboy[i] != 0)
                            {
                                Console.Write(numberSchoolboy[i] + " ");
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        this.N = n;
                        this.M = m;
                        this.Array = new double[N, M];                    
                        Console.WriteLine();
                        double el;
                        for (int i = 0; i < n; ++i)
                        {
                            for (int j = 0; j < m; ++j)
                            {
                                Console.Write("Введите число для индекса {0},{1}: ", i, j);
                                el = Convert.ToDouble(validator.check_double(Console.ReadLine()));
                                Array[i, j] = el;
                            }
                        }
                        break;
                    }
            }
        }

        public double[,] Transposition()
        {
            if (M > 0)
            {
                double[,] newArr = new double[M, N] ;
                for (int i = 0; i < N; ++i)
                {
                    for (int j = M-1; j >= 0; --j)
                    {
                        newArr[j, i] = Array[i, j];
                    }
                }
                this.Array = newArr;
                int temp = this.N;
                this.N = this.M;
                this.M = temp;

                return this.Array;
            }
            else
            {
                double[,] newArr = new double[N, N];
                for (int i = 0; i < N; ++i)
                {
                    for (int j = N-1; j >= 0; --j)
                    {
                        newArr[j, i] = Array[i, j];
                    }
                }
                this.Array = newArr;

                int temp = this.N;
                this.N = this.M;
                this.M = temp;

                return this.Array;
            }   
        }

        public double[,] MultiplicationOnNumber(int x)
        {
            if (M > 0)
            {
                double[,] newArr = new double[N, M];
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < M; ++j)
                    {
                        newArr[i, j] = x * Array[i, j];
                    }
                }
                this.Array = newArr;

                return this.Array;
            }
            else
            {
                double[,] newArr = new double[N, N];
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        newArr[i, j] = x * Array[i, j];
                    }
                }
                this.Array = newArr;

                return this.Array;
            }

        }
        public double[,] Plus(TwoDimensionalArray otherArr)
        {
            if (M > 0)
            {
                 double[,] newArr = new double[N, M];
                 for (int i = 0; i < N; ++i)
                 {
                     for (int j = 0; j < M; ++j)
                     {
                         newArr[i, j] = this.Array[i, j] + otherArr.Array[i, j];
                     }
                 }
                this.Array = newArr;

                return this.Array;
            }
            else
            {
                double[,] newArr = new double[N, N];
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        newArr[i, j] = this.Array[i, j] + otherArr.Array[i, j];
                    }
                }
                this.Array = newArr;

                return this.Array;
            }
        }


        public double[,] Minus(TwoDimensionalArray otherArr)
        {
            if (M > 0)
            {
                double[,] newArr = new double[N, M];
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < M; ++j)
                    {
                        newArr[i, j] = this.Array[i, j] - otherArr.Array[i, j];
                    }
                }
                this.Array = newArr;

                return this.Array;
            }  

            else
            {
                double[,] newArr = new double[N, N];
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        newArr[i, j] = this.Array[i, j] - otherArr.Array[i, j];
                    }
                }
                this.Array = newArr;

                return this.Array;
            }
        }

        public override string ToString()
        {
            string result = "";
            if (M > 0)
            {
                for (int i = 0; i < N; ++i)
                {
                     for (int j = 0; j < M; ++j)
                     {
                          result += Array[i, j] + "\t";
                     }
                result += "\n";
                }    
            }
            else
            {
                for (int i = 0; i < N; ++i)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        result += Array[i, j] + "\t";
                    }
                    result += "\n";
                }
            }
            return result;     
        }
    }
}
