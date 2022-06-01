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
	var numbers = new[] {1,3,5,8,19,20,55};
	var add100InArrayToEnd = numbers.Append(120);
	var add100InArrayToBeginning = numbers.Prepend(222);
	var addBothEndsOfArray = numbers.Append(120).Prepend(500);//usually used together
	
	Console.WriteLine(numbers);//original array
	Console.WriteLine(add100InArrayToEnd);
	Console.WriteLine(add100InArrayToBeginning);
	Console.WriteLine(addBothEndsOfArray);
}

// You can define other methods, fields, classes and namespaces here
