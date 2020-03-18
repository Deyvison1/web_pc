using System.Collections.Generic;
using System.Linq;
using web_pc.Data;
using web_pc.Models;
using Microsoft.EntityFrameworkCore;

namespace web_pc.Service
{
    public class SellerService
    {
        private readonly web_pcContext _context;
        public SellerService(web_pcContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

    }
}
