using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.FUNCTIONS.Models
{
    public class Prepare_Model
    {
        public string ConnectionString_SOURCE { get; set; }
        public string ConnectionString_HREF { get; set; }
        public int SOURCE_TYPE { get; set; } // MODEL=100 || CnnStrng=200
        public bool ESLESENSATIRLAR { get; set; } = false;
        public bool FAZLASATIRLAR { get; set; } = false;
        public string SOURCE_SERVER { get; set; }
        public string SOURCE_USER { get; set; }
        public string SOURCE_PASS { get; set; }
        public string SOURCE_DB { get; set; }
        public string HREF_SERVER { get; set; }
        public string HREF_USER { get; set; }
        public string HREF_PASS { get; set; }
        public string HREF_DB { get; set; }
    }
}