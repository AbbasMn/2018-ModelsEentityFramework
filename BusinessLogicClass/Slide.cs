using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Install-Package EntityFrameWork -ProjectName Models

namespace ModelsEentityFramework.BusinessLogicClasses
{
     //prop + tab + tab ===> 

    [System.ComponentModel.DataAnnotations.Schema.Table("Slides")]
    public class Slide
    {


        /// <summary>
        /// calcutional property ===> will not chane to field in database
        /// </summary>
        public string DisplayName {
            get { // read only without set !
                string strResult = String.Format("{0}", PicName);
                return strResult;
            }
        }


        /// <summary>
        ///   برقراری رابطه چند به یک در پایگاه داده
        /// هر شهر فقط متعلق به یک ایالت است
        /// کلمه ویرچوال باعث میشود که روش لیزی لودینگ بصورت خودکار اعمال گردد
        /// </summary>
        //public virtual State State {get; set;}

        /// <summary>
        /// Constructor without patameters
        /// </summary>
        public Slide()
        {
            
        }


        public Slide(string name)
        {
            PicName = name;
        }


        /// <summary>
        /// id of Entity ==> first Primary key Field (Order =0)
        /// </summary>

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("SlideID", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int SlideID { get; set; }

        /// <summary>
        /// name of Slide
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        [System.ComponentModel.DataAnnotations.Schema.Column("PicName", Order = 1, TypeName = "nVarchar")]
        //[System.ComponentModel.DataAnnotations.Display(Name = "نام شهر")]

        ////[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        ////[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public string PicName { get; set; }



        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        [System.ComponentModel.DataAnnotations.Schema.Column("Link", Order = 2, TypeName = "nVarchar")]
        public string Link { get; set; }


        [System.ComponentModel.DataAnnotations.Schema.Column("Sort", Order = 3, TypeName = "int")]
        public int Sort { get; set; }


    }
}
