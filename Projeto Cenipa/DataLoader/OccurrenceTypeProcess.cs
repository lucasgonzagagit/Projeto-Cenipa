using Projeto_Cenipa.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.DataLoader
{
    class OccurrenceTypeProcess : AbstractDataProcess
    {
        public OccurrenceTypeProcess(ProblemData problemData) : base(problemData)
        {
        }

        public override void BasicProcess()
        {
            StreamReader rd = new StreamReader(@"Inputs\ocorrencia_tipo.csv", Encoding.Default, true);

            string headerLine = rd.ReadLine();
            string line = null;
            string[] splitLine = null;

            while ((line = rd.ReadLine()) != null)
            {
                splitLine = line.Split(';');

                var occurrenceType = new OccurrenceType();
                occurrenceType.OccurrenceCode = splitLine[0];
                occurrenceType.Type = splitLine[1];
                occurrenceType.CategoryType = splitLine[2];

                if (!problemData.OccurrenceTypes.ContainsKey(occurrenceType.OccurrenceCode))
                    problemData.OccurrenceTypes[occurrenceType.OccurrenceCode] = new List<OccurrenceType>();

                problemData.OccurrenceTypes[occurrenceType.OccurrenceCode].Add(occurrenceType);
            }
        }
    }
}
