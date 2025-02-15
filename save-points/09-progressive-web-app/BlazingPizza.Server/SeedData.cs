namespace BlazingPizza.Server;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var toppings = new Topping[]
{
    new Topping() { Name = "Queso extra", Price = 2.50m },
            new Topping() { Name = "Bacon americano", Price = 2.99m },
            new Topping() { Name = "Bacon británico", Price = 2.99m },
            new Topping() { Name = "Bacon canadiense", Price = 2.99m },
            new Topping() { Name = "Té y bollos ingleses", Price = 5.00m },
            new Topping() { Name = "Scones recién horneados", Price = 4.50m },
            new Topping() { Name = "Pimientos", Price = 1.00m },
            new Topping() { Name = "Cebolla", Price = 1.00m },
            new Topping() { Name = "Champiñones", Price = 1.00m },
            new Topping() { Name = "Pepperoni", Price = 1.00m },
            new Topping() { Name = "Salchicha de pato", Price = 3.20m },
            new Topping() { Name = "Albóndigas de venado", Price = 2.50m },
            new Topping() { Name = "Servido en una bandeja de plata", Price = 250.99m },
            new Topping() { Name = "Langosta encima", Price = 64.50m },
            new Topping() { Name = "Caviar de esturión", Price = 101.75m },
            new Topping() { Name = "Corazones de alcachofa", Price = 3.40m },
            new Topping() { Name = "Tomates frescos", Price = 1.50m },
            new Topping() { Name = "Albahaca", Price = 1.50m },
            new Topping() { Name = "Bistec (punto medio)", Price = 8.50m },
            new Topping() { Name = "Pimientos súper picantes", Price = 4.20m },
            new Topping() { Name = "Pollo estilo Buffalo", Price = 5.00m },
            new Topping() { Name = "Queso azul", Price = 2.50m }
};


        var specials = new PizzaSpecial[]
{
    new PizzaSpecial()
    {
            Name = "¡Barbacoa Brutal!",
            Description = "Con más queso del que la humanidad necesita y una salsa barbacoa que hará que tus papilas gustativas bailen flamenco.",
            BasePrice = 9.99m,
            ImageUrl = "img/pizzas/pizza-barbacoa.png",
    },
    new PizzaSpecial()
    {
            Id = 2,
            Name = "Montaña de Champiñones",
            Description = "Si amas los champiñones más que tu propia vida, esta es tu pizza. Setas everywhere.",
            BasePrice = 11.99m,
            ImageUrl = "img/pizzas/pizza-champiñones.png",
    },
    new PizzaSpecial()
    {
            Id = 3,
            Name = "La Cuatroquesística",
            Description = "Cuatro quesos, cuatro veces más felicidad. No apta para intolerantes a la epicidad.",
            BasePrice = 10.50m,
            ImageUrl = "img/pizzas/pizza-cuatro-quesos.png",
    },
    new PizzaSpecial()
    {
            Id = 4,
            Name = "EspinaCaliente",
            Description = "¿Quién dijo que las espinacas son aburridas? Esta pizza te hará reconsiderarlo... o al menos sudar un poco.",
            BasePrice = 12.75m,
            ImageUrl = "img/pizzas/pizza-espinacas.png",
    },
    new PizzaSpecial()
    {
            Id = 5,
            Name = "York & Queso Deluxe",
            Description = "Un clásico de la infancia, pero ahora en versión ‘wow’. Más york, más queso, más amor.",
            BasePrice = 11.00m,
            ImageUrl = "img/pizzas/Pizza-Jamon-York-y-Queso.png",
    },
    new PizzaSpecial()
    {
            Id = 6,
            Name = "La Margarita Suprema",
            Description = "Simple, elegante y con más sabor que una telenovela de tres temporadas.",
            BasePrice = 10.25m,
            ImageUrl = "img/pizzas/pizza-margarita.png",
    },
    new PizzaSpecial()
    {
            Id = 7,
            Name = "Napolitana Nostálgica",
            Description = "Sabe a tradición, a Italia y a vacaciones que nunca tomaste.",
            BasePrice = 11.50m,
            ImageUrl = "img/pizzas/pizza-napolitana.png",
    },
    new PizzaSpecial()
    {
            Id = 8,
            Name = "Peperoni Extremo",
            Description = "Si el peperoni fuera una religión, esta pizza sería su dios.",
            BasePrice = 9.99m,
            ImageUrl = "img/pizzas/pizza-peperoni.jpg",
    },
};


        db.Toppings.AddRange(toppings);
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}