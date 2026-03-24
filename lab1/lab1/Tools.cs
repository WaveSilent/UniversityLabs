using System;
namespace lab1
{
    //Методы
    public class Methods
    {
        public double fraction(double x)
        {
            int int_x;
            int_x = (int)x;
            return x - int_x;
        }

        public int chatToNum(char x)
        {
            int ascii_x = (int)x;
            return ascii_x - 48;
        }

        public bool is2Digits(int x)
        {
            // x = Math.Abs(x) or *(-1);
            string str_x;
            int len_x;
            str_x = Convert.ToString(x);
            len_x = str_x.Length;
            if (len_x == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isInRange(int a, int b, int num)
        {
            if (a > b)
            {
                if ((num <= a) & (num >= b))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if ((num <= b) & (num >= a))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool isEqual(int a, int b, int c)
        {
            if ((a == b) & (b == c))
            {
                return true;
            }
            return false;
        }

        //Условия
        public int abs(int x)
        {
            if (x >= 0)
            {
                return x;
            }
            else
            {
                return x * (-1);
            }
        }

        public bool is35(int x)
        {
            if (((x % 3) == 0) & ((x % 5) == 0))
            {
                return false;
            }
            else if (((x % 3) == 0) | ((x % 5) == 0))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public int max3(int x, int y, int z)
        {
            if ((x >= y) & (x >= z))
            {
                return x;
            }

            else if ((y >= z))
            {
                return y;
            }

            else
            {
                return z;
            }
        }

        public int sum2(int x, int y)
        {
            int sum;
            sum = x + y;

            if ((sum >= 10) & (sum < 19))
            {
                return 20;
            }

            else
            {
                return sum;
            }
        }

        public String day(int x)
        {
            switch (x)
            {
                case 1:
                    {
                        return "Понедельник";
                        break;
                    }
                case 2:
                    {
                        return "Вторник";
                        break;
                    }
                case 3:
                    {
                        return "Среда";
                        break;
                    }
                case 4:
                    {
                        return "Четверг";
                        break;
                    }
                case 5:
                    {
                        return "Пятница";
                        break;
                    }
                case 6:
                    {
                        return "Суббота";
                        break;
                    }
                case 7:
                    {
                        return "Воскресенье";
                        break;
                    }
                default:
                    return "Это не день недели";
                    break;
            }
        }


        //Циклы

        public String listNums(int x)
        {
            string result = "";
            for (int i = 0; i <= x; ++i)
            {
                result += i + " ";
            }
            return result;
        }

        public String chet(int x)
        {
            string result = "";
            for (int i = 0; i <= x; i += 2)
            {
                result += i + " ";
            }
            return result;
        }

        public int numLen(long x)
        {
            int total = 0;
            while (x != 0)
            {
                total++;
                x /= 10;
            }
            return total;
        }

        public void square(int x)
        {
            string result = "";
            for (int i = 1; i <= x; ++i)
            {
                for (int j = 1; j <= x; ++j)
                {
                    result += "*";
                }
                result += "\n";
            }
            Console.WriteLine(result);
        }

        public void rightTriangle(int x)
        {
            string result = "";
            for (int i = (x - 1); i >= 0; --i)
            {
                result = new string(' ', i) + new string('*', x - i);
                Console.WriteLine(result);
            }
        }

        //Массивы


        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }

        public int maxAbs(int[] arr)
        {
            int max_el = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max_el))
                {
                    max_el = arr[i];
                }
            }
            return max_el;
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] res = new int[arr.Length + ins.Length];
            for (int i = 0; i < pos; ++i)
            {
                res[i] = arr[i];
            }
            for (int i = pos; i < (pos + ins.Length); ++i)
            {
                res[i] = ins[i - pos];
            }
            for (int i = (pos + ins.Length); i < (arr.Length + ins.Length); ++i)
            {
                res[i] = arr[i - ins.Length];
            }
            return res;
        }

        public int[] reverseBack(int[] arr)
        {
            int[] rev_arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                rev_arr[i] = arr[arr.Length - 1 - i];
            }
            return rev_arr;
        }

        public int[] findAll(int[] arr, int x)
        {
            int[] arr_x = new int[arr.Length];
            int l = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == x)
                {
                    arr_x[i] = i;
                    count++;
                }
            }

            int[] res = new int[count];

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr_x[i] > 0)
                {
                    res[l] = i;
                    l++;
                }
            }
            return res;
        }

        public int count_res(int[] arr, int x)
        {
            int[] arr_x = new int[arr.Length];
            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == x)
                {
                    arr_x[i] = i;
                    count++;
                }
            }
            return count;
        }
    }
}