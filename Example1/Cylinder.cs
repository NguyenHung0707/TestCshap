// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;


namespace GeoMetryExample
{
    class Cylinder
    {
        protected double radius;
        protected double height;
        private double BaseArea, LateralArea, TotalArea, Volume;


        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public Cylinder()
        {
        }

        public void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder ");

            Console.Write("Enter Radius : ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());

            BaseArea = radius * radius * Math.PI;
            LateralArea = 2 * Math.PI * radius * height;
            TotalArea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
            
            BaseArea = Math.Round(BaseArea, 2);
            LateralArea = Math.Round(LateralArea, 2);
            TotalArea = Math.Round(TotalArea, 2);
            Volume = Math.Round(Volume, 2);
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics ");
            Console.Write("Radius : " + radius);
            Console.Write("\nHeight : " + height);
            Console.WriteLine("\nBaseArea: " + BaseArea + "\nLateralArea: " +  LateralArea + "\nTotalArea: " + TotalArea + "\nVolume: " + Volume);
        }
    }
}