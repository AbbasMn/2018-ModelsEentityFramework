using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelsEentityFramework.BusinessLogicClasses.OneToOneOrZeroDatabaseRelations
{
    [System.ComponentModel.DataAnnotations.Schema.Table("People")]
    public class Person: EntitiesSuperClasses.BaseEntityIsActive
    {

        public Person(string firstName, string middleName, string lastName, string country, string state, string city)
        {
            PersonID = System.Guid.NewGuid();



            ComplexTypeClasses.FullName oFullName = new ComplexTypeClasses.FullName();
            oFullName.Firstname = firstName;
            oFullName.MiddleName = middleName;
            oFullName.LastName = lastName;

            PersonFullName = oFullName;

            if ((country == null) && (state == null) & (city == null))
            {

            }  
            else
            {
                
                OneToOneOrZeroDatabaseRelations.Address oAddress = new OneToOneOrZeroDatabaseRelations.Address();
                oAddress.Country = country;
                oAddress.State = state;
                oAddress.City = city;

                PersonAddress = oAddress;
            }        
        }

        public Person()
        {
            PersonID = System.Guid.NewGuid();
        }


        /// <summary>
        /// پراپرتی نمایش نام کامل
        /// </summary>
        public string DisplayFullName
        {
            get
            {
                // Override .ToString()  in UserFullName Class !
                string strFullName = PersonFullName.ToString();

                if (strFullName == string.Empty)
                {
                    return ("[Unknown]");
                }
                return (strFullName);
            }
        }


        /// <summary>
        /// پراپرتی نمایش آدرس کامل
        /// </summary>
        public string DisplayAddress
        {
            get
            {
                // Override .ToString()  in UserAddress Class !
                string strFullAddress = PersonAddress.ToString();

                if (strFullAddress == string.Empty)
                {
                    return ("[Unknown]");
                }
                return (strFullAddress);
            }
        }


        /// <summary>
        /// پراپرتی نمایش نام و آدرس کامل
        /// </summary>
        public string DisplayFullNameAndAddress
        {
            get
            {
                string strTempFullName = null;
                string strTempAddress = null;

                // Override .ToString()  in UserFullName Class !
                string strFullName = PersonFullName.ToString();

                if (strFullName == string.Empty)
                {
                    strTempFullName = "[Unknown Name]";
                }
                else
                    strTempFullName = strFullName;

                // Override .ToString()  in UserAddress Class !

                //string strFullAddress = PersonAddress.ToString();

                //if (strFullAddress == string.Empty)
                //{
                //    strTempAddress = "[Unknown Name]";
                //}
                //else
                //    strTempAddress = strFullAddress;

                return (strTempFullName + " " + strTempAddress);
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////


        #region  Configuration
        internal class Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ModelsEentityFramework.BusinessLogicClasses.OneToOneOrZeroDatabaseRelations.Person>
        {

            public Configuration()
            {
                // Note: Attribute is better!
                //نام جدول چه باشد
                //ToTable("Persons_API_Fluent");

                //// Note: Attribute is better!
                ////پرایمری نمودن آی دی
                //HasKey(x => x.PersonID);


                //// Note: Attribute is better!
                ////آی دی اتو اینکریمنت نباشد
                //Property(x => x.PersonID)
                //    .HasDatabaseGeneratedOption
                //    (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);


                ////پراپرتی آی دی
                //Property(x => x.PersonID)
                //    // Note: Attribute is better!
                //    //نام آی دی چه باشد
                //    .HasColumnName("PersonID_API_Fluent")

                //    // Note: Attribute is better!
                //    //اوردر آی دی چه باشد
                //    .HasColumnOrder(0)

                //    // Note: Attribute is better!
                //    //نیاز به مقدار دهی باشد
                //    .IsRequired()
                //    ;



                // Note: Fluent Api is better!
                //فلوانت ای پی آی برای ایجاد رابطه یک به چند
                //در این قسمت میتوان کسکید دلیت رو هم فالس گذاشتیم و لی در اتربیوت نمیتوان
                HasRequired(x => x.PersonCity)
                    .WithMany(city => city.Persons)
                    .HasForeignKey(x => x.PersonCityID)
                    .WillCascadeOnDelete(false)
                    ;
            }

        }


        #endregion  Configuration


        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.Schema.Column("PersonID", Order = 0)]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated
            (System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]
        public System.Guid PersonID { get; set; }

        /// <summary>
        /// id1  ==> second Primary key Field (Order =1)
        /// </summary>


        [System.ComponentModel.DataAnnotations.DataType("nText")]
        [System.ComponentModel.DataAnnotations.Display(Name ="توضیحات")]
        public string PersonDescription { get; set; }

        public ComplexTypeClasses.FullName PersonFullName { get; set; }


        /// <summary>
        /// پراپرتی آی دی شهر
        /// بمنظور اعمال رابطه یک به چند با کلاس شخص
        /// </summary>
        /// 
        
        public virtual System.Guid PersonCityID { get; set; }

        /// <summary>
        /// پراپرتی شهر که از جنس کلاس شهر است
        /// </summary>
		public virtual BusinessLogicClasses.City PersonCity { get; set; }



        /// <summary>
        /// پراپرتی آدرس
        /// بمنظور اعمال رابطه یک به یک با کلاس آدرس
        /// </summary>
        public virtual OneToOneOrZeroDatabaseRelations.Address PersonAddress { get; set; }

    }
}
