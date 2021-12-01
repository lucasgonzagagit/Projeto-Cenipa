using Projeto_Cenipa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.DataLoader
{
    public class ProcessData : AbstractDataProcess
    {
        public ProcessData(ProblemData problemData) : base(problemData)
        {
        }

        public override void BasicProcess()
        {
            AircraftProcess aircraftProcess = new AircraftProcess(problemData);
            aircraftProcess.BasicProcess();

            ContribuingFactorProcess contribuingFactorProcess = new ContribuingFactorProcess(problemData);
            contribuingFactorProcess.BasicProcess();

            OccurrenceTypeProcess occurrenceTypeProcess = new OccurrenceTypeProcess(problemData);
            occurrenceTypeProcess.BasicProcess();

            OccurrenceProcess occurrenceProcess = new OccurrenceProcess(problemData);
            occurrenceProcess.BasicProcess();
        }
    }
}
