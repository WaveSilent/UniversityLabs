using System;


namespace lab2
{
    internal class Names
    {
        string surname;
        string name;
        string middle_name;

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {            
                surname = value;             
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "" && value != null && string.IsNullOrEmpty(value)==false)
                {
                    name = value;
                }
                else
                {               
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("У человека не может не быть имени!");
                        Console.Write("Введите имя: ");
                        value = Console.ReadLine();
                        if (value != "" && value != null && string.IsNullOrEmpty(value) == false)
                        {
                            name = value;
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
        public string Middle_name
        {
            get
            {
                return middle_name;
            }
            set
            {               
                middle_name = value;               
            }
        }

        public Names(string surname, string name, string middle_name)
        {
            this.Surname = surname;
            this.Name = name;
            this.Middle_name = middle_name;
        }

        public override string ToString()
        {
            if (surname == "" && middle_name != "")
            { 
                return name + " " + middle_name;
            }
            else if (middle_name == "" && surname != "")
            {
                return surname + " " + name;
            } 
            else if (surname == "" && middle_name == "")
            {
                return name;
            }
            else
            {
                return surname + " " + name + " " + middle_name;
            }
        }
    }
}
