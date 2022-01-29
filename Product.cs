public class Product
{
    public int Id { get; set; } 

    public string Name { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }

    public int Valor { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; }

    public List<Tag> Tags { get; set; } 

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