using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2
{
    class Country
    {
        public string name { get; private set; }

        public int size { get; set; }

        public Country(string name, int size)
        {
            this.size = size;
            this.name = name;
        }

        public override string ToString()
        {
            return "name: " + name + " population size:" + size;
        }

    }

}

