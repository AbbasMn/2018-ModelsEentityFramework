using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEentityFramework.InfrastructureClasses
{
    public class DatabaseContextInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    //System.Data.Entity.DropCreateDatabaseAlways<DatabaseContext>
    //System.Data.Entity.CreateDatabaseIfNotExists<DatabaseContext>
    {

        public DatabaseContextInitializer()
        {
        }



        /// <summary>
        /// اين تابع فقط زمانی اجرا می شود که بانک اطلاعاتی می خواهد ايجاد شود
        /// در صورتی که بانک اطلاعاتی قبلا ايجاد شده باشد، اين تابع اجرا نخواهد شد
        /// </summary>
        protected override void Seed(DatabaseContext databaseContext)
        {
            base.Seed(databaseContext);

            try
            {
                databaseContext = new InfrastructureClasses.DatabaseContext();

                //databaseContext.Persons.Add(new Person("Emad", "", "Mosavi","Iran","Fars","Estahban"));
                //databaseContext.Persons.Add(new Person("Ali", "Naz", "Mohammadi", "Iran", "Fars", "Estahban"));
                //databaseContext.Persons.Add(new Person() { PersonFullName = new ComplexType.UserFullName { Firstname = "Seyed", MiddleName = "Abbas", LastName = "Montaseri" }
                //                                           ,PersonAddress=new ComplexType.UserAddress { Country="Iran",  State="Fars", City="Estahban"}
                //});
                //databaseContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }

        }


    }
}
