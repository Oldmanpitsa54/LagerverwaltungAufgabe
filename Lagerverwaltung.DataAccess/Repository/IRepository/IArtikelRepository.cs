using Lagerverwaltung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerverwaltung.DataAccess.Repository.IRepository
{
    public interface IArtikelRepository : IRepository<Artikel>
    {
        void Update(Artikel obj);
    }
}
