using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprog3
{
    internal class UserClass
    {
        public string Name { get; set; }
        public List<Cars> Cars { get; set; }

        public UserClass(string name)
        {
            Name = name;
            Cars = new List<Cars>();
        }
    }


}