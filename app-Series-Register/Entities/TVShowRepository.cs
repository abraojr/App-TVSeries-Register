using app_Series_Register.Interfaces;
using System.Collections.Generic;

namespace app_Series_Register
{
    class TVShowRepository : IRepository<TVShow>
    {
        private List<TVShow> listSeries = new List<TVShow>();
        public void Delete(int id)
        {
            listSeries[id].Delete();
        }

        public TVShow GetById(int id)
        {
            return listSeries[id];
        }

        public void Insert(TVShow entity)
        {
            listSeries.Add(entity);
        }

        public List<TVShow> List()
        {
            return listSeries;
        }

        public int nextId()
        {
            return listSeries.Count;
        }

        public void Update(int id, TVShow entity)
        {
            listSeries[id] = entity;
        }
    }
}
