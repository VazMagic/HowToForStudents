using ExcelDataReader;
using System.Data;
using System.IO;
using System.Text;

namespace HowTo.Processes
{
    public static class ImportExcel
    {
        public static DataSet GetExcelData(string file)
        {
            DataSet ds = new DataSet();
            IExcelDataReader excelReader = null;

            using (FileStream stream = File.Open(file, FileMode.Open, FileAccess.Read))
            {

                if (Path.GetExtension(file) == ".xls")
                {
                    //Reading from a binary Excel file ('97-2003 format; *.xls)
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else if (Path.GetExtension(file) == ".xlsx")
                {
                    //Reading from a OpenXml Excel file (2007 format; *.xlsx)
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                else if (Path.GetExtension(file) == ".csv")
                {

                    stream.Seek(0L, SeekOrigin.Begin);
                    /*
                    using (var excelReader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration() { FallbackEncoding = System.Text.Encoding.GetEncoding(1252) }))
                    {
                        ds = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            UseColumnDataType = false,
                            ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                        }).Tables[0];
                    }
                    */

                    excelReader = ExcelReaderFactory.CreateCsvReader(stream);

                    excelReader = ExcelReaderFactory.CreateCsvReader(stream, new ExcelReaderConfiguration()
                    {

                        // Gets or sets the encoding to use when the input XLS lacks a CodePage
                        // record, or when the input CSV lacks a BOM and does not parse as UTF8. 
                        // Default: cp1252. (XLS BIFF2-5 and CSV only)
                        //FallbackEncoding = Encoding.GetEncoding(1252),

                        
                        // Gets or sets the password used to open password protected workbooks.
                        //Password = "password",

                        // Gets or sets an array of CSV separator candidates. The reader 
                        // autodetects which best fits the input data. Default: , ; TAB | # 
                        // (CSV only)
                        AutodetectSeparators = new char[] { ',', ';', '\t', '|', '#' }
                    });
                }
                else
                {
                    return ds;
                }

                //Get DataSet - The spreadsheet will be created in the ds.Tables
                ds = excelReader.AsDataSet();
            }

            //Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();

            return ds;
        }

        public static DataSet GetExcelDataXLS(string file)
        {
            DataSet ds = new DataSet();

            FileStream stream = File.Open(file, FileMode.Open, FileAccess.Read);

            //Reading from a binary Excel file ('97-2003 format; *.xls)
            IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);

            //Get DataSet - The spreadsheet will be created in the ds.Tables
            ds = excelReader.AsDataSet();

            //Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();

            return ds;
        }
    }
}
