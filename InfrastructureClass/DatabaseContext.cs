using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace ModelsEentityFramework.InfrastructureClasses
{
    public class DatabaseContext  : System.Data.Entity.DbContext
    {

        // This class and it's collections will convert to Database !

    /// <summary>
    /// سازنده استاتیک کلاس دیتا بیس کانتکست
    /// این سازنده حداکثر یک بار اتفاق میفتد
    /// یا اولین بار که با یک ممبر استاتیک از این کلاس کار کار میکنیم
    /// یا اولین بار که یک شی از این کلاس میسازیم 
    /// این سازنده اور لود ندارد و اکسز مادی فایر نیز ندارد و خروجی هم ندارد
    /// استراتژی های دیتا بیس را در این سازنده مینویسم
    /// </summary>
    /// 
    static DatabaseContext()
        {
            //////////////////////  Migration  //////////////////////////////
            System.Data.Entity.Database.SetInitializer
                (new System.Data.Entity.MigrateDatabaseToLatestVersion<DatabaseContext, ModelsEentityFramework.Migrations.Configuration>());

            //////////////////////  Migration  //////////////////////////////


            //از کلاس دیتا بیس کانتکست اینیشیالایزر یک شی میسازیم که از سناریو مورد نظر استفاده میکند
            //و همچنین کلاس دیتا بیس کانتکست اینیشیالایزر حاوی اطلاعات پایه ای است که در متد سید موجود است
            //System.Data.Entity.Database.SetInitializer(new InfrastructureClasses.DatabaseContextInitializer());


            // ******************************************************************************************************* //

            // اين گزينه به درد قشر خاصی از برنامه نويسان می خورد که با اطلاعات رندوم کار میکنند
            //این استراتژی یعنی هر وقت که برنامه اجرا میشود اگر دیتا بیس وجود ندارد میسازد و 
            //اگر هم وجود داشت هر بار دیتابیس پاک میشود و دوباره ساخته میشود
            //System.Data.Entity.Database.SetInitializer
            //   (new System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>());

            // اين گزينه به درد برنامه نويسان می خورد
            //این استراتژی یعنی هر وقت که برنامه اجرا میشود اگر دیتا بیس وجود ندارد میسازد و 
            //اگر در مدل تغییری حاصل شده بود دیتا بیس را پاک میکند و مجددا میسازد
            //افزودن و پاک کردن فیلد  و پراپرتی در مدل نیز جز تغییرات حساب میشود
            //System.Data.Entity.Database.SetInitializer
            //(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());

            // اين گزينه به درد مشتری می خورد
            //اگر دیتا بیس وجود نداشت میسازد
            //System.Data.Entity.Database.SetInitializer
            //    (new System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>());

            //Migration
            //اگر دیتا بیس وجود نداشته باشد میسازد
            //اگر وجود داشته باشد و مدل تغییری نکرده باشد کاری ندارد
            //اگر وجود داشته باشد و مدل تغییری کرده باشددیتا ببس به آخرین نسخه قبلی مایگریت میشود و سپس تغییرات در آن لحاظ میشود
        }



        /// <summary>
        /// set Database CountryName in SqlServer  public DatabaseContext() : base("myDatabaseName")
        /// سازنده پیش فرض
        /// </summary>
        public DatabaseContext()
        {
            Configuration.LazyLoadingEnabled = true;
        }

        /// <summary>
        /// declare collection of infinit Cities and Personss
        /// </summary>
        public System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.City> Cities { get; set; }

        public System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.OneToOneOrZeroDatabaseRelations.Person> Persons { get; set; }

        public System.Data.Entity.DbSet<BusinessLogicClasses.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.State> States { get; set; }

        public System.Data.Entity.DbSet<BusinessLogicClasses.ManyToManyDatabaseRelations.Group> Groups { get; set; }

        public System.Data.Entity.DbSet<BusinessLogicClasses.ManyToManyDatabaseRelations.User> Users { get; set; }




        public System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Slide> Slides{ get; set; }

        public System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Category> Categories { get; set; }
        
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Comments>Comments { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Guaranty>Guaranty { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Menu>Menu { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Orders>Orders { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Pic_Products> Pic_Products { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Pics> Pics { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Post> Post { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Product_Catgoris> Product_Catgoris { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Products> Products { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Settings> Settings { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.ShopingCarts> ShopingCarts { get; set; }
        public  System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.Users1> Users1 { get; set; }
        public System.Data.Entity.DbSet<ModelsEentityFramework.BusinessLogicClasses.ContactUS> ContactUS { get; set; }
        //  use collection generic : 



        /// <summary>
        /// متد اورراید آن مدل کریتینگ 
        /// در این متد کانفیگور های موجود در کلاس های مدل را به برنامه اد میکنیم
        /// </summary>
        ///

        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BusinessLogicClasses.State.Configuration());
            
            modelBuilder.Configurations.Add(new BusinessLogicClasses.City.Configuration());

            modelBuilder.Configurations.Add(new BusinessLogicClasses.OneToOneOrZeroDatabaseRelations.Person.Configuration());

            modelBuilder.Configurations.Add(new BusinessLogicClasses.ManyToManyDatabaseRelations.Group.Configuration());

            modelBuilder.Configurations.Add(new BusinessLogicClasses.OneToOneOrZeroDatabaseRelations.Address.Configuration());          
        }
    }
}
