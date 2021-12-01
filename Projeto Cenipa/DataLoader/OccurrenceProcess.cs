using Projeto_Cenipa.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.DataLoader
{
    class OccurrenceProcess : AbstractDataProcess
    {
        public OccurrenceProcess(ProblemData problemData) : base(problemData)
        {
        }

        public override void BasicProcess()
        {
            StreamReader rd = new StreamReader(@"Inputs\ocorrencia.csv", Encoding.Default, true);

            string headerLine = rd.ReadLine();
            string line = null;
            string[] splitLine = null;

            while ((line = rd.ReadLine()) != null)
            {
                splitLine = line.Split(';');

                var occurrence = new Occurrence();
                occurrence.Code = splitLine[0];
                occurrence.Classification = splitLine[5];
                occurrence.Region = new Region(splitLine[8], splitLine[9], splitLine[10]);
                occurrence.Aedrome = splitLine[11];
                var stringDate = splitLine[12].Split('/');
                occurrence.Period = new DateTime(Convert.ToInt32(stringDate[2]), Convert.ToInt32(stringDate[1]), Convert.ToInt32(stringDate[0]));

                if (problemData.Aircrafts.ContainsKey(occurrence.Code))
                    occurrence.Aircrafts = problemData.Aircrafts[occurrence.Code];
                if (problemData.OccurrenceTypes.ContainsKey(occurrence.Code))
                    occurrence.OccurrenceTypes = problemData.OccurrenceTypes[occurrence.Code];
                if (problemData.ContribuingFactors.ContainsKey(occurrence.Code))
                    occurrence.ContribuingFactors = problemData.ContribuingFactors[occurrence.Code];

                if (!problemData.Occurrences.ContainsKey(occurrence.Code))
                    problemData.Occurrences.Add(occurrence.Code, occurrence);
            }
        }
    }
}
