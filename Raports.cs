//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FridgeManagementApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raports
    {
        public int id { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_product { get; set; }
        public Nullable<int> raport_quantity { get; set; }
        public Nullable<System.TimeSpan> action_time { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual Users Users { get; set; }
    }
}
