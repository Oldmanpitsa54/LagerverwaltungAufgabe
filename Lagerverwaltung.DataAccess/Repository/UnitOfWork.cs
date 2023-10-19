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
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Artikel = new ArtikelRepository(_db);
            Artikelgruppe = new ArtikelgruppeRepository(_db);
        }
        public IArtikelRepository Artikel { get; private set; }
        public IArtikelgruppeRepository Artikelgruppe { get; private set; }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
