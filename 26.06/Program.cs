using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._06
{
    /*class Man
    {
        private int age;//field
        public string name;
        protected int tall;
        public float another;
        public string getInfo()
        {
            String s = "Hello, my name is "+ name + ". I am "+age+
            " old. My tall is " + tall + ".";
            return s;
        }
        public int Age//Property
        {
            get { return age; }
            set
            {
                if (value > 18)
                {
                    age = value;
                }
            }
        }

        public Man(string _name, int _age, int _tall=10)
        {
            name = _name;
            age = _age;
            tall = _tall;
        }

        public Man()
        {
            name = "Misha";
            age = 18;
            tall = 180;
        }
        public override string ToString()
        {
            String s = "Hello, my name is " + name + ". I am " + age +
            " old. My tall is " + tall + ".";
            return s;
        }
    }*/
    class Guitar
    {
        private string name;
        private int id;
        private int price;
        private string wood;
        private string guitartype;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Wood
        {
            get { return wood; }
            set { wood = value; }
        }

        public string Guitartype
        {
            get { return guitartype; }
            set { guitartype = value; }
        }
    }

    class Inventory
    {
        private List<Guitar> GuitarList;
        private int idofguitar;

        public Inventory()
        {
            idofguitar = 0;
            GuitarList = new List<Guitar>();
        }
        public void AddGuitar(string _name, string _wood, int _price, string _guitartype)
        {
            Guitar g = new Guitar();
            g.Name = _name;
            g.Price = _price;
            g.Wood = _wood;
            g.Guitartype = _guitartype;
            g.Id = idofguitar;
            idofguitar++;
            GuitarList.Add(g);
        }
        
        public string ShowList()
        {
            String all = "";
            foreach (var item in GuitarList)
            {
                string temp = "ID: "+item.Id+"\nName: " + item.Name + "\nPrice: " + item.Price + "\nWood: " + item.Wood +
                              "\nGuitar Type: " + item.Guitartype;
                all += temp;
                all += "\n \n";
            }
            return all;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Inventory invent = new Inventory();
            invent.AddGuitar("socket", "red", 1599, "electro");
            invent.AddGuitar("socket2", "green", 1000, "standart");
            Console.Write(invent.ShowList());
            Console.ReadKey();
        }
    }
}
