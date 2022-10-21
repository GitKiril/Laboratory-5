using System;
using System.Collections.Generic;
using System.Text;

namespace ClassRoom
{
    internal class GoodPupil : Pupil
    {
        public override void Read()
        {
            Console.WriteLine("I can read a whole page in 20 seconds");
        }

        public override void Relax()
        {
            Console.WriteLine("I am relaxing with my friends in the park");
        }

        public override void Study()
        {
            Console.WriteLine("I am good pupil");
        }

        public override void Write()
        {
            Console.WriteLine("I write slowly but calligraphically");
        }
    }
}