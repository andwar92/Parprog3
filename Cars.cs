using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Parprog3
{
    internal class Cars
    {
        public string Model {  get; set; }
        public int Year { get; set; }
        public string RegNr { get; set; }
        public int Kilometer { get; set; }
 
        public Cars(string model, int year, string regNr, int kilometer)
        {
            Model = model;
            Year = year;
            RegNr = regNr;
            Kilometer = kilometer;
        }
    }
}
