using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoFixture;
using Lagerverwaltung.DataAccess.Data;
using Lagerverwaltung.DataAccess.Repository;
using Lagerverwaltung.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Moq.EntityFrameworkCore;
using Xunit;

namespace UnitTesting
{
    public class ArtikelgruppeCRUDTest
    {
        private ApplicationDbContext _db;
        private UnitOfWork _unitOfWork;
        public ArtikelgruppeCRUDTest(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task CreateArtikelgruppe()
        {
            //Arrange
            var fixture = new Fixture();
            var neueArtikelgruppe = fixture.Create<Artikelgruppe>();
                
            foreach(var entity in _db.Artikelsgruppen)
            {
                _db.Artikelsgruppen.Remove(entity);
            }
            _db.Artikelsgruppen.Add(neueArtikelgruppe);
            _unitOfWork = new UnitOfWork(_db);

            //Act
            _unitOfWork.Artikelgruppe.Add(neueArtikelgruppe);

            //Assert
            var result = _db.Artikelsgruppen.FirstOrDefault();
            Assert.Equal(result, neueArtikelgruppe);
        }
        public async Task GetArtikelgruppe()
        {
            //Arrange
            var fixture = new Fixture();
            var neueArtikelgruppe = fixture.Create<Artikelgruppe>();

            foreach (var entity in _db.Artikelsgruppen)
            {
                _db.Artikelsgruppen.Remove(entity);
            }
            _db.Artikelsgruppen.Add(neueArtikelgruppe);
            _unitOfWork = new UnitOfWork(_db);

            //Act
            _unitOfWork.Artikelgruppe.GetFirstOrDefault(x => x.Id == neueArtikelgruppe.Id);

            //Assert
            var result = _db.Artikelsgruppen.FirstOrDefault();
            Assert.Equal(result, neueArtikelgruppe);
        }
        public async Task UpdateArtikelgruppe()
        {
            //Arrange
            var fixture = new Fixture();
            var neueArtikelgruppe = fixture.Create<Artikelgruppe>();

            foreach (var entity in _db.Artikelsgruppen)
            {
                _db.Artikelsgruppen.Remove(entity);
            }
            _db.Artikelsgruppen.Add(neueArtikelgruppe);
            _unitOfWork = new UnitOfWork(_db);

            if (neueArtikelgruppe.Name != "0")
            {
                neueArtikelgruppe.Name = "0";
            }
            else
            {
                neueArtikelgruppe.Name = "1";
            }

            //Act
            _unitOfWork.Artikelgruppe.Update(neueArtikelgruppe);
            _unitOfWork.Save();

            //Assert
            var result = _db.Artikelsgruppen.FirstOrDefault();
            Assert.Equal(result, neueArtikelgruppe);
        }
        public async Task DeleteArtikelgruppe()
        {
            //Arrange
            var fixture = new Fixture();
            var neueArtikelgruppe = fixture.Create<Artikelgruppe>();

            foreach (var entity in _db.Artikelsgruppen)
            {
                _db.Artikelsgruppen.Remove(entity);
            }
            _db.Artikelsgruppen.Add(neueArtikelgruppe);
            _unitOfWork = new UnitOfWork(_db);


            //Act
            _unitOfWork.Artikelgruppe.Remove(neueArtikelgruppe);

            //Assert
            var result = _unitOfWork.Artikelgruppe.GetFirstOrDefault(x => x.Id == neueArtikelgruppe.Id);
            Assert.Equal(result, neueArtikelgruppe);
        }
    }
}
