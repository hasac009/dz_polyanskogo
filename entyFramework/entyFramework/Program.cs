
using entyFramework;

 using Contex db = new Contex();

await db.Database.EnsureDeletedAsync();
await db.Database.EnsureCreatedAsync();

User u1 = new User() { Email = "liza@mail.com", Name = "Liza"};

House h1 = new House() { address = "Zestafonska - 1"};
Product p1 = new Product() { Name = "beer", Description = "+18" };
await db.Houses.AddAsync(h1);
await db.Users.AddAsync(u1);
await db.Products.AddAsync(p1);


if (await db.Database.CanConnectAsync())
    await db.SaveChangesAsync();


