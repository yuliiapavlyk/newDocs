﻿using System.Collections.Generic;

namespace MyDocuments.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T item);
        void Update(T item);
        void Remove(int id);

    }
}
