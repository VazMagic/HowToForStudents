namespace HowTo.Models
{
    public static class DbaseNames
    {
        /*********************************************************
         * 1. Right click on the project name
         * 2. Select Properties
         * 3. Go To Build
         * 4. Uncheck "Prefer 32-bit"
         *********************************************************/

        public static string LabDbase { get; } = "NCSSLabDataMartAccess-Sample.mdb";
        public static string LabDriver { get; } = "{Microsoft Access Driver (*.mdb, *.accdb)}";
        public static string DSNName { get; } = "MSAccessDSN64.dsn";
    }
}
