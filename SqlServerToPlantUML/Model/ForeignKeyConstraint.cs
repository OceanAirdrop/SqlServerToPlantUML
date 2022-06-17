using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerToPlantUML.Model
{
    [DebuggerDisplay("FK = {foreign_key_name}")]
    public class ForeignKeyConstraint
    {
        public int object_id { get; set; }
        public int parent_object_id { get; set; }
        public string fk_schema_name { get; set; }
        public string fk_table_name { get; set; }
        public string foreign_key_name { get; set; }
        public string pk_schema_name { get; set; }
        public string pk_table_name { get; set; }
    }
}
