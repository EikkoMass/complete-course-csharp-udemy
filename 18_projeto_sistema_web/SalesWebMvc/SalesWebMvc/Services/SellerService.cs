using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exceptions;

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
        return _context.Seller
            .Include(seller => seller.Department)
            .FirstOrDefault(seller => seller.Id == id);
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
    
    public void Update(Seller obj)
    {
        if(!_context.Seller.Any(seller => seller.Id == obj.Id))
        {
            throw new NotFoundException("Id not found");
        }
        
        try
        {
            _context.Seller.Update(obj);
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }
}