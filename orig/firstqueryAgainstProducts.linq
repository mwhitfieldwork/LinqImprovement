<Query Kind="Expression">
  <Connection>
    <ID>1c4ef100-87b6-4b22-a1b2-30f15826a07b</ID>
    <Persist>true</Persist>
    <Server>.\sqlexpress</Server>
    <Database>CityTour</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

/* first linq query */
Products.Where(x => x.Price > 2)
		.OrderBy(x => x.Name)
		.Select(x => new{
			x.Name,
			x.Price
		})