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
    
    public partial class Products
    {

        public Products()
        {
            this.Comments = new HashSet<Comments>();
            this.Orders = new HashSet<Orders>();
            this.Pic_Products = new HashSet<Pic_Products>();
            this.Product_Catgoris = new HashSet<Product_Catgoris>();
            this.ShopingCarts = new HashSet<ShopingCarts>();
        }

        /// <summary>
        /// 
        /// </summary>
             

    public int ID { get; set; }
        public string ProductName { get; set; }
        public string EnProductName { get; set; }
        public decimal Price { get; set; }
        public decimal P_Save { get; set; }
        public string Description { get; set; }
        public System.DateTime P_Date { get; set; }
        public int Guaranty { get; set; }
        public double Visit { get; set; }
        public double P_Like { get; set; }
        public double P_Dislike { get; set; }
        public int UserID { get; set; }
        public int Exist { get; set; }
        public long Sales { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual Guaranty GuarantyID { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Pic_Products> Pic_Products { get; set; }
        public virtual ICollection<Product_Catgoris> Product_Catgoris { get; set; }
        public virtual Users1 Users { get; set; }
        public virtual ICollection<ShopingCarts> ShopingCarts { get; set; }
    }
}
