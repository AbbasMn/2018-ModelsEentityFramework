using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.ComplexTypeClasses
{
    [System.ComponentModel.DataAnnotations.Schema.ComplexType]
    public class ComplexAddress
    {
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


        public ComplexAddress()
        {

        }

        public ComplexAddress(string country, string state, string city)
        {
            City = city;
            Country = country;
            State = state;
        }

        
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
    }
}
