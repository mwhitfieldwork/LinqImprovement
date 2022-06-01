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
  <RuntimeVersion>3.1</RuntimeVersion>
</Query>

void Main()
{
	//takes the specified number of result at the beginning of the record set
	var threeHeaviestOrders = Orders.OrderByDescending(x => x.Freight).Take(3).ToList();
	var secondHeaviestOrder = Orders.OrderByDescending(x => x.Freight).Take(2).First();
	var onePercentOfOrders = Orders.Take((int)(Orders.Count() *0.01));
	//var smallerThanFiftyLbs = Orders.TakeWhile( x => x.Freight < 50);
	
	//get first half of a record set
	var skipToSecondHalfEmployees = Employees.Take(Employees.Count() /2);
	Console.WriteLine(skipToSecondHalfEmployees);
	
	Console.WriteLine(threeHeaviestOrders);
	Console.WriteLine(secondHeaviestOrder);
	Console.WriteLine(onePercentOfOrders);
	//Console.WriteLine(smallerThanFiftyLbs);
}

