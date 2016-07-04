using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
       
        private int id=5; //private variable
        public String name; //public variable
        private readonly string logo; //readonly variable/keyword
        private const string key = "promact"; //doesn't be changed over the life of program

        public Program()//default constructor
        {
            logo = "build ur self by builidng projects";//only chnged by non-static costructor
            Console.WriteLine(id);
        }


       public Program(int id,String name)//parameterized constructor
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("employee id=" + id + "employee name=" + name+" ......//parameterized constructor");
        }

        public Program(Program p3)//copy constructor
        {
            id = p3.id;
            name = p3.name;
            Console.WriteLine("id=" + id + "name=" + name);
        }

        public int id1//public property
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        ~Program()//destructor
        {
            Console.WriteLine("destructor");
        }




        public static void Main(string[] args)
        {
            Program p1 = new Program();
             Program p2 = new Program(1, "priyaaa");
            Program p4 = new Program(p2);
            p1.id1 = 111;
            Console.WriteLine("new value=" + p1.id1);

           
        }


    }
}
