//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CZBK.ItcastOA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public long ID { get; set; }
        public int UserID { get; set; }
        public System.DateTime ScheduleTime { get; set; }
        public System.DateTime ScheduleAddTime { get; set; }
        public Nullable<System.DateTime> ScheduleUpdateTime { get; set; }
        public string ScheduleText { get; set; }
        public Nullable<int> ScheduleTypeID { get; set; }
        public string TextReadBak { get; set; }
        public Nullable<int> TextReadUser { get; set; }
        public Nullable<System.DateTime> TextReadTime { get; set; }
        public Nullable<int> FileItemID { get; set; }
    
        public virtual FileItem FileItem { get; set; }
        public virtual ScheduleType ScheduleType { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
