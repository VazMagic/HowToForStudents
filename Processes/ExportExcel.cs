using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections.Generic;
using System.Data;

namespace HowTo.Processes
{
    /*********************************************************************************************************
     * INTEROP is often used to work with Microsoft Office Documents. If a user does NOT have Microsoft Office 
     * installed, the user will encounter an error. Using OpenXML will allow a user to export Microsoft Office 
     * Documents which can be viewed with Google Docs/Sheets, etc.
     * 
     * OpenXML Information
     * https://docs.microsoft.com/en-us/dotnet/api/documentformat.openxml.spreadsheet.worksheet?view=openxml-2.8.1
     * Microsoft Document Viewer
     * https://products.groupdocs.app/viewer/excel#:~:text=How%20to%20view%20Excel%20files%20online.%201%20Click,file%20pages%20in%20PNG%20or%20PDF%20format.%20
     *********************************************************************************************************/

    public class ExportExcel
    {
        //static WorkbookPart wkbkPart;

        public static bool ExportExcelData(DataTable dt, string file)
        {
            //Excel Workbook
            using (var excelWorkBook = SpreadsheetDocument.Create(file, DocumentFormat.OpenXml.SpreadsheetDocumentType.Workbook))
            {
                var wkbkPart = excelWorkBook.AddWorkbookPart();

                excelWorkBook.WorkbookPart.Workbook = new Workbook();
                excelWorkBook.WorkbookPart.Workbook.Sheets = new Sheets();

                //Excel Worksheets
                var worksheetPart = excelWorkBook.WorkbookPart.AddNewPart<WorksheetPart>();
                var worksheetData = new SheetData();

                worksheetPart.Worksheet = new Worksheet(worksheetData);

                Sheets sheets = excelWorkBook.WorkbookPart.Workbook.GetFirstChild<Sheets>();
                string relationshipId = excelWorkBook.WorkbookPart.GetIdOfPart(worksheetPart);

                uint id = 1;

                //Set the properties of the sheet
                Sheet sheet = new Sheet() 
                { 
                    Id = relationshipId, 
                    SheetId = id, 
                    Name = dt.TableName 
                };

                sheets.Append(sheet);

                //Create Header Row
                Row headerRow = new Row();

                //Get the Column Names for the Header Row
                List<string> columns = new List<string>();
                foreach (DataColumn column in dt.Columns)
                {
                    columns.Add(column.ColumnName);

                    Cell cell = new Cell();
                    cell.DataType = CellValues.String;
                    cell.CellValue = new CellValue(column.ColumnName);
                    headerRow.AppendChild(cell);
                }

                worksheetData.AppendChild(headerRow);

                //Get the data in the datatable 
                //To populate in excel
                foreach (DataRow dsrow in dt.Rows)
                {
                    Row newRow = new Row();

                    foreach (string col in columns)
                    {
                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;
                        cell.CellValue = new CellValue(dsrow[col].ToString()); 
                        newRow.AppendChild(cell);
                    }

                    worksheetData.AppendChild(newRow);
                }

                //Export was successful
                return true;
            }
        }
   }
}