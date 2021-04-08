using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SeedingServer
    {
        private SalesWebMVCContext _context;
        public SeedingServer(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() || _context.Seller.Any()|| _context.SalesRecord.Any())
            {
                return;
            }
            Department d1 = new Department(6, "Computer");
            Department d2 = new Department(7, "Books");
            Department d3 = new Department(8, "Eletronics");
            Department d4 = new Department(9, "Fashion");
            Department d5 = new Department(10, "Food");

            Seller s1 = new Seller(1, "Bob Brown", "bob@to.com",1000, new DateTime(1998, 4, 21),d1);
            Seller s2 = new Seller(2, "sadsad", "bob@to.com", 1000, new DateTime(1998, 4, 21), d2);
            Seller s3 = new Seller(3, "dsadasd", "bob@to.com", 1000, new DateTime(1998, 4, 21), d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 4, 21), 11000, Models.Enums.SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 4, 21), 11000, Models.Enums.SaleStatus.Billed, s2);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Seller.AddRange(s1, s2, s3);
            _context.SalesRecord.AddRange(r1, r2);

            _context.SaveChanges();

        }
    }
}
