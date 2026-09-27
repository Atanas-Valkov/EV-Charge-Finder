using EVChargeFinder.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EVChargeFinder.Data.Seeding
{
    public static class OperatorSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            Operator[] operators =
            {
                new Operator
                {
                    Name = "Eldrive",
                    Website = "https://eldrive.eu"
                },
                new Operator
                {
                    Name = "Fines Charging",
                    Website = "https://finescharging.com"
                },
                new Operator
                {
                    Name = "Electrip",
                    Website = "https://electripglobal.com"
                },
                new Operator
                {
                    Name = "EVPoint",
                    Website = "https://evpoint.bg"
                },
                new Operator
                {
                    Name = "GigaCharger",
                    Website = "https://gigacharger.net"
                },
                new Operator
                {
                    Name = "Electrocharge",
                    Website = "https://electrocharge.bg"
                },
                new Operator
                {
                    Name = "OMV eMotion",
                    Website = "https://www.omv.bg"
                },
                new Operator
                {
                    Name = "Elfinity",
                    Website = "https://elfinity.bg"
                },
                new Operator
                {
                    Name = "Kia Hypercharge",
                    Website = "https://kia.bg"
                },
                new Operator
                {
                    Name = "GPStation",
                    Website = "https://gpstation.eu"
                },
                new Operator
                {
                    Name = "WINK Charging",
                    Website = "https://winkcharging.com"
                },
                new Operator
                {
                    Name = "Voltspot",
                    Website = "https://voltspot.net"
                },
                new Operator
                {
                    Name = "EVN2GO",
                    Website = "https://www.evn.bg"
                },
                new Operator
                {
                    Name = "Tesla Supercharger",
                    Website = "https://www.tesla.com/supercharger"
                },
                new Operator
                {
                    Name = "Varna Charging",
                    Website = "https://varnacharging.bg"
                },
                new Operator
                {
                    Name = "BullCharge",
                    Website = "https://bullcharge.bg"
                },
                new Operator
                {
                    Name = "eCars",
                    Website = "https://ecars.bg"
                },
                new Operator
                {
                    Name = "ProCredit Charging",
                    Website = "https://www.procreditbank.bg"
                }
            };


            foreach (Operator operatorEntity in operators)
            {
                bool operatorExists = context.Operators
                    .Any(o => o.Name == operatorEntity.Name);

                if (operatorExists)
                {
                    continue;
                }

                context.Operators.Add(operatorEntity);
            }

            context.SaveChanges();
        }
    }
}