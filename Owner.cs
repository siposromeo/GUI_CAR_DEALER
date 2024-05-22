using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gyakorlas_Cars_Owners.Models
{
    public class Owner
    {
        public int id { get; private set; }
        public string name { get; private set; }
        public string address { get; private set; }
    }
}
