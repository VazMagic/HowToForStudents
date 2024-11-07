using HowTo.Models;
using System.Collections.Generic;
using System.Data;

namespace HowTo.Processes
{
    public class ExportXML
    {
        public static bool ExportXMLData(DataTable data, string file)
        {
            //Table Name
            data.TableName = "ExportData";

            //Write DataTable as XML
            data.WriteXml(file);

            //Export was successful
            return true;
        }
    }
}
