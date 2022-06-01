<Query Kind="Program">
  <Connection>
    <ID>98373725-6ef6-4a8e-a855-1180a3d095b9</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <Server>DESKTOP-KLVRS0S\SQLEXPRESS</Server>
    <Database>northwind</Database>
    <DriverData>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

void Main()
{
	 var numbers = new[] { 10, 1, 10, 4, 17, 17, 122 };
	 var distinctNumbs = numbers.Distinct();
	 Console.WriteLine(distinctNumbs);
	 
	 //List<Employee> Employees = EmployeeTerritories.Select(x => (Employee)x.Employee);
	 //var distinctEmployees = 
	 Console.WriteLine(Employees);
}

public class Employee {

    public class Employees
    {
        
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string BirthDate { get; set; }

        public string HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public int Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public string ReportsTo { get; set; }
        public string PhotoPath { get; set; }
    }
	
	
}
// You can define other methods, fields, classes and namespaces here
