using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBCFD16
{
    class DiseaseDetails
    {
        public string name { get; set; }
        public string description { get; set; }
        public List<Symptom> Symptoms { get; set; }
    }
}
