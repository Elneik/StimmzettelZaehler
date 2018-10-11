using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stimmzettel
{
    class Kandidat
    {
        public string name;
        public int stimmen;

        public Kandidat(string name, int stimmen)
        {
            this.name = name;
            this.stimmen = stimmen;
        }
    }
}
