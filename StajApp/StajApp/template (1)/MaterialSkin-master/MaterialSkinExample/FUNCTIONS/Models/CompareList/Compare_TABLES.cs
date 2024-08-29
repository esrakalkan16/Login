using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.FUNCTIONS.Models.CompareList
{
    public class Compare_TABLES
    {
        [System.ComponentModel.DisplayName("Kaynak Tablo Adı")]
        public string SOURCE_TABLE_NAME { get; set; }
        public string SOURCE_DATABASE_NAME { get; set; }
        [System.ComponentModel.DisplayName("Hedef Tablo Adı")]
        public string HREF_TABLE_NAME { get; set; }
        public string HREF_DATABASE_NAME { get; set; }
        [System.ComponentModel.DisplayName("Tablo Karşılaştırması")]
        public bool TABLE_CHECK { get; set; } = false;
        [System.ComponentModel.DisplayName("Kolon Karşılaştırması")]
        public bool COLOUMN_CHECK { get; set; } = false;
        [System.ComponentModel.DisplayName("Eşlemeye Dahil Et")]
        public bool COMPARE_STATUS { get; set; } = false;
        public List<Compare_COLOUMN> Compare_COLOUMNs { get; set; } = new List<Compare_COLOUMN>();
    }
}
