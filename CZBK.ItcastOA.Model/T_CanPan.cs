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
    
    public partial class T_CanPan
    {
        public long ID { get; set; }
        public Nullable<long> SczzDanjuID { get; set; }
        public string Cpname { get; set; }
        public Nullable<decimal> CpShuliang { get; set; }
        public Nullable<long> SczzItemID { get; set; }
        public short DEL { get; set; }
        public Nullable<System.DateTime> OverTime { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public Nullable<int> AddUserID { get; set; }
        public string ImageInt { get; set; }
        public Nullable<int> OverUserID { get; set; }
        public string Bak { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
        public virtual UserInfo UserInfo1 { get; set; }
        public virtual T_SczzItem T_SczzItem { get; set; }
        public virtual T_SczzDanju T_SczzDanju { get; set; }
    }
}
