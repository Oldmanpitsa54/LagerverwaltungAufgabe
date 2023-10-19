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
    public class ArtikelgruppeRepository : Repository<Artikelgruppe>, IArtikelgruppeRepository
    {
        private ApplicationDbContext _db;
        public ArtikelgruppeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Artikelgruppe obj)
        {
            _db.Artikelsgruppen.Update(obj);
        }
    }
}
