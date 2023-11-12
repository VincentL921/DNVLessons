using Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class HomeOffice : Room
    {
        public bool HasDesk { get; set; }
        public int WindowCount { get; set; }
    }
}
