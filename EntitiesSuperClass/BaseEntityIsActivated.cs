using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.EntitiesSuperClasses
{
    public class BaseEntityIsActive: EntitiesSuperClasses.BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "فعال/غیرفعال")]
        public bool EntityIsActive { get; set; }

        /// <summary>
        /// Defualt Constructor
        /// </summary>
        public BaseEntityIsActive()
        {
            this.EntityIsActive = true;

        }
    }
}
