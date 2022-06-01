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

	    //OfType returns all the objects of given type
	    var objects = new object[]
	    {
	        null,
	        1,
	        "all",
	        2,
	        "ducks",
	        new List<int>(),
	        "are",
	        "awesome",
	        true
	    };

	    var strings = objects.OfType<string>();
	    Console.WriteLine(strings);

	    //it's often used when operating on multiple types with one interface
	    var flyables = new List<IFlyable>()
	    {
	        new Bird(),
	        new Plane(),
	        new Helicopter()
	    };
		
		//list by the datatype
	    var birds = flyables.OfType<Bird>();
	    Console.WriteLine(birds);
		
		//list by the interface type
	    var fuelables = flyables.OfType<IFuelable>();
	    Console.WriteLine(fuelables);
}


    interface IFlyable
    {
        public void Fly();
    }

    interface IFuelable
    {
        public void Fuel();
    }

    class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying by flapping my wings");
        }
    }

    class Plane : IFlyable, IFuelable
    {
        public void Fly()
        {
            Console.WriteLine("Flying by jet propulsion");
        }

        public void Fuel()
        {
            Console.WriteLine("Fuelling my large gas tank");
        }
    }

    class Helicopter : IFlyable, IFuelable
    {
        public void Fly()
        {
            Console.WriteLine("Flying by rotating my rotors");
        }

        public void Fuel()
        {
            Console.WriteLine("Fuelling my gas tank");
        }
    }
// You can define other methods, fields, classes and namespaces here
