using System;

namespace lab2
{
    internal class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                
                if (value != 0)
                {
                    denominator = value;
                }
                else
                {
                    Validator validator = new Validator();
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Знаменатель не может быть равен нулю, так как делить на ноль нельзя!");
                        Console.Write("Введите число: ");
                        value = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        Console.WriteLine();
                        if (value != 0)
                        {
                            denominator = value;
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

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public string View_representation_fraction()
        {
            if (numerator == 0)
            {
                return "0";
            }
            if (denominator == 1)
            {
                return Convert.ToString(numerator);
            }
            else
            {
                return numerator + "/" + denominator;
            }           
        }

        public string Sum(string fraction)
        {
            int summary_numerator;
            int summary_denominator;
            string res_fraction_numer = "";
            string res_fraction_denom = "";
            int fraction_numer, fraction_denom;
            int have_slash = 0;

            for (int i = 0; i < fraction.Length; ++i)
            {
                if (Convert.ToString(fraction[i]) == "/")
                {
                    have_slash++;
                }
            }

            if (have_slash == 0)
            {
                fraction_numer = Convert.ToInt32(fraction);
                if (fraction_numer == 0 && numerator != 0)
                {
                    return numerator + "/" + denominator; 
                }
                else if (fraction_numer == 0 && numerator == 0)
                {
                    return "0";
                }
                else
                {
                    summary_numerator = numerator + (fraction_numer * denominator);
                    summary_denominator = denominator;
                    return summary_numerator + "/" + summary_denominator;
                }
            }

            else
            {
                int ind = 0;
                while (Convert.ToString(fraction[ind]) != "/")
                {
                    res_fraction_numer += Convert.ToString(fraction[ind]);
                    ++ind;
                }

                while (fraction.Length - 1 != ind)
                {
                    res_fraction_denom += fraction[ind + 1];
                    ++ind;
                }
                fraction_numer = Convert.ToInt32(res_fraction_numer);
                fraction_denom = Convert.ToInt32(res_fraction_denom);

                if (numerator == 0)
                {
                    return fraction_numer + "/" + fraction_denom;
                }
                else if (denominator == fraction_denom)
                {
                    summary_numerator = numerator + fraction_numer;
                    summary_denominator = denominator;
                    return summary_numerator + "/" + summary_denominator;
                }
                else
                {
                    int max_denominator;
                    int min_denominator;
                    int total;
                    max_denominator = Math.Max(denominator, fraction_denom);
                    min_denominator = Math.Min(denominator, fraction_denom);
                    if (max_denominator % min_denominator == 0 && max_denominator == denominator)
                    {
                        summary_numerator = numerator + fraction_numer * (max_denominator / min_denominator);
                        summary_denominator = max_denominator;
                        return summary_numerator + "/" + summary_denominator;
                    }
                    else if (max_denominator % min_denominator == 0 && max_denominator == fraction_denom)
                    {
                        summary_numerator = numerator * (max_denominator / min_denominator) + fraction_numer;
                        summary_denominator = max_denominator;
                        return summary_numerator + "/" + summary_denominator;
                    }
                    else if (max_denominator % min_denominator != 0 && max_denominator == denominator)
                    {
                        total = max_denominator * min_denominator;
                        summary_numerator = numerator * (total / max_denominator) + fraction_numer * (total / min_denominator);
                        summary_denominator = total;
                        return summary_numerator + "/" + summary_denominator;
                    }
                    else
                    {
                        total = max_denominator * min_denominator;
                        summary_numerator = numerator * (total / min_denominator) + fraction_numer * (total / max_denominator);
                        summary_denominator = total;
                        return summary_numerator + "/" + summary_denominator;
                    }
                }            
            }
        }

        public string Subtraction(string fraction)
        {

            int summary_numerator;
            int summary_denominator;
            string res_fraction_numer = "";
            string res_fraction_denom = "";
            int fraction_numer, fraction_denom;
            int have_slash = 0;

            for (int i = 0; i < fraction.Length; ++i)
            {
                if (Convert.ToString(fraction[i]) == "/")
                {
                    have_slash++;
                }
            }

            if (have_slash == 0)
            {
                fraction_numer = Convert.ToInt32(fraction);
                if (fraction_numer == 0 && numerator != 0)
                {
                    return numerator + "/" + denominator;
                }
                else if (fraction_numer == 0 && numerator == 0)
                {
                    return "0";
                }
                else
                {
                    summary_numerator = numerator - (fraction_numer * denominator);
                    summary_denominator = denominator;
                    return summary_numerator + "/" + summary_denominator;
                }
            }
           
            else
            {
                int ind = 0;
                while (Convert.ToString(fraction[ind]) != "/")
                {
                    res_fraction_numer += Convert.ToString(fraction[ind]);
                    ++ind;
                }

                while (fraction.Length - 1 != ind)
                {
                    res_fraction_denom += fraction[ind + 1];
                    ++ind;
                }
                fraction_numer = Convert.ToInt32(res_fraction_numer);
                fraction_denom = Convert.ToInt32(res_fraction_denom);

                if (numerator == 0)
                {
                    return (-fraction_numer) + "/" + fraction_denom;
                }
                else if (denominator == fraction_denom)
                {
                    summary_numerator = numerator - fraction_numer;
                    summary_denominator = denominator;
                    return summary_numerator + "/" + summary_denominator;
                }
                else
                {
                    int max_denominator;
                    int min_denominator;
                    int total;
                    max_denominator = Math.Max(denominator, fraction_denom);
                    min_denominator = Math.Min(denominator, fraction_denom);
                    if (max_denominator % min_denominator == 0 && max_denominator == denominator)
                    {
                        summary_numerator = numerator - fraction_numer * (max_denominator / min_denominator);
                        summary_denominator = max_denominator;
                        return summary_numerator + "/" + summary_denominator;
                    }
                    else if (max_denominator % min_denominator == 0 && max_denominator == fraction_denom)
                    {
                        summary_numerator = numerator * (max_denominator / min_denominator) - fraction_numer;
                        summary_denominator = max_denominator;
                        return summary_numerator + "/" + summary_denominator;
                    }
                    else if (max_denominator % min_denominator != 0 && max_denominator == denominator)
                    {
                        total = max_denominator * min_denominator;
                        summary_numerator = numerator * (total / max_denominator) - fraction_numer * (total / min_denominator);
                        summary_denominator = total;
                        return summary_numerator + "/" + summary_denominator;
                    }
                    else
                    {
                        total = max_denominator * min_denominator;
                        summary_numerator = numerator * (total / min_denominator) - fraction_numer * (total / max_denominator);
                        summary_denominator = total;
                        return summary_numerator + "/" + summary_denominator;
                    }
                }
            }

        }
        public string Multiplication(Fraction other)
        {
            int summary_numerator;
            int summary_denominator;
            summary_numerator = this.numerator * other.numerator;
            summary_denominator = this.denominator * other.denominator;

            return summary_numerator + "/" + summary_denominator;

        }
        /*public string Multiplication(string fraction)
        {
            int summary_numerator;
            int summary_denominator;
            string res_fraction_numer = "";
            string res_fraction_denom = "";
            int fraction_numer, fraction_denom;
            int have_slash = 0;
            
            for (int i = 0; i < fraction.Length; ++i)
            {
                if (Convert.ToString(fraction[i]) == "/")
                {
                    have_slash++;
                }
            }

            if (have_slash == 0)
            {
                fraction_numer = Convert.ToInt32(fraction);
                if (fraction_numer == 0)
                {
                    return "0";
                }
                else
                {
                    summary_numerator = numerator * fraction_numer;
                    summary_denominator = denominator * 1;
                    if (summary_numerator == 0)
                    {
                        return "0";
                    }
                    else
                    {
                        return summary_numerator + "/" + summary_denominator;
                    }
                }
            }

            else 
            {
                int ind = 0;
                while (Convert.ToString(fraction[ind]) != "/")
                {
                    res_fraction_numer += Convert.ToString(fraction[ind]);
                    ++ind;
                }
                
                while (fraction.Length-1 != ind)
                {
                    res_fraction_denom += fraction[ind + 1];
                    ++ind;
                }                
                fraction_numer = Convert.ToInt32(res_fraction_numer);
                fraction_denom = Convert.ToInt32(res_fraction_denom);
              
                summary_numerator = numerator * fraction_numer;
                summary_denominator = denominator * fraction_denom;
                if (summary_numerator == 0)
                {
                    return "0";
                }
                else
                {
                    return summary_numerator + "/" + summary_denominator;
                }

            }           
        }*/

        public string Div(string fraction)
        {
            int summary_numerator;
            int summary_denominator;
            string res_fraction_numer = "";
            string res_fraction_denom = "";
            int fraction_numer, fraction_denom;
            int have_slash = 0;

            for (int i = 0; i < fraction.Length; ++i)
            {
                if (Convert.ToString(fraction[i]) == "/")
                {
                    have_slash++;
                }
            }

            if (have_slash == 0)
            {
                fraction_numer = Convert.ToInt32(fraction);

                if (fraction_numer == 0)
                {
                    throw new ArgumentException("Denominator must not be zero.", nameof(fraction_numer)); ;
                }
                else
                {
                    summary_numerator = numerator * 1;
                    summary_denominator = denominator * fraction_numer;
                    if (summary_numerator == 0)
                    {
                        return "0";
                    }
                    else
                    {
                        return summary_numerator + "/" + summary_denominator;
                    }
                }
            }

            else
            {
                int ind = 0;
                while (Convert.ToString(fraction[ind]) != "/")
                {
                    res_fraction_numer += Convert.ToString(fraction[ind]);
                    ++ind;
                }

                while (fraction.Length - 1 != ind)
                {
                    res_fraction_denom += fraction[ind + 1];
                    ++ind;
                }
                fraction_numer = Convert.ToInt32(res_fraction_numer);
                fraction_denom = Convert.ToInt32(res_fraction_denom);          
                
                summary_numerator = numerator * fraction_denom;
                summary_denominator = denominator * fraction_numer;
                if (summary_numerator == 0)
                {
                    return "0";
                }
                else
                {
                    return summary_numerator + "/" + summary_denominator;
                }  
            }         
        }

        public override string ToString()
        {       
            return View_representation_fraction();
        }
    }
}
