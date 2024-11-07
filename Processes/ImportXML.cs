using System;
using System.Data;

namespace HowTo.Processes
{
    public class ImportXML
    {
        static DataSet ds = new DataSet();

        public static DataSet GetXMLData(string file)
        {
            ds.ReadXml(file);

            ds = DataSetTableFunctions.FixDateTimeCol(ds);
            ds = DataSetTableFunctions.FixCurrencyCol(ds);

            return ds;
        }


    }
}
