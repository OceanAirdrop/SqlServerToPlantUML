using SqlServerToPlantUML.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerToPlantUML
{
    class Program
    {
        private static string m_connString;
        static void Main(string[] args)
        {
            m_connString = @"Data Source=MACHINENAME;Initial Catalog=AdventureWorks2014;Persist Security Info=True;User ID=sa;Password=MYPASSWORD;Connect Timeout=30;Application Name=AppName.exe";

            GenerateAllTables();
            GeneratePersonSchema();
            GenerateHumanResourcesSchema();
            GenerateProductionSchema();
        }

        private static void GenerateAllTables()
        {
            var plantUml = new GenerateSqlServerTables(m_connString);
            var tableList = plantUml.Execute();

            var plantUMLText = GeneratePlantUMLDiagram.GenerateAllRelationships(tableList, "SomeTitle", "AdventureWorks2014 - All Tables.txt");

        }

        private static void GeneratePersonSchema()
        {
            var personSchema = new GenerateSqlServerTables(m_connString);

            var tablesToInclude = new List<string>();
            tablesToInclude.Add("Person.Password");
            tablesToInclude.Add("Person.Person");
            tablesToInclude.Add("Person.PersonPhone");
            tablesToInclude.Add("Person.PhoneNumberType");
            tablesToInclude.Add("Person.EmailAddress");
            tablesToInclude.Add("Person.ContactType");
            tablesToInclude.Add("Person.Address");
            tablesToInclude.Add("Person.AddressType");
            tablesToInclude.Add("Person.StateProvince");
            tablesToInclude.Add("Person.BusinessEntity");
            tablesToInclude.Add("Person.BusinessEntityAddress");
            tablesToInclude.Add("Person.BusinessEntityContact");
            tablesToInclude.Add("Person.CountryRegion");
            
            var tableList = personSchema.Execute(tablesToInclude: tablesToInclude);
            var plantUMLText = GeneratePlantUMLDiagram.GenerateAllTables(tableList, "SomeTitle", "AdventureWorks2014 - Person Schema.txt", true);

        }

        private static void GenerateHumanResourcesSchema()
        {
            var personSchema = new GenerateSqlServerTables(m_connString);

            var tablesToInclude = new List<string>();
            tablesToInclude.Add("HumanResources.Shift");
            tablesToInclude.Add("HumanResources.Department");
            tablesToInclude.Add("HumanResources.Employee");
            tablesToInclude.Add("HumanResources.EmployeeDepartmentHistory");
            tablesToInclude.Add("HumanResources.EmployeePayHistory");
            tablesToInclude.Add("HumanResources.JobCandidate");

            var tableList = personSchema.Execute(tablesToInclude: tablesToInclude);
            var plantUMLText = GeneratePlantUMLDiagram.GenerateAllTables(tableList, "SomeTitle", "AdventureWorks2014 - HumanResources Schema.txt", true);

        }

        private static void GenerateProductionSchema()
        {
            var personSchema = new GenerateSqlServerTables(m_connString);

            var tablesToInclude = new List<string>();
            tablesToInclude.Add("Production.WorkOrder");
            tablesToInclude.Add("Production.UnitMeasure");
            tablesToInclude.Add("Production.TransactionHistoryArchive");
            tablesToInclude.Add("Production.ProductSubcategory");
            tablesToInclude.Add("Production.ProductModelIllustration");
            tablesToInclude.Add("Production.ProductPhoto");
            tablesToInclude.Add("Production.ProductProductPhoto");
            tablesToInclude.Add("Production.TransactionHistory");
            tablesToInclude.Add("Production.ProductReview");
            tablesToInclude.Add("Production.ProductListPriceHistory");
            tablesToInclude.Add("Production.ProductModelProductDescriptionCulture");
            tablesToInclude.Add("Production.BillOfMaterials");
            tablesToInclude.Add("Production.ProductCategory");
            tablesToInclude.Add("Production.ProductCostHistory");
            tablesToInclude.Add("Production.ProductDescription");
            tablesToInclude.Add("Production.ProductInventory");
            tablesToInclude.Add("Production.ScrapReason");
            tablesToInclude.Add("Production.ProductDocument");
            tablesToInclude.Add("Production.Culture");
            tablesToInclude.Add("Production.WorkOrderRouting");
            tablesToInclude.Add("Production.Document");
            tablesToInclude.Add("Production.ProductModel");
            tablesToInclude.Add("Production.Product");
            tablesToInclude.Add("Production.Illustration");
            tablesToInclude.Add("Production.Location");

            var tableList = personSchema.Execute(tablesToInclude: tablesToInclude);
            var plantUMLText = GeneratePlantUMLDiagram.GenerateAllTables(tableList, "SomeTitle", "AdventureWorks2014 - Production Schema.txt", true);

        }
    }
}
