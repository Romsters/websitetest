﻿using System.Data.Entity.Migrations;

namespace mySite.DataAccess.Migrations
{
    public class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            CommandTimeout = 600;
        }

        protected override void Seed(DatabaseContext context)
        {
        }
    }
}
