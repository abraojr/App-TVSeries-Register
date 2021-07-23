using app_Series_Register.Interfaces;
using System;
using System.Collections.Generic;

namespace app_Series_Register
{
    class TVShowRepository : IRepository<TVShow>
    {
        private List<TVShow> listSeries = new List<TVShow>();
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TVShow GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(TVShow entity)
        {
            throw new NotImplementedException();
        }

        public List<TVShow> List()
        {
            throw new NotImplementedException();
        }

        public int nextId()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, TVShow entity)
        {
            throw new NotImplementedException();
        }
    }
}
