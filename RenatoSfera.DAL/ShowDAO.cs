using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using RenatoSfera.DOM;

namespace RenatoSfera.DAL
{
    public class ShowDAO
    {
        private Entities db = new Entities();
        public void Delete(Show objShow)
        {
            using (Entities db = new Entities())
            {
                db.Show.Attach(objShow);
                db.Show.Remove(objShow);
                db.SaveChanges();
            }
        }

        public Show Create(Show objShow)
        {
            using (Entities db = new Entities())
            {
                db.Show.Add(objShow);
                db.SaveChanges();
                return objShow;
            }
        }

        public List<Show> FindAll()
        {
            using (Entities db = new Entities())
            {
                var listaShows = db.Show.ToList();
                return listaShows;
            }
        }
    }
}
