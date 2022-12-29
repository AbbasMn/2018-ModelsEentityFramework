using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.BusinessLogicClasses.ManyToManyDatabaseRelations
{


    [System.ComponentModel.DataAnnotations.Schema.Table("Users")]
    public class User: EntitiesSuperClasses.BaseEntityIsActive
    {


        public User()
        {
            UserID = System.Guid.NewGuid();
        }

        public string DisplayName
        {
            get
            { // read only without set !
                string strResult = String.Format("{0}", UserFullName.Firstname+" "+UserFullName.LastName);
                return strResult;
            }
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        public Guid UserID { get; set; }


        [System.ComponentModel.DataAnnotations.Display(Name = "نام کاربری")]
        public string UserNameLogin { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "کلمه عبور")]
        public string  UserPasswordLogin { get; set; }

        public ComplexTypeClasses.ComplexAddress UserAddress { get; set; }

        public ComplexTypeClasses.FullName UserFullName { get; set; }

        /// <summary>
        /// برای لیزی لودینگ virtual
        /// </summary>
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; }

    }
}
