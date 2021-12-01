using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.Domain
{
    public class Occurrence
    {
        public string Code { get; set; }
        public List<OccurrenceType> OccurrenceTypes { get; set; }
        public List<ContribuingFactor> ContribuingFactors { get; set; }
        public List<Aircraft> Aircrafts { get; set;  }
        public string Classification { get; set; }
        public Region Region { get; set; }
        public string Aedrome { get; set; }
        public DateTime Period { get; set; }

        public Occurrence()
        {

        }

    }
}
