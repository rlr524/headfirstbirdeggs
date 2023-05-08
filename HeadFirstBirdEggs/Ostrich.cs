using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstBirdEggs
{
    internal class Ostrich : Bird
    {
        public override Egg[] LayEggs(Egg[] eggs)
        {
            Egg egg = new Egg(12, "speckled");
            return egg[0];
        }
    }
}
