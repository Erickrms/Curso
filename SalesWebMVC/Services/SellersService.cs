using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellersService
    {
        private readonly SalesWebMVCContext _context;

        public SellersService(SalesWebMVCContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {

            _context.Add(obj);
            _context.SaveChanges();

        }
    }
}
