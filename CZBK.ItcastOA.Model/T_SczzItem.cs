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
    
    public partial class T_SczzItem
    {
        public T_SczzItem()
        {
            this.T_CanPan = new HashSet<T_CanPan>();
        }
    
        public long ID { get; set; }
        public string Text { get; set; }
        public short Del { get; set; }
        public Nullable<int> AddUser { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
    
        public virtual ICollection<T_CanPan> T_CanPan { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
