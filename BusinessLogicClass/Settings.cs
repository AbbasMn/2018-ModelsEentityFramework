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
    
    public partial class Settings
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string SiteDescreption { get; set; }
        public string MetaTags { get; set; }
        public bool ShowConfirmComm { get; set; }
        public bool DisableComment { get; set; }
        public int MaxUploadSize { get; set; }
        public string ValidFormat { get; set; }
        public int CountForPaging { get; set; }
        public decimal Tax { get; set; }
        public decimal VAT { get; set; }
    }
}
