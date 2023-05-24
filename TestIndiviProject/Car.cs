using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIndiviProject
{
    [Serializable] public class Car
    {
        public int Speed { get; set; }
        public string Name { get; set; }

        public Car(int speed, string name) 
        {
            Speed = speed;
            Name = name;
        }
    }

}
