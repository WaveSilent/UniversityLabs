using System;


namespace lab2
{
    internal class Program
    {
        static void Main()
        {
            Validator validator = new Validator();
            int num1;
            Console.Write("Введите номер задания из списка \"1 2 3 4 5\": ");
            num1 = Convert.ToInt32(validator.check_int(Console.ReadLine()));
            switch (num1)
            {
                case 1:
                    {
                        int num2;
                        Console.Write("Введите номер задачи из списка \"1 3\": ");
                        num2 = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        switch (num2)
                        {
                            case 1:
                                {
                                    double x, y;
                                    Console.Write("Введите число x: ");                                    
                                    x = Convert.ToDouble(validator.check_double(Console.ReadLine()));                                                                       
                                    Console.Write("Введите число y: ");                                    
                                    y = Convert.ToDouble(validator.check_double(Console.ReadLine()));                                                                                                    
                                    Coordinate_point point1 = new Coordinate_point();
                                    Coordinate_point point2 = new Coordinate_point(-10, 3);
                                    Coordinate_point point3 = new Coordinate_point(x, y);

                                    Console.WriteLine();
                                    Console.WriteLine("Итоговый результат:");
                                    Console.WriteLine(point1);
                                    Console.WriteLine();
                                    Console.WriteLine(point2);
                                    Console.WriteLine();
                                    Console.WriteLine(point3);
                                    break;
                                }
                            case 3:
                                {
                                    /*int counter = 0;
                                    start:
                                    string surname, name, middle_name;
                                    Console.WriteLine("Введите фамилию: ");
                                    surname = Console.ReadLine();
                                    Console.WriteLine("Введите имя: ");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Введите отчество: ");
                                    middle_name = Console.ReadLine();
                                    Names name1 = new Names(surname, name, middle_name);*/

                                    Console.WriteLine("Введите фамилию,имя и отчество для 1 человека: ");                                                                                                         
                                    Names name1 = new Names(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                    Console.WriteLine("Данные 1 человека внесены!");
                                    Console.WriteLine();
                                    Console.WriteLine("Введите фамилию,имя и отчество для 2 человека: ");
                                    Names name2 = new Names(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                    Console.WriteLine("Данные 2 человека внесены!");
                                    Console.WriteLine();
                                    Console.WriteLine("Введите фамилию,имя и отчество для 3 человека: ");
                                    Names name3 = new Names(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                    Console.WriteLine("Данные 3 человека внесены!");

                                    Console.WriteLine();
                                    Console.WriteLine("Итоговый результат:");
                                    Console.WriteLine(name1);
                                    Console.WriteLine();
                                    Console.WriteLine(name2);
                                    Console.WriteLine();
                                    Console.WriteLine(name3);

                                    /*if (counter < 2)
                                    {
                                        ++counter;
                                        goto start;
                                    }*/
                                    break;
                                }
                        }
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Создаем линию 1 с началом в т. {1;3} и концом в т.{23;8}");
                        Line line1 = new Line(new Coordinate_point(1, 3).View_representation(), new Coordinate_point(23, 8).View_representation());                   
                        // Line line1 = new Line(new Coordinate_point(5, 36).View_representation(), new Coordinate_point(23, 8).View_representation());
                        Console.WriteLine("Создаем линию 2, горизонтальную, на высоте 10, от точки 5 до точки 25");
                        Line line2 = new Line(new Coordinate_point(5, 10).View_representation(), new Coordinate_point(25, 10).View_representation());
                        // Line line2 = new Line(new Coordinate_point(5, 10).View_representation(), new Coordinate_point(45, 11).View_representation());
                        Console.WriteLine("Создаем линию 3, которая начинается всегда там же, где начинается линия 1, и заканчивается всегда там\r\nже, где заканчивается линия 2");
                        Line line3 = new Line(line1.Start_point(), line2.End_point());
                        // 4 Пункт. Изменение линии 1 и 2 так, чтобы положение 3 линии соотвествовало требованиям пункта 3. Изменения закомментированы сверху
                        // 5 Пункт. Изменение координат линии 1 так, чтобы не изменились координаты 3 линии. Изменения закомментированы снизу

                        // Line line1 = new Line(new Coordinate_point(1, 3).View_representation(), new Coordinate_point(41, 15).View_representation());

                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат:");
                        Console.WriteLine("1 " + line1);
                        Console.WriteLine();
                        Console.WriteLine("2 " + line2);
                        Console.WriteLine();
                        Console.WriteLine("3 " + line3);
                        break;                       
                    }

                case 3:
                    {
                        /*string name;                     
                        int count_paths;
                        Console.Write("Введите название города: ");
                        name = Console.ReadLine();
                        Console.Write("Введите количество путей идущих из города {0}: ", name);
                        count_paths = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        string[] city_to = new string[count_paths];
                        int[] cost = new int[count_paths];
                        Console.WriteLine();
                        for (int i = 0; i < count_paths; ++i)
                        {
                            Console.Write("Введите города, которые идут из города {0}: ", name);
                            city_to[i] = Console.ReadLine();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < count_paths; ++i)
                        {
                            Console.Write("Введите стоимости поездок в эти города: ");
                            cost[i] = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        }

                        Cities city1 = new Cities(name, count_paths);
                        city1.Collection_of_paths_if_not_passed(city_to, cost);*/

                        Cities city1 = new Cities("A", 3);
                        city1.Collection_of_paths_if_not_passed(new string[] { "B", "D", "F" }, new int[] { 5, 6, 1 });
                        Cities city2 = new Cities("B", 2);
                        city2.Collection_of_paths_if_not_passed(new string[] { "A", "C" }, new int[] { 5, 3 });
                        Cities city3 = new Cities("C", 2);
                        city3.Collection_of_paths_if_not_passed(new string[] { "B", "D" }, new int[] { 3, 4 });
                        Cities city4 = new Cities("D", 3);
                        city4.Collection_of_paths_if_not_passed(new string[] { "A", "C", "E" }, new int[] { 6, 4, 2 });
                        Cities city5 = new Cities("E", 1);
                        city5.Collection_of_paths_if_not_passed(new string[] { "F" }, new int[] { 2 });
                        Cities city6 = new Cities("F", 2);
                        city6.Collection_of_paths_if_not_passed(new string[] { "B", "E" }, new int[] { 1, 2 });

                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат:");
                        Console.WriteLine(city1);
                        Console.WriteLine();
                        Console.WriteLine(city2);
                        Console.WriteLine();
                        Console.WriteLine(city3);
                        Console.WriteLine();
                        Console.WriteLine(city4);
                        Console.WriteLine();
                        Console.WriteLine(city5);
                        Console.WriteLine();
                        Console.WriteLine(city6);
                        break;
                    }

                case 4:
                    {
                        Cities city1 = new Cities("A");     // Демонстрация 1 города, с одним параметром name
                        city1.Collection_of_paths_if_not_passed(new string[] { "B", "D", "F" }, new int[] { 5, 6, 1 });
                        Cities city2 = new Cities("B", new string[] { "A", "C" }, new int[] { 5, 3 });   // Демонстрация 2 города с 3 параметрами name, набор связанных с ним городов и стоимостей путей к ним
                        city2.Collection_of_paths_if_passed();

                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат:");
                        Console.WriteLine("Город " + city1);
                        Console.WriteLine();
                        Console.WriteLine("Город " + city2);
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Введите числитель и знаменатель для 1 дроби\nЕсли вы хотите выполнить операцию с числом, то для знаменателя введите цифру 1: ");
                        Fraction fraction1 = new Fraction(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));
                        Console.WriteLine("Введите числитель и знаменатель для 2 дроби\nЕсли вы хотите выполнить операцию с числом, то для знаменателя введите цифру 1: ");
                        Fraction fraction2 = new Fraction(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));                   
                        Console.WriteLine("Введите числитель и знаменатель для 3 дроби\nЕсли вы хотите выполнить операцию с числом, то для знаменателя введите цифру 1: ");
                        Fraction fraction3 = new Fraction(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));                     
                        Console.WriteLine("Введите числитель и знаменатель для 4 дроби\nЕсли вы хотите выполнить операцию с числом, то для знаменателя введите цифру 1: ");
                        Fraction fraction4 = new Fraction(Convert.ToInt32(validator.check_int(Console.ReadLine())), Convert.ToInt32(validator.check_int(Console.ReadLine())));                                   
                        
                        Console.WriteLine();
                        Console.WriteLine("Итоговый результат:");
                        Console.WriteLine("Сумма 1 и 2 дроби: " + fraction1 + " + " + fraction2 + " = " + fraction1.Sum(fraction2.View_representation_fraction()));                
                        Console.WriteLine();
                        Console.WriteLine("Разность 2 и 4 дроби: " + fraction2 + " - " + fraction4 + " = " + fraction2.Subtraction(fraction4.View_representation_fraction()));
                        Console.WriteLine();
                        Console.WriteLine("Умножение 3 дроби на 1: " + fraction3 + " * " + fraction1 + " = " + fraction3.Multiplication(fraction1));
                        Console.WriteLine();
                        Console.WriteLine("Деление 4 дроби на 3: " + fraction4 + " / " + fraction3 + " = " + fraction4.Div(fraction3.View_representation_fraction()));
                        Console.WriteLine();
                        Console.WriteLine("Пример из файла: " + fraction1.Sum(fraction2.Div(fraction3.Subtraction("5"))));
                        break;                       
                    }
            }   
        }
    }
}
