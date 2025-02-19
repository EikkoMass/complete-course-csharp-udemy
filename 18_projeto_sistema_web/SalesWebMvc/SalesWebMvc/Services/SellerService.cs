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

    public async Task<List<Seller>> FindAllAsync()
    {
        return await _context.Seller.ToListAsync();
    }
    
    public async Task<Seller?> FindByIdAsync(int id)
    {
        return await _context.Seller
            .Include(seller => seller.Department)
            .FirstOrDefaultAsync(seller => seller.Id == id);
    }
    
    public async Task InsertAsync(Seller seller)
    {
        _context.Seller.Add(seller);
        await _context.SaveChangesAsync();
    }

    public async Task RemoveAsync(int id)
    {
        try
        {
            var obj = await _context.Seller.FindAsync(id);

            if (obj != null)
            {
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
        }
        catch (DbUpdateException e)
        {
            throw new IntegrityException(e.Message);
        }
    }
    
    public async Task Update(Seller obj)
    {
        bool hasAny = await _context.Seller.AnyAsync(seller => seller.Id == obj.Id);
        
        if(!hasAny)
        {
            throw new NotFoundException("Id not found");
        }
        
        try
        {
            _context.Seller.Update(obj);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }
}