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
    
    public partial class MAINTENANCEPLAN
    {
        public int COMPANYID { get; set; }
        public int MAINTENANCEPLANID { get; set; }
        public Nullable<int> MMAINTYPE { get; set; }
        public Nullable<int> MUNITID { get; set; }
        public Nullable<int> MAINTENANCETYPEID { get; set; }
        public Nullable<int> MPERIOD { get; set; }
        public Nullable<int> INTERVAL { get; set; }
        public Nullable<System.DateTime> LASTDATEPERFORM { get; set; }
        public Nullable<System.DateTime> LASTDATESCHULE { get; set; }
        public Nullable<System.DateTime> SCHULEDDATE { get; set; }
        public Nullable<int> LASTPERFORMEDCOUNT { get; set; }
        public Nullable<int> MWORKGROUPID { get; set; }
        public Nullable<int> MDIRECTIONSID { get; set; }
        public Nullable<bool> COUNTERAVAIL { get; set; }
        public string MAINTENANCEPLANNAME { get; set; }
        public Nullable<double> LABORCOST { get; set; }
        public Nullable<double> PARTCOST { get; set; }
        public Nullable<double> PLANQTY { get; set; }
        public Nullable<double> LASTMAINTENANCEQTY { get; set; }
        public Nullable<bool> PERIODPLAN { get; set; }
        public Nullable<short> STATUS { get; set; }
        public Nullable<int> PWORKCENTERID { get; set; }
        public Nullable<int> INSERTUSERID { get; set; }
        public Nullable<System.DateTime> INSERTDATE { get; set; }
        public Nullable<int> EDITUSERID { get; set; }
        public Nullable<System.DateTime> EDITDATE { get; set; }
        public Nullable<int> GLBALERTID { get; set; }
    }
}
