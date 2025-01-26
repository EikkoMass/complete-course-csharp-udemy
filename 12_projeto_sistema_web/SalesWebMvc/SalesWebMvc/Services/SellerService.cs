using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services;

public class SellerService
{
    private readonly SalesWebMvcContext _context;

    public SellerService(SalesWebMvcContext context)
    {
        _context = context;
    }

    public List<Seller> FindAll()
    {
        return _context.Seller.ToList();
    }
    
    public Seller? FindById(int id)
    {
        return _context.Seller.FirstOrDefault(seller => seller.Id == id);
    }
    
    public void Insert(Seller seller)
    {
        _context.Seller.Add(seller);
        _context.SaveChanges();
    }

    public void Remove(int id)
    {
        var obj = _context.Seller.Find(id);

        if (obj != null)
        {
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}