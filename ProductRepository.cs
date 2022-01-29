public static class ProductRepository
{
    public static List<Product> Products { get; set; } = Products = new List<Product> ();

    public static void Init(IConfiguration configuration)
    {
        var products = configuration.GetSection("Products").Get<List<Product>>();
        Products = products;
    }


    public static void Add(Product product)
    {
        if (Products == null)
            Products = new List<Product>();

        Products.Add(product);
    }

    public static Product GetBy(string code) //Editar
    {
        return Products.FirstOrDefault(p => p.Code == code);

    }

    public static void Remove(Product product)
    {
        Products.Remove(product);
    }
}  







//==========================================================================================

//return product.Name + (" - ") + product.Code;



//api.app.com/user?getproduct={date}&dataend={date}
//app.MapGet("/getproductoutro", ([FromQuery] string dateStart, [FromQuery] string dateEnd) => {
// return dateStart + " - " + dateEnd;
//});

//api.app.com/user/{code}
//app.MapGet("/getproduct/{code}", ([FromRoute] string code) => {
//var product = ProductRepository.GetBy(code);
//});