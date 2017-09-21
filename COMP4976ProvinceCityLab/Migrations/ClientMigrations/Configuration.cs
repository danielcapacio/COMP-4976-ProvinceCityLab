namespace COMP4976ProvinceCityLab.Migrations.ClientMigrations
{
    using COMP4976ProvinceCityLab.Data;
    using COMP4976ProvinceCityLab.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<COMP4976ProvinceCityLab.Data.ClientContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ClientMigrations";
        }

        protected override void Seed(COMP4976ProvinceCityLab.Data.ClientContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Provinces.AddOrUpdate(p => p.ProvinceCode,
                getProvinces().ToArray()
            );
            context.SaveChanges();

            context.Cities.AddOrUpdate(c => new { c.CityName, c.Population },
                getCities(context).ToArray()
            );
            context.SaveChanges();
        }

        private List<City> getCities(ClientContext context)
        {
            List<City> cities = new List<City>()
            {
                new City()
                {
                    CityName = "Vancouver",
                    Population = 110000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC").ProvinceCode
                },
                new City()
                {
                    CityName = "Richmond",
                    Population = 120000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC").ProvinceCode
                },
                new City()
                {
                    CityName = "Burnaby",
                    Population = 130000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC").ProvinceCode
                },
                new City()
                {
                    CityName = "Winnipeg",
                    Population = 210000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "MB").ProvinceCode
                },
                new City()
                {
                    CityName = "Steinbach",
                    Population = 220000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "MB").ProvinceCode
                },
                new City()
                {
                    CityName = "Morden",
                    Population = 230000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "MB").ProvinceCode
                },
                new City()
                {
                    CityName = "Saskatoon",
                    Population = 310000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "SK").ProvinceCode
                },
                new City()
                {
                    CityName = "Moose Jaw",
                    Population = 320000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "SK").ProvinceCode
                },
                new City()
                {
                    CityName = "Yorkton",
                    Population = 330000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "SK").ProvinceCode
                }
            };

            return cities;
        }

        private List<Province> getProvinces()
        {
            List<Province> provinces = new List<Province>()
            {
                new Province() { ProvinceCode="BC", ProvinceName="British Columbia" },
                new Province() { ProvinceCode="MB", ProvinceName="Manitoba" },
                new Province() { ProvinceCode="SK", ProvinceName="Saskatchewan" }
            };

            return provinces;
        }
    }
}
