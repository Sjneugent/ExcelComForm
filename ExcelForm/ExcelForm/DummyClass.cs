using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLibrary;
namespace ExcelForm
{
    class DummyClass
    {
        public ValueLocation vl { get; set; }
        public String data { get; set; }
        public DummyClass(ValueLocation vl, String data)
        {
            this.vl = vl;
            this.data = data;
        }
    }
}
