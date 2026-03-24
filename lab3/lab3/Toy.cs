using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab3
{
    [Serializable]
    [XmlRoot("Toy")]  // Для XML сериализации 
    public struct Toy
    {
        private string _name;
        private int _price;
        private int _minAge;
        private int _maxAge;

        [XmlElement("Name")]
        public string Name
        {
            get { return _name;  }
            set 
            {
                if (value != "" && value != null && string.IsNullOrEmpty(value) == false)
                {
                    _name = value;
                }
                else
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("У игрушки не может не быть названия!");
                        Console.Write("Введите название для игрушки: ");
                        value = Console.ReadLine();
                        if (value != "" && value != null && string.IsNullOrEmpty(value) == false)
                        {
                            _name = value;
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

        [XmlElement("Price")]
        public int Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    Validator validator = new Validator();
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Стоимость игрушки не может быть меньше 0");
                        Console.Write("Введите стоимость: ");
                        value = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        if (value >= 0)
                        {
                            _price = value;
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

        [XmlElement("MinAge")]
        public int MinAge
        {
            get { return _minAge; }
            set
            {
                if (value >= 0)
                {
                    _minAge = value;
                }
                else
                {
                    Validator validator = new Validator();
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Минимальный возраст для игрушки не может быть меньше 0");
                        Console.Write("Введите минимальный возраст: ");
                        value = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        if (value >= 0)
                        {
                            _minAge = value;
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

        [XmlElement("MaxAge")]
        public int MaxAge
        {
            get { return _maxAge; }
            set
            {
                if (value >= 0 && value > MinAge)
                {
                    _maxAge = value;
                }
                else
                {
                    Validator validator = new Validator();
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("Максимальный возраст для игрушки не может быть меньше 0 или меньше минимального возраста");
                        Console.Write("Введите максимальный возраст: ");
                        value = Convert.ToInt32(validator.check_int(Console.ReadLine()));
                        if (value >= 0 && value > MinAge)
                        {
                            _maxAge = value;
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


        public Toy(string name, int price, int minAge, int maxAge)
        {
            _name = "";
            _price = 0;
            _minAge = 0;
            _maxAge = 0;

            Name = name;
            Price = price;
            _maxAge = maxAge;
            MinAge = minAge;
            MaxAge = maxAge;
        }

        public override string ToString()
        {
            return "Название: " + Name + "\nЦена: " +  Price + " руб." + "\nВозраст: " + MinAge + " - " + MaxAge + " лет";
        }
    }
}
