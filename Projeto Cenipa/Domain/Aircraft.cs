using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.Domain
{
    public class Aircraft
    {
        public string OccurrenceCode { get; set; }
        public string Registration { get; set; }
        public string CategoryOperator { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string EngineType { get; set; }
        public string EngineQuantity { get; set; }
        public string ManufacturerCountry { get; set; }
        public string Year { get; set; }
        public string OperationPhase { get; set; }
        public string OperationType { get; set; }
        public int Fatalities { get; set; }

        public Aircraft()
        {

        }

    }
}
