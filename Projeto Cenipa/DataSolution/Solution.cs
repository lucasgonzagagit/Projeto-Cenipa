using Projeto_Cenipa.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.DataSolution
{
    public class Solution
    {
        ProblemData ProblemData;

        public Solution(ProblemData problemData)
        {
            ProblemData = problemData;
        }

        public void BasicProcess()
        {
            Directory.CreateDirectory("Outputs");
            WriteOccurrenceTypesOutput();
            WriteOccurrenceByRegionOutput();
            WriteOccurrenceByYearOutput();
            WriteOccurrenceByEngineQuantityOutput();
        }

        void WriteOccurrenceTypesOutput()
        {
            var occurranceTypesDictionary = new Dictionary<string, Dictionary<string, int>>();
            foreach(var occurrence in ProblemData.Occurrences.Values)
            {
                foreach(var occurenceType in occurrence.OccurrenceTypes)
                {
                    if (!occurranceTypesDictionary.ContainsKey(occurenceType.Type))
                        occurranceTypesDictionary[occurenceType.Type] = new Dictionary<string, int>();

                    if (!occurranceTypesDictionary[occurenceType.Type].ContainsKey(occurrence.Classification))
                        occurranceTypesDictionary[occurenceType.Type][occurrence.Classification] = 0;

                    occurranceTypesDictionary[occurenceType.Type][occurrence.Classification] += 1;
                }
            }

            var sorted = occurranceTypesDictionary.OrderByDescending(x => x.Value.Values.Sum()).ToList();

            using (var writer = new StreamWriter(@"Outputs\OccurrenceTypesOutput.csv"))
            {
                writer.Write("Tipo Ocorrencia; Acidente; Incidente Grave; Incidente");
                writer.WriteLine();
                foreach (var item in occurranceTypesDictionary.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    writer.Write(item.Key + ";");

                    var acidente = "0";
                    var incidenteGrave = "0";
                    var incidente = "0";

                    if (item.Value.ContainsKey("ACIDENTE"))
                        acidente = item.Value["ACIDENTE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE GRAVE"))
                        incidenteGrave = item.Value["INCIDENTE GRAVE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE"))
                        incidente = item.Value["INCIDENTE"].ToString();

                    writer.Write(acidente + ";" + incidenteGrave + ";" + incidente);
                    writer.WriteLine();
                }
            }
        }

        void WriteOccurrenceByRegionOutput()
        {
            var occurrenceByRegion = new Dictionary<string, Dictionary<string, int>>();
            foreach (var occurrence in ProblemData.Occurrences.Values)
            {
                var occurenceUf = occurrence.Region.Uf;
                
                if (!occurrenceByRegion.ContainsKey(occurenceUf))
                    occurrenceByRegion[occurenceUf] = new Dictionary<string, int>();

                if (!occurrenceByRegion[occurenceUf].ContainsKey(occurrence.Classification))
                    occurrenceByRegion[occurenceUf][occurrence.Classification] = 0;

                occurrenceByRegion[occurenceUf][occurrence.Classification] += 1;
            }

            var sorted = occurrenceByRegion.OrderByDescending(x => x.Value.Values.Sum()).ToList();

            using (var writer = new StreamWriter(@"Outputs\OccurrenceByRegion.csv"))
            {
                writer.Write("UF; Acidente; Incidente Grave; Incidente");
                writer.WriteLine();
                foreach (var item in occurrenceByRegion.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    writer.Write(item.Key + ";");

                    var acidente = "0";
                    var incidenteGrave = "0";
                    var incidente = "0";

                    if (item.Value.ContainsKey("ACIDENTE"))
                        acidente = item.Value["ACIDENTE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE GRAVE"))
                        incidenteGrave = item.Value["INCIDENTE GRAVE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE"))
                        incidente = item.Value["INCIDENTE"].ToString();

                    writer.Write(acidente + ";" + incidenteGrave + ";" + incidente);
                    writer.WriteLine();
                }
            }
        }

        void WriteOccurrenceByYearOutput()
        {
            var occurranceByYearDictionary = new Dictionary<string, Dictionary<string, int>>();
            foreach (var occurrence in ProblemData.Occurrences.Values)
            {
                foreach (var aircraft in occurrence.Aircrafts)
                {
                    if (!occurranceByYearDictionary.ContainsKey(aircraft.Year))
                        occurranceByYearDictionary[aircraft.Year] = new Dictionary<string, int>();

                    if (!occurranceByYearDictionary[aircraft.Year].ContainsKey(occurrence.Classification))
                        occurranceByYearDictionary[aircraft.Year][occurrence.Classification] = 0;

                    occurranceByYearDictionary[aircraft.Year][occurrence.Classification] += 1;
                }
            }

            var sorted = occurranceByYearDictionary.OrderByDescending(x => x.Value.Values.Sum()).ToList();

            using (var writer = new StreamWriter(@"Outputs\OccurrenceByYearOutput.csv"))
            {
                writer.Write("YEAR; Acidente; Incidente Grave; Incidente");
                writer.WriteLine();
                foreach (var item in occurranceByYearDictionary.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    writer.Write(item.Key + ";");

                    var acidente = "0";
                    var incidenteGrave = "0";
                    var incidente = "0";

                    if (item.Value.ContainsKey("ACIDENTE"))
                        acidente = item.Value["ACIDENTE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE GRAVE"))
                        incidenteGrave = item.Value["INCIDENTE GRAVE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE"))
                        incidente = item.Value["INCIDENTE"].ToString();

                    writer.Write(acidente + ";" + incidenteGrave + ";" + incidente);
                    writer.WriteLine();
                }

            }
        }

        void WriteOccurrenceByEngineQuantityOutput()
        {
            var occurranceByEngineQuantityDictionary = new Dictionary<string, Dictionary<string, int>>();
            foreach (var occurrence in ProblemData.Occurrences.Values)
            {
                foreach (var aircraft in occurrence.Aircrafts)
                {
                    if (!occurranceByEngineQuantityDictionary.ContainsKey(aircraft.EngineQuantity))
                        occurranceByEngineQuantityDictionary[aircraft.EngineQuantity] = new Dictionary<string, int>();

                    if (!occurranceByEngineQuantityDictionary[aircraft.EngineQuantity].ContainsKey(occurrence.Classification))
                        occurranceByEngineQuantityDictionary[aircraft.EngineQuantity][occurrence.Classification] = 0;

                    occurranceByEngineQuantityDictionary[aircraft.EngineQuantity][occurrence.Classification] += 1;
                }
            }

            var sorted = occurranceByEngineQuantityDictionary.OrderByDescending(x => x.Value.Values.Sum()).ToList();

            using (var writer = new StreamWriter(@"Outputs\OccurrenceByEngineQuantityOutput.csv"))
            {
                writer.Write("YEAR; Acidente; Incidente Grave; Incidente");
                writer.WriteLine();
                foreach (var item in occurranceByEngineQuantityDictionary.OrderByDescending(x => x.Value.Values.Sum()))
                {
                    writer.Write(item.Key + ";");

                    var acidente = "0";
                    var incidenteGrave = "0";
                    var incidente = "0";

                    if (item.Value.ContainsKey("ACIDENTE"))
                        acidente = item.Value["ACIDENTE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE GRAVE"))
                        incidenteGrave = item.Value["INCIDENTE GRAVE"].ToString();
                    if (item.Value.ContainsKey("INCIDENTE"))
                        incidente = item.Value["INCIDENTE"].ToString();

                    writer.Write(acidente + ";" + incidenteGrave + ";" + incidente);
                    writer.WriteLine();
                }

            }
        }

    }
}
