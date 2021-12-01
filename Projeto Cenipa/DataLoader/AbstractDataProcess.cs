using Projeto_Cenipa.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Cenipa.DataLoader
{
    public abstract class AbstractDataProcess
    {
        protected ProblemData problemData;

        protected AbstractDataProcess(ProblemData problemData)
        {
            this.problemData = problemData;
        }

        public abstract void BasicProcess();
    }
}