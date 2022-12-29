using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.BusinessLogicClasses
{

    [System.ComponentModel.DataAnnotations.Schema.Table("Temp")]
    public class Temp 
    {


		public Temp()
        {
            
        }


        public Temp(string tempName)
        {
            TempTitle = tempName;
        }

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryID", Order = 0)]
        [System.ComponentModel.DataAnnotations.DataType("int")]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        
        public int ID { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("CategoryTitle", Order = 0)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        //[System.ComponentModel.DataAnnotations.Display(Name = "نام کشور")]
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public string TempTitle { get; set; }


    

        ////////////////////  temp////////////
        //[System.ComponentModel.DataAnnotations.Key]
        //[System.ComponentModel.DataAnnotations.Required]
        //[System.ComponentModel.DataAnnotations.Schema.Column("CategoryID", Order = 0)]
        //[System.ComponentModel.DataAnnotations.DataType("int")]
        //[System.ComponentModel.DataAnnotations.MaxLength(50)]
        //[System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
        //    System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        //[System.ComponentModel.DataAnnotations.Display(Name = "نام کشور")]
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]

    }

}
