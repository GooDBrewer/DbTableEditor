using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTableEditor
{ 
    public class DatabaseConfig
    {
        public string ConnectionString { get; set; }
        public static readonly string[] ColumnTypes =
        {
            "INTEGER",
            "REAL",
            "TEXT",
            "VARCHAR(255)",
            "BOOLEAN",
            "DATE",
            "TIMESTAMP"
        };
    }
}
