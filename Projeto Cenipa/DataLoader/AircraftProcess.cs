using Projeto_Cenipa.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.DataLoader
{
    class AircraftProcess : AbstractDataProcess
    {
        public AircraftProcess(ProblemData problemData) : base(problemData)
        {
        }

        public override void BasicProcess()
        {
            StreamReader rd = new StreamReader(@"Inputs\aeronave.csv", Encoding.Default, true);

            string headerLine = rd.ReadLine();
            string line = null;
            string[] splitLine = null;

            while ((line = rd.ReadLine()) != null)
            {
                splitLine = line.Split(';');

                var aircraft = new Aircraft();
                aircraft.OccurrenceCode = splitLine[0];
                aircraft.Registration = splitLine[1];
                aircraft.CategoryOperator = splitLine[2];
                aircraft.Type = splitLine[3];
                aircraft.Manufacturer = splitLine[4];
                aircraft.Model = splitLine[5];
                aircraft.EngineType = splitLine[7];
                aircraft.EngineQuantity = splitLine[8];
                aircraft.Year = splitLine[12];
                aircraft.ManufacturerCountry = splitLine[13];
                aircraft.OperationPhase = splitLine[19];
                aircraft.OperationType = splitLine[20];
                aircraft.Fatalities = Convert.ToInt32(splitLine[22]);

                if (!problemData.Aircrafts.ContainsKey(aircraft.OccurrenceCode))
                    problemData.Aircrafts[aircraft.OccurrenceCode] = new List<Aircraft>();

                problemData.Aircrafts[aircraft.OccurrenceCode].Add(aircraft);
            }
        }
    }
}
