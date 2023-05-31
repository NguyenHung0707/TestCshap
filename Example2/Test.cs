using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Test
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger();
            Lion lion = new Lion();

            tiger.SetMe("tiger ", 100);
            tiger.Show();

            lion.SetMe("lion ", 200);
            lion.Show();
        }
    }
}
