//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StajApp.template (1).MaterialSkin-master.MaterialSkinExample.RDSPORTAL_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DCASCEPORT
    {
        public int COMPANYID { get; set; }
        public int DEVICEID { get; set; }
        public int KEYFIELD { get; set; }
        public int PORTNO { get; set; }
        public int PWORKSTATIONID { get; set; }
        public Nullable<int> OPCTAGDEFID { get; set; }
        public Nullable<int> PORTPROCTYPE { get; set; }
        public Nullable<int> PSTOPCAUSEID { get; set; }
        public Nullable<int> COUNTERQUANTITY { get; set; }
        public Nullable<int> UNITID { get; set; }
        public Nullable<int> ANALOGCLOSEVALUE { get; set; }
        public Nullable<int> ANALOGMAXVALUE { get; set; }
        public Nullable<int> ANALOGMAXCYCLE { get; set; }
        public Nullable<double> ANALOGCOE { get; set; }
        public Nullable<int> PERRORSID { get; set; }
        public string SPECCODEANALOG { get; set; }
        public string GROUPCODE { get; set; }
        public Nullable<int> PWORKSTATIONIDSTOPREL { get; set; }
        public Nullable<double> CYCLEOFCOE { get; set; }
        public Nullable<double> CYCLEOFPULSE { get; set; }
        public Nullable<int> PULSECOUNT { get; set; }
        public Nullable<int> STOPPRIORITY { get; set; }
        public string STOPSTARTDO { get; set; }
        public Nullable<bool> PRODSAVE { get; set; }
        public Nullable<bool> SECTIONSAVE { get; set; }
        public Nullable<bool> COUNTDEVICE { get; set; }
        public Nullable<bool> FLASOR { get; set; }
        public Nullable<int> TIMEOUTCYCLEMULT { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<byte> COFSOCKETNO { get; set; }
        public string RUNSQL { get; set; }
        public Nullable<byte> DCASENERGYTYPESID { get; set; }
        public Nullable<bool> BARCODEPRINT { get; set; }
        public Nullable<int> QTYSELECTFORPRINT { get; set; }
        public Nullable<int> SCALESSTART { get; set; }
        public Nullable<int> SCALESLENGTH { get; set; }
        public string SCALESSETTING { get; set; }
        public Nullable<double> SCALESDIVKG { get; set; }
        public string SCALESCHAR { get; set; }
        public Nullable<bool> SCALESPUBLIC { get; set; }
        public Nullable<bool> ENDSTOPCOUNTER { get; set; }
        public Nullable<bool> REPLACESC { get; set; }
        public Nullable<bool> STARTSTOPSC { get; set; }
        public Nullable<bool> NOTSTARTCYCLE { get; set; }
        public string DCBMACID { get; set; }
        public Nullable<bool> COUNTERADDLOSS { get; set; }
        public Nullable<bool> LOSSADDCOUNTER { get; set; }
        public Nullable<bool> PRODSAVEINLOSS { get; set; }
        public Nullable<bool> INSIGNALNOWORK { get; set; }
        public Nullable<int> STOCKCOUNTINDEX { get; set; }
        public Nullable<bool> QTYUNITCONVERTFROMPID { get; set; }
        public Nullable<bool> MULTCYCLE { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<bool> UNITCONVERT { get; set; }
        public Nullable<bool> SETPLCVALUE { get; set; }
        public Nullable<bool> SETPLCWORKSTART { get; set; }
        public Nullable<bool> SETPLCWORKEND { get; set; }
        public Nullable<double> QTY2MULT { get; set; }
        public Nullable<int> INSERTUSERID { get; set; }
        public Nullable<System.DateTime> INSERTDATE { get; set; }
        public Nullable<int> EDITUSERID { get; set; }
        public Nullable<System.DateTime> EDITDATE { get; set; }
        public Nullable<int> GLBALERTID { get; set; }
    }
}