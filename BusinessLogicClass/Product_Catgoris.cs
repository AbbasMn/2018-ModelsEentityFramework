//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelsEentityFramework.BusinessLogicClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Catgoris
    {
        public long ID { get; set; }
        public int CatID { get; set; }
        public int ProductID { get; set; }
    
        public virtual Category Catgoris { get; set; }
        public virtual Products Products { get; set; }
    }
}