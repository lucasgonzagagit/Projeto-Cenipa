using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.Domain
{
    public class ContribuingFactor
    {
        public string OccurrenceCode { get; set; }
        public string Name { get; set; }
        public string FactorArea { get; set; }
        public string ConditioningFactor { get; set; }
        public string AspectFactor { get; set; }

        public ContribuingFactor()
        {

        }
    }
}
