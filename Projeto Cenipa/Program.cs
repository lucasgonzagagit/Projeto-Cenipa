using Projeto_Cenipa.DataLoader;
using Projeto_Cenipa.Domain;
using Projeto_Cenipa.DataSolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa
{
    class Program
    {
        static string ouputPathDir = Environment.CurrentDirectory;  // updated by command line
        static string inputPathDir = Environment.CurrentDirectory;  // updated by command line

        static void Main(string[] args)
        {

            // Load problem data
            ProblemData problemData;
            ouputPathDir = "\\";  // output directory
            inputPathDir = ouputPathDir;    // input directory

            Console.WriteLine("Loading data...");

            LoadProblemData(inputPathDir, ouputPathDir, out problemData);

            Console.WriteLine("Data successffully loaded...");

            Console.WriteLine("Writing outputs...");

            WriteSolution(inputPathDir, ouputPathDir, problemData);

            Console.WriteLine("Solution successffully Written...");
        }

        public static void LoadProblemData(string inputPathDir, string ouputPathDir, out ProblemData problemData)
        {
            problemData = null;

            problemData = new ProblemData(inputPathDir, ouputPathDir);
            var processData = new ProcessData(problemData);
            processData.BasicProcess();
        }

        public static void WriteSolution(string inputPathDir, string ouputPathDir, ProblemData problemData)
        {
            var solutionData = new Solution(problemData);
            solutionData.BasicProcess();
        }

    }
}
