using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTableEditor.Models
{
    public class TasbleModel
    {
        public string Name {  get; set; }
        public string PrimaryKey { get; set; }
        public List<ColumnDefinition> Columns = new List<ColumnDefinition>();
    }
}
