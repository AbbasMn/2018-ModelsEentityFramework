using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.BusinessLogicClasses
{
    /// <summary>
    /// کلاس استان
    /// </summary>
    /// 
    [System.ComponentModel.DataAnnotations.Schema.Table("States")]
    public class State : EntitiesSuperClasses.BaseEntityIsActive
    {



        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
		public State()
        {
            StateID = System.Guid.NewGuid();
        }



        public State(string stateName)
        {
            StateID = System.Guid.NewGuid();
            StateName = stateName;
        }

        public State(string stateName, System.Collections.Generic.List<BusinessLogicClasses.City> cities)
        {
            StateID = System.Guid.NewGuid();
            StateName = stateName;

            Cities = cities;
        }



        public string DisplayName
        {
            get
            { // read only without set !
                string strResult = String.Format("{0}", StateName);
                return strResult;
            }
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        #region Configuration
        /// <summary>
        /// Fluent Api
        /// </summary>
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<State>
        {
            public Configuration()
            {
                //// Note: Attribute is better!
                //ToTable("States_API_Fluent");

                //// Note: Attribute is better!
                //HasKey(current => current.StateID);

                //// Note: Attribute is better!
                //Property(current => current.StateID)
                //    .HasDatabaseGeneratedOption
                //    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

                //Property(current => current.StateID)
                //    // Note: Attribute is better!
                //    .HasColumnName("StateID_API_Fluent")
                //    // Note: Attribute is better!
                //    .HasColumnOrder(0)
                //    // Note: Attribute is better!
                //    .IsRequired()
                //    ;

                //Property(current => current.StateName)
                    //// Note: Attribute is better!
                    //.HasColumnName("StateName_API_Fluent")
                    //// Note: Attribute is better!
                    //.HasColumnOrder(1)
                    //// Note: Attribute is better!
                    //.IsRequired()
                    // Note: Fluent Api is better!
                    //.IsUnicode(true)
                    // Note: Fluent Api is better!
                    //.HasMaxLength(50)
                    // Note: Fluent Api is better!
                    //.IsVariableLength()
                    //;

                // Note: Fluent Api is better!
                //فلوانت ای پی آی برای ایجاد رابطه یک به چند
                //در این قسمت میتوان کسکید دلیت رو هم فالس گذاشتیم و لی در اتربیوت نمیتوان
                HasRequired(x => x.Country)
                    .WithMany(country=> country.States)
                    .HasForeignKey(x => x.CountryID)
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
        #endregion /Configuration

        /// <summary>
        /// id of Entity ==> first Primary key Field (Order =0)
        /// </summary>

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("StateID", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public System.Guid StateID { get; set; }


        /// <summary>
        /// پراپرتی نام ایالت
        /// </summary>
        /// 
        [System.ComponentModel.DataAnnotations.Display(Name = "نام ایالت")]
        public string StateName { get; set; }


        /// <summary>
        /// پراپرتی آی دی کشور
        /// بمنظور اعمال رابطه یک به چند با کلاس استان
        /// </summary>
        public System.Guid CountryID { get; set; }

        /// <summary>
        /// پراپرتی کشور که از جنس کلاس کشور است
        /// </summary>
		public virtual Country Country { get; set; }


        public virtual System.Collections.Generic.IList<City> Cities { get; set; }
    }

}
