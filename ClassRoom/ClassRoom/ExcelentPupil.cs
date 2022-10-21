using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    internal class ExcelentPupil : Pupil
    {

        public override void Read()
        {
            Console.WriteLine("I can read a whole page in 5 seconds");
        }

        public override void Study()
        {
            Console.WriteLine("I am excellent pupil");
            Console.WriteLine("I have excellent grades");
            
        }

        public override void Relax()
        {
            Console.WriteLine("I study more than I rest");
        }

        public override void Write()
        {
            Console.WriteLine("I write the fastest of all");
        }
    }
}
