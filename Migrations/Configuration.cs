using System;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Data.Entity;

namespace ModelsEentityFramework.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<ModelsEentityFramework.InfrastructureClasses.DatabaseContext>
    {

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true; // Manage Class (table) Rename 
            ContextKey = "ModelsEentityFramework.InfrastructureClasses.DatabaseContext";

        }

    }
}