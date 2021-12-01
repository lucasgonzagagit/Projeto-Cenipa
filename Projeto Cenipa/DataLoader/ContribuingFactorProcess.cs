using Projeto_Cenipa.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.DataLoader
{
    public class ContribuingFactorProcess : AbstractDataProcess
    {
        public ContribuingFactorProcess(ProblemData problemData) : base(problemData)
        {
        }

        public override void BasicProcess()
        {
            StreamReader rd = new StreamReader(@"Inputs\fator_contribuinte.csv", Encoding.Default, true);

            string headerLine = rd.ReadLine();
            string line = null;
            string[] splitLine = null;

            while ((line = rd.ReadLine()) != null)
            {
                splitLine = line.Split(';');

                var contribuingFactor = new ContribuingFactor();
                contribuingFactor.OccurrenceCode = splitLine[0];
                contribuingFactor.Name = splitLine[1];
                contribuingFactor.AspectFactor = splitLine[2];
                contribuingFactor.ConditioningFactor = splitLine[3];
                contribuingFactor.FactorArea = splitLine[4];

                if (!problemData.ContribuingFactors.ContainsKey(contribuingFactor.OccurrenceCode))
                    problemData.ContribuingFactors[contribuingFactor.OccurrenceCode] = new List<ContribuingFactor>();

                problemData.ContribuingFactors[contribuingFactor.OccurrenceCode].Add(contribuingFactor);
            }
        }

    }
}
