using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.ComplexTypeClasses
{
    [System.ComponentModel.DataAnnotations.Schema.ComplexType]
    public class FullName
    {
        public FullName()
        {

        }

        public FullName(string firstName, string middleName, string lastName)
        {
            Firstname = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        /// <summary>
        /// override Tostring() for UserFullName Class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strFullName = String.Empty;

            if (Firstname != String.Empty)
            {
                strFullName = Firstname;
            }

            if (MiddleName != String.Empty)
            {
                if (strFullName == String.Empty)
                {
                    strFullName = MiddleName;
                }
                else
                    strFullName += " " + MiddleName;
            }

            if (LastName != String.Empty)
            {
                if (strFullName == String.Empty)
                {
                    strFullName = LastName;
                }
                else
                    strFullName += " " + LastName;
            }


            return (strFullName);
        }


        
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام")]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public virtual string Firstname { get; set; }



        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام وسط")]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام وسط را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public virtual string MiddleName { get; set; }



        
        [System.ComponentModel.DataAnnotations.MaxLength(50)]
        [System.ComponentModel.DataAnnotations.DataType("nVarChar")]
        [System.ComponentModel.DataAnnotations.Display(Name = "نام خانوادگی")]

        //[System.ComponentModel.DataAnnotations.Required(ErrorMessage = "نام خانوادگی را وارد کنید")]
        //[System.ComponentModel.DataAnnotations.StringLength(5, ErrorMessage = "بین 3 و 5 کاراکتر وارد کنید", MinimumLength = 3)]
        public virtual string LastName { get; set; }

    }
}
