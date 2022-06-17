using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerToPlantUML.Model
{
    [DebuggerDisplay("ColumnName = {column_name}, DataType = {data_type}")]
    public class SqlColumn
    {
        public string column_name { get; set; }
        public string is_nullable { get; set; }
        public string data_type { get; set; }
        public bool is_primary_key { get; set; }
        public bool is_foreign_key { get; set; }
    }
}
