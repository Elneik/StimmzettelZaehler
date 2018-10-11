using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stimmzettel
{
    [Serializable]
    public class Stimmzettel
    {
        public int id;
        public List<String> gewaehlteKandidaten;

        public Stimmzettel(int id, List<String> gewaehlteKandidaten)
        {
            this.id = id;
            this.gewaehlteKandidaten = gewaehlteKandidaten;
        }

    }
}
