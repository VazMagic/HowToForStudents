using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowTo.Processes
{
    public static class DataSetTableFunctions
    {
        static string value = string.Empty;

        #region DataSet
        public static DataSet FixDateTimeCol(DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    value = row[1].ToString();
                    string s = value.Substring(value.Length - 3, 3);

                    if (value.Contains("T"))
                    {
                        value = value.Substring(0, value.IndexOf("T"));
                        value = value.Replace("-", "/");
                        DateTime date = DateTime.Parse(value);
                        value = string.Format("{0:MM/d/yyyy}", date);
                        row[1] = value;
                    }
                    else if ((s == " AM") || (s == " PM"))
                    {
                        DateTime date = DateTime.Parse(value);
                        value = string.Format("{0:MM/d/yyyy}", date);
                        row[1] = value;
                    }
                }

                dt.AcceptChanges();
            }

            return ds;
        }

        public static DataSet FixCurrencyCol(DataSet ds)
        {
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    value = row[5].ToString();

                    int amt = int.Parse(value);

                    row[5] = string.Format("{0:#,###,###,##0}", amt);
                }

                dt.AcceptChanges();
            }

            return ds;
        }
        #endregion

        #region DataTable
        public static DataTable FixDateTimeCol(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                value = row[1].ToString();
                string s = value.Substring(value.Length - 3, 3);

                if (value.Contains("T"))
                {
                    value = value.Substring(0, value.IndexOf("T"));
                    value = value.Replace("-", "/");
                    DateTime date = DateTime.Parse(value);
                    value = string.Format("{0:MM/d/yyyy}", date);
                    row[1] = value;
                }
                else if ((s == " AM") || (s == " PM"))
                {
                    DateTime date = DateTime.Parse(value);
                    value = string.Format("{0:MM/d/yyyy}", date);
                    row[1] = value;
                }
            }

            dt.AcceptChanges();

            return dt;
        }

        public static DataTable FixCurrencyCol(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                value = row[5].ToString();

                int amt = int.Parse(value);

                row[5] = string.Format("{0:#,###,###,##0}", amt);
            }

            dt.AcceptChanges();

            return dt;
        }
        #endregion

    }
}
