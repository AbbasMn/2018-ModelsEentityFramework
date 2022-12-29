using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ModelsEentityFramework.BusinessLogicClasses.ManyToManyDatabaseRelations
{

    [System.ComponentModel.DataAnnotations.Schema.Table("Groups")]
    public class Group: EntitiesSuperClasses.BaseEntityIsActive
    {

        #region Configuration

        internal class Configuration: System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Group>
        {
            public Configuration()
            {
                HasMany(current => current.Users)
                .WithMany(User => User.Groups)
                .Map(current =>
                {
                    current.ToTable("UsersInGroups");
                    // MapRightKey را می نويسيم و بعد MapLeftKey اول
                    // و سپس قانون دور در دور و نزديک در نزديک را رعايت می کنيم
                    current.MapLeftKey("GroupID");
                    current.MapRightKey("UserID");
                });
            }

        }

        #endregion #region


        public Group()
        {
            GroupID = System.Guid.NewGuid();
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////
        /// </summary>
        public Guid GroupID { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "نام کاربری")]
        public string GroupUserNameLogin { get; set; }


        [System.ComponentModel.DataAnnotations.Display(Name = "کلمه عبور")]
        public string GroupPasswordLogin { get; set; }

        public virtual ComplexTypeClasses.FullName GroupFullName { get; set; }

        public virtual ComplexTypeClasses.ComplexAddress GroupAddress { get; set; }

        /// <summary>
        /// برای لیزی لودینگ virtual
        /// </summary>
        public virtual System.Collections.Generic.IList<User> Users { get; set; }
    }
}
