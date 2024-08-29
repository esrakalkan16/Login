using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkinExample.FUNCTIONS.Models.CompareList
{
    public class Compare_COLOUMN
    {
        [System.ComponentModel.DisplayName("Kaynak Alan Adı")]
        public string SOURCE_COLUMNNAME { get; set; }
        [System.ComponentModel.DisplayName("Kaynak NULL izni")]
        public string SOURCE_IS_NULLABLE { get; set; }
        [System.ComponentModel.DisplayName("Kaynak Data Tipi")]
        public string SOURCE_DATA_TYPE { get; set; }
        [System.ComponentModel.DisplayName("Kaynak Karakter Sayısı")]
        public int? SOURCE_CHARACTER_MAXIMUM_LENGTH { get; set; }
        [System.ComponentModel.DisplayName("Hedef Kolon Adı")]
        public string HREF_COLUMNNAME { get; set; }
        [System.ComponentModel.DisplayName("Hedef NULL izni")]
        public string HREF_IS_NULLABLE { get; set; }
        [System.ComponentModel.DisplayName("Hedef Data Tipi")]
        public string HREF_DATA_TYPE { get; set; }
        [System.ComponentModel.DisplayName("Hedef Karakter Sayısı")]
        public int? HREF_CHARACTER_MAXIMUM_LENGTH { get; set; }
        [System.ComponentModel.DisplayName("Kolon Eşleşme Durumu")]
        public bool COLOUMN_STATUS { get; set; } = false;
    }
}
