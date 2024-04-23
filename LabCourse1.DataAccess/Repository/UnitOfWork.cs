using LabCourse1.DataAccess.Data;
using LabCourse1.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCourse1.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {


        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
