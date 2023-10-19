using Lagerverwaltung.DataAccess.Data;
using Lagerverwaltung.DataAccess.Repository.IRepository;
using Lagerverwaltung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.DataAccess.Repository
{
    public class ArtikelRepository : Repository<Artikel>, IArtikelRepository
    {
        private ApplicationDbContext _db;
        public ArtikelRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Artikel obj)
        {
            _db.Artikels.Update(obj);
        }
    }
}
