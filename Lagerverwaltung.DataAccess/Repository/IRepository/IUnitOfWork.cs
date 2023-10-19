using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IArtikelgruppeRepository Artikelgruppe { get; }
        IArtikelRepository Artikel { get; }
        void Save();
    }
}
