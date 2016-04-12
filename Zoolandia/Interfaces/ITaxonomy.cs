using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Interfaces
{
    interface ITaxonomy
    {
        string Genus { get; set;  }
        string Species { get; set; }
        string CommonName { get; set; }
    }
}
