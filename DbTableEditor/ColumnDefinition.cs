using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTableEditor
{
    public class ColumnDefinition
    {
        public string Name { get; set; } //Имя столбца
        public string DataType { get; set; }//Тип данных столбца
        public bool IsNotNull { get; set; } = false; //NOT NUL
    }
}
