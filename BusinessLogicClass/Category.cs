using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.BusinessLogicClasses
{

    [System.ComponentModel.DataAnnotations.Schema.Table("Categories")]
    public class Category
    {


		public Category()
        {
            
        }


        public Category(string CategoryTitle)
        {
            CategoryTitle = CategoryTitle;
        }

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryID", Order = 0)]
        [System.ComponentModel.DataAnnotations.DataType("int")]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        
        public int ID { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryTitle", Order = 1)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        //[System.ComponentModel.DataAnnotations.Display(Name = "نام کشور")]
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public string CategoryTitle { get; set; }


        
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryParentID", Order = 2)]
        [System.ComponentModel.DataAnnotations.DataType("int")]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
       
        public int CategoryParentID { get; set; }



        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryPic", Order = 3)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]

        public string CategoryPic { get; set; }


        //public string CategoryTestMigration { get; set; }
    }

}
