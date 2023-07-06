﻿using Shipping_System.Models;
namespace Shipping_System.Repository.RepresentiveRepo
{
    public interface IRepresentativeRepository
    {
        List<Representative> GetAll();
        Representative GetById(string id);
        void Add(Representative rep);
        void Edit(Representative rep);
        void Delete(string id);
        void Save();
    }
}
