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
	//skips the specified number of records in the recordset
	var skip3Employees = Employees.Skip(3);
	Console.WriteLine(skip3Employees);
	
	//var skipToLast3Employees = Employees.SkipLast(3);
	//Console.WriteLine(skipToLast3Employees);
	
	//get the last elements of a collection 
	var skipToLast3Employees = Employees.Skip(Employees.Count() -2);
	Console.WriteLine(skipToLast3Employees);
	
	//get last half of a record set
	var skipToSecondHalfEmployees = Employees.Skip(Employees.Count() /2);
	Console.WriteLine(skipToSecondHalfEmployees);
}

// You can define other methods, fields, classes and namespaces here
