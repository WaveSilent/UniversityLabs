using System;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace lab3
{
    internal class BinaryFile
    {
        public static void WriteDataBinary1()
        {
            Validator validator = new Validator();
            int num;
            Random random = new Random();
            BinaryWriter binaryWriter;

            try
            {
                binaryWriter = new BinaryWriter(new FileStream("file1.txt", FileMode.Create));      
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return;
            }

            Console.Write("Введите количество данных, которое будет в файле: ");
            num = Convert.ToInt32(validator.check_int(Console.ReadLine()));

            for (int i = 0; i < num; ++i)
            {
                binaryWriter.Write(random.Next(1, 50));
            }

            //Точный пример 

            /*binaryWriter.Write(49);
            binaryWriter.Write(5);
            binaryWriter.Write(7);
            binaryWriter.Write(49);*/
            binaryWriter.Close();
        }

        public static void WriteDataBinary2()
        {
            BinaryWriter binaryWriter;

            try
            {
                binaryWriter = new BinaryWriter(new FileStream("file2.txt", FileMode.Create));
            }

            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return;
            }
            Toy[] toys =
                {
             new Toy("Лего Ниндзяги", 10000, 4, 10),
             new Toy("Кукла Барби", 7999, 0, 3),
             new Toy("Спинер", 350, 8, 14),
             new Toy("Пазл", 300, 4, 8),
             new Toy("Машинка", 2000, 2, 4),
             new Toy("Кубики", 400, 1, 3),
             new Toy("Аниме фигурка", 3750, 0, 3)
                };

            foreach (Toy toy in toys)
            {
                binaryWriter.Write(toy.Name);
                binaryWriter.Write(toy.Price);
                binaryWriter.Write(toy.MinAge);
                binaryWriter.Write(toy.MaxAge);
            }

            binaryWriter.Close();
        }


        public static void WriteDataStream1()
        {
            Validator validator = new Validator();
            int num;
            Random random = new Random();
            StreamWriter streamWriter;

            try
            {
                streamWriter = new StreamWriter("file3.txt", false);   
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return;
            }

            Console.Write("Введите количество данных, которое будет в файле: ");
            num = Convert.ToInt32(validator.check_int(Console.ReadLine()));

            for (int i = 0; i < num; ++i)
            {
                streamWriter.WriteLine(random.Next(1, 50));
            }
            streamWriter.Close();
        }


        public static void WriteDataStream2()
        {
            Validator validator = new Validator();
            int num;
            Random random = new Random();
            StreamWriter streamWriter;

            try
            {
                streamWriter = new StreamWriter("file4.txt", false);
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return;
            }

            Console.Write("Введите количество данных, которое будет в файле: ");
            num = Convert.ToInt32(validator.check_int(Console.ReadLine()));

            for (int i = 0; i < num; ++i)
            {
                for (int j = 0; j < random.Next(1, 4); ++j)
                {
                    streamWriter.Write(random.Next(1, 25));
                    streamWriter.Write(" ");
                }
                streamWriter.Write("\n");
            }

            streamWriter.Close();
        }


        public static int CountOfSquaresOfOddNumbers()
        {
            BinaryReader binaryReader;
            int num;
            int count = 0;

            try
            {
                binaryReader = new BinaryReader(new FileStream("file1.txt", FileMode.Open));   
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return 0;
            }

            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
                num = binaryReader.ReadInt32();
                for (int i = 1; i < Convert.ToInt32(Math.Sqrt(50)) + 1; i += 2)
                {
                    if ((i * i) == num)
                    {
                        count++;
                    }
                }
            }
            binaryReader.Close();
            return count;
        }


        public static double AriphmeticMeanMaxAndMin()
        {
            StreamReader streamReader;
            string s;
            int num;
            int maxNum = 0, minNum = 51;

            try
            {
                streamReader = new StreamReader("file3.txt");
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return 0;
            }

            while ((s = streamReader.ReadLine()) != null)
            {
                num = Convert.ToInt32(s);
                if (num > maxNum)
                {
                    maxNum = num;
                }

                if (num < minNum)
                {
                    minNum = num;
                }

            }
            streamReader.Close();
            return (maxNum + minNum) / 2.0;
        }


        public static int ProductOfOddElements()
        {
            StreamReader streamReader;
            int total = 1;
            string s;
            string[] number = new string[4];

            try
            {
                streamReader = new StreamReader("file4.txt");
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return 0;
            }

            while ((s = streamReader.ReadLine()) != null)
            {
                number = s.Split(' ');
                for (int i = 0; i < number.Length - 1; ++i)
                {
                    if (Convert.ToInt32(number[i]) % 2 == 0)
                    {
                        total *= Convert.ToInt32(number[i]);
                    }
                }
            }
            streamReader.Close();
            return total;
        }

        public static void IfNotLatinLetters()
        {
            StreamReader streamReader;
            StreamWriter streamWriter;
            string s;
            char[] latinLetters = {
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                    'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                    'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                    'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
                    'W', 'X', 'Y', 'Z' };

            try
            {
                streamReader = new StreamReader("file5.txt");
                streamWriter = new StreamWriter("file6.txt", false);
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return;
            }
            
            while ((s = streamReader.ReadLine()) != null) 
            {
                for (int i = 0; i < s.Length; ++i)
                {
                    if (latinLetters.Contains(s[i]) == true)
                    {
                        streamWriter.WriteLine(s);  
                        break;
                    }
                }
            }
            Console.WriteLine("Файл успешно создан!");
            streamReader.Close();
            streamWriter.Close();
            
        }

        public static Toy[] ReaderBinaryFile()
        {
            BinaryReader binaryReader;
            Toy[] toys = new Toy[7];
            int index = 0;

            try
            {
                binaryReader = new BinaryReader(new FileStream("file2.txt", FileMode.Open));
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return null;
            }
            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
                string name = binaryReader.ReadString();
                int price = binaryReader.ReadInt32();
                int minAge = binaryReader.ReadInt32();
                int maxAge = binaryReader.ReadInt32();

                toys[index] = new Toy(name, price, minAge, maxAge);
                index++;
            }

            return toys;
        }

        public static void SerializeToysToXML(Toy[] toys, string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Toy[]));
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    serializer.Serialize(writer, toys);
                }
                Console.WriteLine("Сериализовано в {0}", filename);
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return;
            }
        }

        public static Toy[] DeserializeToysFromXml(string filename)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Toy[]));
                using (StreamReader reader = new StreamReader(filename))
                {
                    var toys = (Toy[])serializer.Deserialize(reader);
                    Console.WriteLine("Десериализовано {0} игрушек из {1}", toys.Length, filename);
                    Console.WriteLine();
                    return toys;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка открытия файла!");
                return null;
            }
        }


        public static void FindMostExpensiveToyForChildrenYounger4()
        {
            Toy[] allToys = ReaderBinaryFile();

            if (allToys.Length == 0)
            {
                Console.WriteLine("Нет данных об игрушках в файле!");
                return;
            }

            Console.WriteLine("XML сериализация всех игрушек");
            Console.WriteLine();
            SerializeToysToXML(allToys, "all_toys.xml");

            Toy[] toysFromXml = DeserializeToysFromXml("all_toys.xml");

            int countYounger4 = 0;

            foreach (Toy toy in toysFromXml)
            {
                if (toy.MaxAge < 4)
                {
                    countYounger4++;
                }
            }

            
            if (countYounger4 == 0)
            {
                Console.WriteLine("Не найдено игрушек для детей до 4 лет");
                return;
            }

            Toy[] toysForUnder4 = new Toy[countYounger4];

            int index = 0;

            foreach (var toy in toysFromXml)
            {
                if (toy.MaxAge < 4)
                {
                    toysForUnder4[index] = toy;
                    Console.WriteLine("{0} - {1} руб.", toy.Name, toy.Price);
                    index++;
                } 
            }
            Console.WriteLine();

            Toy mostExpensive = toysForUnder4[0];

            for (int i = 0; i < toysForUnder4.Length; i++)
            {
                if (toysForUnder4[i].Price > mostExpensive.Price)
                {
                    mostExpensive = toysForUnder4[i];
                }
            }

            Console.WriteLine(mostExpensive);

            /*Toy[] resultArray = { mostExpensive };

            SerializeToysToXML(resultArray, "most_expensive_toy_result.xml"); */
        }    
    }
}
