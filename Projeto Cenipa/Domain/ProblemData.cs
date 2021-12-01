using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.Domain
{
    public class ProblemData
    {
        public string InputPathDir { get; private set; }
        public string OutputPathDir { get; private set; }
        public Dictionary<string, List<Aircraft>> Aircrafts { get; set; }
        public Dictionary<string, List<ContribuingFactor>> ContribuingFactors { get; set; }
        public Dictionary<string, List<OccurrenceType>> OccurrenceTypes { get; set; }
        public Dictionary<string, Occurrence> Occurrences { get; set; }

   
        public ProblemData(string inputPathDir, string outputPathDir)
        {
            InputPathDir = inputPathDir;
            OutputPathDir = outputPathDir;
            Aircrafts = new Dictionary<string, List<Aircraft>>();
            ContribuingFactors = new Dictionary<string, List<ContribuingFactor>>();
            OccurrenceTypes = new Dictionary<string, List<OccurrenceType>>();
            Occurrences = new Dictionary<string, Occurrence>();
        }
    }
}