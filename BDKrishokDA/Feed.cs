//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDKrishokDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feed
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FeedTypeId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public Nullable<int> ShopId { get; set; }
        public Nullable<int> ImageId { get; set; }
        public Nullable<int> VideoId { get; set; }
        public string Description { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual FeedType FeedType { get; set; }
        public virtual Image Image { get; set; }
        public virtual Shop Shop { get; set; }
        public virtual Video Video { get; set; }
    }
}
