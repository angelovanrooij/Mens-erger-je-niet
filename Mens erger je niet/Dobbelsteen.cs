using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mens_erger_je_niet
{
    public class Dobbelsteen
    {

        int Gedobbeld;

        public Dobbelsteen()
        {

        }

        public int Dobbelen()
        {
            Random r = new Random();
            Gedobbeld = r.Next(1,7);
            return Gedobbeld;
        }
    }

}
