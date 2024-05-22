using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gyakorlas_Cars_Owners.Models
{
    public class Car
    {
        public int id { get; private set; }
        public string brand { get; private set; }
        public string model { get; private set; }
        public DateTime registration_date { get; private set; }
        public int ownerid { get; private set; }
        public Owner owner { get; set; }
    }
}
