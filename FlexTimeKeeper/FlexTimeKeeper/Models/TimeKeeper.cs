//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlexTimeKeeper.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeKeeper
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public Nullable<double> flexTime { get; set; }
        public Nullable<int> vacationDays { get; set; }
        public Nullable<int> floatingHolidays { get; set; }
        public Nullable<int> sickDays { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}