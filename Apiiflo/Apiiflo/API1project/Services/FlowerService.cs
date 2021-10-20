using API1project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1project.Services
{
    public class FlowerService
    {
        private readonly CompanyContext _context;

        public FlowerService(CompanyContext context)
        {
            _context = context;
        }
        public Flower Add(Flower flower)
        {
            try
            {
                _context.Flowers.Add(flower);
                _context.SaveChanges();
                return flower;
            }
            catch (DbUpdateConcurrencyException Dbce)
            {
                Console.WriteLine(Dbce.Message);
            }
            catch (DbUpdateException Dbe)
            {
                Console.WriteLine(Dbe.Message);
            }
            return null;
        }

        public List<Flower> GetAll()
        {
            List<Flower> flowers = _context.Flowers.ToList();
            return flowers;
        }
        //public ICollection<flower> GetAll()
        //{
        //    if (_context.Flowers.ToList().Count > 0)
        //        return _context.Flowers.ToList();
        //    else
        //        return null;
        //}


    }
}
