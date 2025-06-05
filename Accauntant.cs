using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46_5
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return (int)worker < hours;
        }
    }
}
