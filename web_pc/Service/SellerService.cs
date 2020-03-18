using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_pc.Data;
using web_pc.Models;

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

    }
}
