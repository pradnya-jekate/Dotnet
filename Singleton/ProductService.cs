using System.Runtime.InteropServices.Swift;

namespace ECommerce;
public sealed class ProductService
{
    private static ProductService _ref=null;

    private ProductService()
    {
        Console.WriteLine("Constructor is called");
    }

    public static ProductService CreateInstance()
    {
        if(_ref==null)
        {
            _ref=new ProductService();
        }
        return _ref;
    }
    public void Serve()
    {
        Console.WriteLine("Serving Customer");
    }
}