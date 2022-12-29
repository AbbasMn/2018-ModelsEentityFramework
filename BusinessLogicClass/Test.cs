using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Dynamic;

namespace ModelsEentityFramework.BusinessLogicClasses
{

    [System.ComponentModel.DataAnnotations.Schema.Table("Tests")]
    public class Test
    {
        public Test()
        {
            TestID = System.Guid.NewGuid();
        }



        public string DisplayName
        {
            get
            { // read only without set !
                string strResult = String.Format("{0}", TestName);
                return strResult;
            }
        }



        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("TestID", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public System.Guid TestID { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "نام")]
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public string TestName { get; set; }




        [System.ComponentModel.DataAnnotations.Display(Name = "نام")]
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public string TestFamily { get; set; }


    }

}
