public class Category
{
    public string Id { get; set; }

    public string Name { get; set; }
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