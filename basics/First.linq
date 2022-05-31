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
	var firstProductAsc = Products.First();
	Console.WriteLine(firstProductAsc);
	
	var firstProductThatMeetsCriteria = Products.Where(x => x.UnitsInStock >30).First();
	Console.WriteLine(firstProductThatMeetsCriteria);
}

// You can define other methods, fields, classes and namespaces here
