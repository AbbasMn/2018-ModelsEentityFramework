using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Install-Package EntityFrameWork -ProjectName Models

namespace ModelsEentityFramework.BusinessLogicClasses
{
     //prop + tab + tab ===> 

    [System.ComponentModel.DataAnnotations.Schema.Table("Cities")]
    public class City: EntitiesSuperClasses.BaseEntityIsActive
    {

        /// <summary>
        /// this property will not be field in table
        /// </summary>

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string Harchi { get; set; }


        /// <summary>
        /// calcutional property ===> will not chane to field in database
        /// </summary>
        public string DisplayName {
            get { // read only without set !
                string strResult = String.Format("{0}", CityName);
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
        public City()
        {
            CityID = System.Guid.NewGuid();
        }


        /// <summary>
        /// Constructor with patameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>

        public City(string name)
        {
            CityID = System.Guid.NewGuid();
            CityName = name;
        }




        public City(string cityName, System.Collections.Generic.List<BusinessLogicClasses.OneToOneOrZeroDatabaseRelations.Person> persons)
        {
            CityID = System.Guid.NewGuid();
            CityName = cityName;

            Persons = persons;
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>



        #region  Configuration
        internal class Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<City>
        {

            public Configuration()
            {
                // Note: Fluent Api is better!
                //فلوانت ای پی آی برای ایجاد رابطه یک به چند
                //در این قسمت میتوان کسکید دلیت رو هم فالس گذاشتیم و لی در اتربیوت نمیتوان
                HasRequired(x => x.State)
                    .WithMany(country => country.Cities)
                    .HasForeignKey(x => x.StateID)
                    .WillCascadeOnDelete(false)
                    ;

                //خودش
                //HasRequired(current => current.Country)
                //طرف مقابل
                //.WithMany(country => country.States)
                //خودش
                //.HasForeignKey(current => current.CountryID)
                //.WillCascadeOnDelete(false)
                //;

                //HasOptional(current => current.Country)
                //	.WithMany(country => country.States)
                //	.HasForeignKey(current => current.CountryID)
                //	.WillCascadeOnDelete(false)
                //	;
            }

        }


        #endregion  Configuration


        /// <summary>
        /// id of Entity ==> first Primary key Field (Order =0)
        /// </summary>

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("PeopleID", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public System.Guid CityID { get; set; }

        /// <summary>
        /// name of City
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLength(100)]
        [System.ComponentModel.DataAnnotations.Schema.Column("CityName", Order = 2, TypeName = "nVarchar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام شهر")]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public string CityName { get; set; }



        /// <summary>
        /// پراپرتی آی دی ایالت
        /// بمنظور اعمال رابطه یک به چند با کلاس شهر
        /// </summary>
        public System.Guid StateID { get; set; }

        /// <summary>
        /// پراپرتی ایالت که از جنس کلاس ایالت است
        /// </summary>
		public virtual ModelsEentityFramework.BusinessLogicClasses.State State { get; set; }


        public virtual System.Collections.Generic.IList<BusinessLogicClasses.OneToOneOrZeroDatabaseRelations.Person> Persons { get; set; }
    }
}
