using System.IO;
using HowTo.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;

namespace HowTo.DesignPatterns.Repository
{    
    public class LabAnalysisRepository : ILabAnalysisRepository
    {
        private readonly string _connectionString;

        public LabAnalysisRepository()
        {
            //Gets and Builds the Application Path of the applicatino location
            string basePath = CurrentPath.GetDbasePath() + "\\"; 
            //Gets name of the database
            string dbName = DbaseNames.LabDbase;
            //Combines the Path with the Database
            string path = Path.Combine(basePath, dbName); // Safely combines paths

            //Gets the Connection String from the App.Config file
            string dbase = ConfigurationManager.ConnectionStrings["AccessDbODBC"].ConnectionString;

            //Replaces {0} and {1} with correct values
            string cs = string.Format(dbase, DbaseNames.LabDriver, path);

            //Connection String we will use
            _connectionString = cs; 
        }

        public List<LabAnalysisProcedure> GetAllProcedures()
        {
            var procedures = new List<LabAnalysisProcedure>();

            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT LabAnalysisID, requested_anal_name, proced_name, proced_abbrev, proced_desc, 
                                 SSIR_5_Page, PDF_pg, Links_to_SSIR_42_V_5, notes
                                 FROM lab_analysis_procedure_table";

                using (var command = new OdbcCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            procedures.Add(new LabAnalysisProcedure
                            {
                                LabAnalysisID = reader.GetInt32(0),
                                RequestedAnalName = reader.GetString(1),
                                ProcedName = reader.GetString(2),
                                ProcedAbbrev = reader.GetString(3),
                                ProcedDesc = reader.GetString(4),
                                SSIR5Page = reader.GetInt32(5),
                                PDFPage = reader.GetInt32(6),
                                LinksToSSIR42V5 = reader.GetString(7),
                                Notes = reader.IsDBNull(8) ? null : reader.GetString(8)
                            });
                        }
                    }
                }
            }

            return procedures;
        }

        public LabAnalysisProcedure GetProcedureById(int labAnalysisId)
        {
            LabAnalysisProcedure procedure = null;

            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"SELECT LabAnalysisID, requested_anal_name, 
                                 proced_name, proced_abbrev, proced_desc, 
                                 SSIR_5_Page, PDF_pg, Links_to_SSIR_42_V_5, notes
                                 FROM lab_analysis_procedure_table
                                 WHERE LabAnalysisID = @LabAnalysisID";

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LabAnalysisID", labAnalysisId);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            procedure = new LabAnalysisProcedure
                            {
                                LabAnalysisID = reader.GetInt32(0),
                                RequestedAnalName = reader.GetString(1),
                                ProcedName = reader.GetString(2),
                                ProcedAbbrev = reader.GetString(3),
                                ProcedDesc = reader.GetString(4),
                                SSIR5Page = reader.GetInt32(5),
                                PDFPage = reader.GetInt32(6),
                                LinksToSSIR42V5 = reader.GetString(7),
                                Notes = reader.IsDBNull(8) ? null : reader.GetString(8)
                            };
                        }
                    }
                }
            }

            return procedure;
        }

        public void AddProcedure(LabAnalysisProcedure procedure)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"INSERT INTO lab_analysis_procedure_table 
                                 (requested_anal_name, proced_name, proced_abbrev, 
                                  proced_desc, SSIR_5_Page, PDF_pg, 
                                  Links_to_SSIR_42_V_5, notes)
                                 VALUES 
                                  (?, ?, ?, ?, ?, ?, ?, ?)";
                                /*
                                 (@RequestedAnalName, @ProcedName, @ProcedAbbrev, 
                                  @ProcedDesc, @SSIR5Page, @PDFPage, 
                                  @LinksToSSIR42V5, @Notes)";
                                */

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.Add(new OdbcParameter("@RequestedAnalName", OdbcType.NVarChar) { Value = procedure.RequestedAnalName });
                    command.Parameters.Add(new OdbcParameter("@ProcedName", OdbcType.NVarChar) { Value = procedure.ProcedName });
                    command.Parameters.Add(new OdbcParameter("@ProcedAbbrev", OdbcType.NVarChar) { Value = procedure.ProcedAbbrev });
                    command.Parameters.Add(new OdbcParameter("@ProcedDesc", OdbcType.NVarChar) { Value = procedure.ProcedDesc });
                    command.Parameters.Add(new OdbcParameter("@SSIR5Page", OdbcType.Int) { Value = procedure.SSIR5Page });
                    command.Parameters.Add(new OdbcParameter("@PDFPage", OdbcType.Int) { Value = procedure.PDFPage });
                    command.Parameters.Add(new OdbcParameter("@LinksToSSIR42V5", OdbcType.NVarChar) { Value = procedure.LinksToSSIR42V5 });
                    command.Parameters.Add(new OdbcParameter("@Notes", OdbcType.NVarChar) { Value = procedure.Notes });
                    
                    //Open the database connection
                    connection.Open();
                    //Insert the data
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProcedure(LabAnalysisProcedure procedure)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                string query = @"UPDATE lab_analysis_procedure_table 
                                 SET requested_anal_name = @RequestedAnalName, 
                                     proced_name = @ProcedName, 
                                     proced_abbrev = @ProcedAbbrev, 
                                     proced_desc = @ProcedDesc, 
                                     SSIR_5_Page = @SSIR5Page, 
                                     PDF_pg = @PDFPage, 
                                     Links_to_SSIR_42_V_5 = @LinksToSSIR42V5, 
                                     notes = @Notes
                                  WHERE LabAnalysisID = @LabAnalysisID";

                using (var command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RequestedAnalName", procedure.RequestedAnalName);
                    command.Parameters.AddWithValue("@ProcedName", procedure.ProcedName);
                    command.Parameters.AddWithValue("@ProcedAbbrev", procedure.ProcedAbbrev);
                    command.Parameters.AddWithValue("@ProcedDesc", procedure.ProcedDesc);
                    command.Parameters.AddWithValue("@SSIR5Page", procedure.SSIR5Page);
                    command.Parameters.AddWithValue("@PDFPage", procedure.PDFPage);
                    command.Parameters.AddWithValue("@LinksToSSIR42V5", procedure.LinksToSSIR42V5);
                    command.Parameters.AddWithValue("@Notes", procedure.Notes);
                    command.Parameters.AddWithValue("@LabAnalysisID", procedure.LabAnalysisID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProcedure(int labAnalysisId)
        {
            using (var connection = new OdbcConnection(_connectionString))
            {
                //Use ? as the placeholder for the parameter
                string query = @"DELETE FROM lab_analysis_procedure_table 
                                 WHERE LabAnalysisID = ?";

                using (var command = new OdbcCommand(query, connection))
                {
                    //Add the parameter (no need for parameter name, just value)
                    command.Parameters.AddWithValue("?", labAnalysisId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
