using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerToPlantUML.Model
{
    [DebuggerDisplay("Schema = {schema_name}, TableName = {table_name}")]
    public class SqlTable
    {
        public int schema_id { get; set; }
        public string schema_name { get; set; }
        public string table_name { get; set; }
        public int object_id { get; set; }
        public string full_name { get; set; }
        public List<SqlColumn> columnList { get; set; } = new List<SqlColumn>();
        public List<ForeignKeyConstraint> foreign_key_list { get; set; } = new List<ForeignKeyConstraint>();
    }
}
