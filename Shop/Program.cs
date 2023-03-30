using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте класс «Магазин». Необходимо хранить в
//полях класса: название магазина, адрес, описание профиля магазина, контактный телефон, контактный e-mail.
//Реализуйте методы класса для ввода данных, вывода
//данных, реализуйте доступ к отдельным полям через методы класса.
namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Store st = new Store("Tavria", "Koroleva, 32", "products", "05033344455", "market@gmail.com");
            Store st1 = new Store("Mr.Dog", "Vavilova, 2", "goods for animals", "05022244400", "pet@gmail.com");
           
            st.Print();
            st1.Print();
            Store st2 = new Store("only tel 0503433333"); //constructor this
        }


    }

    class Store

    {
        public Store() { Console.WriteLine("default const"); }
        public Store(string t) : this("Tavria", "Koroleva, 32", "products", "05033344455", "market@gmail.com")
        {
            Console.WriteLine(t);
        }

        public Store(string n, string ad, string type, string t, string em ) // Конструктор класса
        {
            Name = n;
            Address = ad;
            info = type;
            Tel = t;
            Email = em;

        }

        string name;
        public string Name 
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
            }
        }

        string address;
        public string Address 
        {
            get
            {
                return address;
            }
            set
            {
                if (value != "")
                    address = value;
            }
        }
        public string info{ get; set; }
        string tel;
        public string Tel 
        {
            get
            {
                return tel;
            }
            set
            {
                if (value != "")
                    tel = value;
            }
        }
        string emaill;
        public string Email { get; set; }

        public void Print()
        {
            Console.WriteLine($"Our store named {Name} has address {Address} and sells {info}. ");
            Console.WriteLine($"Our tel. is { Tel } and our email is {Email}");
        }

    }
}
    
