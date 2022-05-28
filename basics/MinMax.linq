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
	var LeastExpensiveProduct = Products.Min(x => x.UnitPrice);
	Console.WriteLine(LeastExpensiveProduct);
	
	var MostExpensiveProduct = Products.Max(x => x.UnitPrice);
	Console.WriteLine(MostExpensiveProduct);
	
	//Or there may be a column in the table
	//var minAmount = Products.OrderBy( x = x.MinAmount).First().MinAmount;
	//var maxAmount = Products.OrderByDescending( x => x.MAxAmount).First().MAxAmount;
}

// You can define other methods, fields, classes and namespaces here
