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
    
    public partial class T_BoolItem
    {
        public T_BoolItem()
        {
            this.T_BaoJiaToP = new HashSet<T_BaoJiaToP>();
        }
    
        public int ID { get; set; }
        public string str { get; set; }
        public Nullable<bool> BOLL_ { get; set; }
        public Nullable<int> @int { get; set; }
        public Nullable<System.DateTime> timener { get; set; }
        public Nullable<int> ItemsID { get; set; }
    
        public virtual ICollection<T_BaoJiaToP> T_BaoJiaToP { get; set; }
    }
}
