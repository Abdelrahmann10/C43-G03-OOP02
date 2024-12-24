using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Demo
{
    internal class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }
        public Car(int _Id, string _Model) : this(_Id,_Model,150)
        {
            Console.WriteLine("const 02");

            //Id = _Id;
            //Model = _Model;
            //Speed = 150;
        }
        public Car(int _Id)
        {
            Console.WriteLine("const 03");

            Id = _Id;
            Model = "KIA";
            Speed = 100;
        }
        public Car(int _Id, string _Model, double _Speed)
        {
            Console.WriteLine("const 01");
            Id = _Id;
            Model = _Model;
            Speed = _Speed;
        }

        public override string ToString()
        {
            return $"Car Id = {Id}\nModel Is {Model} Speed{Speed}";
        }
    }
}
