using System;


namespace lab2
{
    internal class Cities
    {
        string name;
        string[] city_to;
        int[] cost;
        int count_paths;
        string result;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int[] Cost
        {
            get
            {
                return cost;
            }
            
        }
        public string[] City_to
        {
            get
            {
                return city_to;
            }
            
        }
        public int Count_paths
        {
            get
            {
                return count_paths;
            }
            set
            {
                count_paths = value;
            }
        }
        public string Result
        {
            get
            {
                return result ;
            }
            set
            {
                result = "";
            }
        }

        public Cities(string name)
        {
            this.Name = name;
            this.Count_paths = 3;
            this.city_to = new string[Count_paths];
            this.cost = new int[Count_paths];      
        }
        public Cities(string name, int count_paths)
        {
            this.Name = name;
            this.Count_paths = count_paths;
            this.city_to = new string[count_paths];
            this.cost = new int[count_paths];
        }

        public Cities(string name, string[] city_to, int[] cost)
        {
            this.Name = name;
            this.Count_paths = city_to.Length;
            this.city_to = city_to;
            this.cost = cost;
        }

        public void Collection_of_paths_if_passed()
        {
            result = "Город " + name + " и список, связаных с ним городов: [";
            for (int i = 0; i < count_paths; ++i)
            {
                result += city_to[i] + ":" + cost[i] + " ";
            }
            result = result.TrimEnd();
            result += "]";      
        }

        public void Collection_of_paths_if_not_passed(string[] name_city, int[] cost_to)
        {
            result = "Город " + name + " и список, связаных с ним городов: [";
            for (int i = 0; i < count_paths; ++i)
            {
                city_to[i] = name_city[i];
                cost[i] = cost_to[i];
                result += city_to[i] + ":" + cost[i] + " ";     
            }
            result = result.TrimEnd();
            result += "]";        
        }
        

        public override string ToString()
        {
            return result;
        }
    }
}
