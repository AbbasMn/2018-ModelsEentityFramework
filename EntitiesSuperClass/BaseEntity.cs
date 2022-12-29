using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.EntitiesSuperClasses
{
    public class BaseEntity: InfrastructureClasses.Utility
    {

        [System.ComponentModel.DataAnnotations.Schema.Column("EntityInsertTime")]
        [System.ComponentModel.DataAnnotations.Display(Name = "تاریخ ایجاد")]
        public System.DateTime InsertTime { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("EntityUpdateTime")]
        [System.ComponentModel.DataAnnotations.Display(Name = "تاریخ بروزرسانی")]
        public System.DateTime UpdateTime { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.Column("EntityIsDeleted")]
        [System.ComponentModel.DataAnnotations.Display(Name = "حذف شده/نشده")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// System.DateTime?  ==> for allow null field
        /// </summary>

        [System.ComponentModel.DataAnnotations.Schema.Column("EntityDeletedTime")]
        [System.ComponentModel.DataAnnotations.Display(Name = "تاریخ حذف")]

        public System.DateTime? deletedTime { get; set; }


        public BaseEntity()
        {
            //PeopleID = System.Guid.NewGuid();
            //ID1 = System.Guid.NewGuid();
            DateTime dtNow = InfrastructureClasses.Utility.Now;
            InsertTime = dtNow;
            UpdateTime = dtNow;
            deletedTime = dtNow;            
        }
    }
}
