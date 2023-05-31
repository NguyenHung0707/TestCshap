// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Animal
{
    class Animal
    {
        protected string name;
        protected double weight;

        public Animal(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public Animal()
        {
        }

        public void SetMe(string Name, double Weight)
        {
            name = Name;
            weight = Weight;
        }

        public void Show()
        {
            Console.WriteLine("Name : " + name + "weight : " +  weight);
        }
    }
}