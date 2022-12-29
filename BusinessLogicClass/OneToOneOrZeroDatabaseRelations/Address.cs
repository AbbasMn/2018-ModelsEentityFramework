using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.BusinessLogicClasses.OneToOneOrZeroDatabaseRelations
{
    [System.ComponentModel.DataAnnotations.Schema.Table("Addresses")]
    public class Address
    {
        internal class Configuration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Address>
        {
            public Configuration()
            {
                HasKey(current => current.PersonID)
               .HasRequired(current => current.Person)
               .WithOptional(Person => Person.PersonAddress)
               .WillCascadeOnDelete(true)
               ;

            }
        }



        /// <summary>
        /// override Tostring() for UserAddress Class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strFullAddress = String.Empty;

            if (Country != String.Empty)
            {
                strFullAddress = Country;
            }

            if (State != String.Empty)
            {
                if (strFullAddress == String.Empty)
                {
                    strFullAddress = State;
                }
                else
                    strFullAddress += " " + State;
            }

            if (City != String.Empty)
            {
                if (strFullAddress == String.Empty)
                {
                    strFullAddress = City;
                }
                else
                    strFullAddress += " " + City;
            }


            return (strFullAddress);
        }


        public Address()
        {

        }

        public Address(string country, string state, string city)
        {
            AddressID = System.Guid.NewGuid();
            City = city;
            Country = country;
            State = state;
        }

        /// <summary>
        /// ///////////////////
        /// </summary>

        [System.ComponentModel.DataAnnotations.Key]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Guid AddressID { get; set; }

        
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام کشور")]
        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public virtual string Country { get; set; }




        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام ایالت/استان")]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public virtual string State { get; set; }


        
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام شهر")]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public virtual string City { get; set; }

        /// <summary>
        /// پراپرتی شخص
        /// بمنظور اعمال رابطه یک به یک با کلاس شخص
        /// </summary>
        public virtual OneToOneOrZeroDatabaseRelations.Person Person { get; set; }

        public System.Guid PersonID { get; set; }
    }
}
