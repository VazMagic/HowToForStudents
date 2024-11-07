using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportExportData.Events
{
    /************************************
     * Custom EVENT Class
     * **********************************/

    public class UpdateDataGridViewEventArgs : EventArgs
    {
        private DataSet _ds = null;

        public UpdateDataGridViewEventArgs(DataSet ds)
        {
            _ds = ds;
        }

        public DataSet GetDataSet
        {
            get
            {
                return _ds;
            }
        }
    }
}
