using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.BusinessLogicClasses
{
    // برقراری رابطه یک به چند در پایگاه داده
    // هر کشور چند ایالت دارد و هر ایالت متعلق به یک کشور است

    [System.ComponentModel.DataAnnotations.Schema.Table("Countries")]
    public class Country : EntitiesSuperClasses.BaseEntityIsActive
    {

        public Country()
        {
            CountryID = System.Guid.NewGuid();
        }

        public string DisplayName
        {
            get
            { // read only without set !
                string strResult = String.Format("{0}", CountryName);
                return strResult;
            }
        }


        //////////////////////////////////////////////////////////


        #region Configuration
        /// <summary>
        /// کلاس اینترنال کانفیگوریشن
        /// Fluent Api
        /// خیلی از کارهایی که با فلوانت ای پی آی میشود انجام داد با اتربیوت هم میتوان انجام داد
        /// در ذیل مشخص شده چه فعالیتی رو بهتر است با فلوانت ای پی آی انجام داد و یا اتربیوت

        /// در دیتابیس تفاوتی بین فلو انت ای پی آی و اتربیوت نیست ولی در ام وی سی هنوز به خوبی فلوانت ای پی آی را
        /// سنس نمیکند ولی اتربیوت ها در ام وی سی در ویو تاثیر میگذارند
        /// اگر برای آیتمی هم اتربیوت هم فلو انت ای پی آی در نظر گرفته شود فلو انت ای پی آی عمل میکند
        /// 
        /// باید استفاده کرد MVC توجه مهم :  روش پیشنهاد شده را فقط در 
        /// فرقی نمیکند که از کدوم استفاده کنید ASP>NET در 
        /// </summary>

        internal class Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Country>
        {

            public Configuration()
            {
                // Note: Attribute is better!
                //نام جدول چه باشد
                //ToTable("Countries_API_Fluent");

                // Note: Attribute is better!
                //پرایمری نمودن آی دی
                //HasKey(x => x.CountryID);


                // Note: Attribute is better!
                //آی دی اتو اینکریمنت نباشد
                //Property(x => x.CountryID)
                //    .HasDatabaseGeneratedOption
                //    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);


                //پراپرتی آی دی
                //Property(x => x.CountryID)
                //    // Note: Attribute is better!
                //    //نام آی دی چه باشد
                //    .HasColumnName("CountryID_API_Fluent")

                //    // Note: Attribute is better!
                //    //اوردر آی دی چه باشد
                //    .HasColumnOrder(0)

                //    // Note: Attribute is better!
                //    //نیاز به مقدار دهی باشد
                //    .IsRequired()
                //    ;




                //پراپرتی نام
                //Property(x => x.CountryName)
                    // Note: Attribute is better!
                    //نام چه باشد
                    //.HasColumnName("CountryName_API_Fluent")

                    //// Note: Attribute is better!
                    ////اوردر نام چه باشد
                    //.HasColumnOrder(1)

                    //// Note: Attribute is better!
                    ////نیاز به مقدار دهی باشد
                    //.IsRequired()

                    // Note: Fluent Api is better!
                    //یونی کد باشد
                    ////.IsUnicode(true)

                    // Note: Fluent Api is better!
                    //حداکثر طول متن نام چه باشد
                    //.HasMaxLength(50)

                    // Note: Fluent Api is better!
                    //طول نام قابل تغییر باشد
                    //.IsVariableLength()
                    ;


                //پراپرتی نام  قاره
                //Property(x => x.CountryContinent)
                    // Note: Attribute is better!
                    //نام چه باشد
                    //.HasColumnName("CountryContinent_API_Fluent")

                    //// Note: Attribute is better!
                    ////اوردر نام چه باشد
                    //.HasColumnOrder(2)

                    //// Note: Attribute is better!
                    ////نیاز به مقدار دهی باشد
                    //.IsRequired()

                    // Note: Fluent Api is better!
                    //یونی کد باشد
                    //.IsUnicode(true)

                    //// Note: Fluent Api is better!
                    ////حداکثر طول متن نام چه باشد
                    //.HasMaxLength(50)

                    //// Note: Fluent Api is better!
                    ////طول نام قابل تغییر باشد
                    //.IsVariableLength()
                    //;              

            }

        }
        #endregion  Configuration








        /// <summary>
        /// id of Entity ==> first Primary key Field (Order =0)
        /// </summary>

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Schema.Column("CountryID", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        public System.Guid CountryID { get; set; }


        [System.ComponentModel.DataAnnotations.Display(Name = "نام کشور")]
        public string CountryName { get; set; }



        /// <summary>
        /// continent of City
        // </summary>
        
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.Schema.Column("CountryContinent", Order = 3, TypeName = "nVarChar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام قاره")]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public string CountryContinent { get; set; }

        /// <summary>
        /// Lazy Loading - Lazy Initialization (In Database and OOP)
        ///  ایجاد یک کالکشن از ایالت ها بمنظور اعمال ارتباط یک به چند با کشور
        /// کلمه ویرچوال باعث میشود که روش لیزی لودینگ بصورت خودکار اعمال گردد
        /// </summary>
        public virtual System.Collections.Generic.IList<ModelsEentityFramework.BusinessLogicClasses.State> States { get; set; }
    }
    // پایان راه حل چهارم


}
