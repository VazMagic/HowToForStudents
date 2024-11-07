using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.DesignPatterns.Repository
{
    public interface ILabAnalysisRepository
    {
        List<LabAnalysisProcedure> GetAllProcedures();
        LabAnalysisProcedure GetProcedureById(int labAnalysisId);
        void AddProcedure(LabAnalysisProcedure procedure);
        void UpdateProcedure(LabAnalysisProcedure procedure);
        void DeleteProcedure(int labAnalysisId);
    }
}
