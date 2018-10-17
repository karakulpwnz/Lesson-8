using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairy
{
    /// <summary>
    /// Класс записи в дневнике
    /// </summary>
    public class Note
    {
        public string date { get; set; }
        public string place { get; set; }
        public string title { get; set; }
        public string note { get; set; }
    }
}
