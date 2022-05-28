<Query Kind="Expression">
  <Connection>
    <ID>1c4ef100-87b6-4b22-a1b2-30f15826a07b</ID>
    <Persist>true</Persist>
    <Server>.\sqlexpress</Server>
    <Database>CityTour</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

Products.Join(Categories,
			 p => p.CategoryId,
			 c => c.Id, (p,c) => new 
			 {
			 p.Name,
			 p.Price,
			 categoryName = c.Name
			 })
		.OrderByDescending( c => c.Price)
		.ThenBy(p => p.Name)
			