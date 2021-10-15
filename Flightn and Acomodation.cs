using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FlightnAccomodation
    {//public atributes
        private string from;
        private string To;

        //property structures
        public string propFrom
        
        {
            get { return from; }
            set { from = value; }

        }

        public string propTo

        {
            get { return To; }
            set { To = value; }

        }

        //Default contructor 
        public FlightnAccomodation()
        {
            propFrom = "";
            propTo = "";
        }

        //
    }
}
