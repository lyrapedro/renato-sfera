using RenatoSfera.DAL;
using RenatoSfera.DOM;
using System.Collections.Generic;

namespace RenatoSfera.BLL
{
    public class ShowBLL
    {
        private ShowDAO objShowDao;

        public ShowBLL()
        {
            objShowDao = new ShowDAO();

        }

        public List<Show> FindAll()
        {
            return objShowDao.FindAll();
        }
    }
}
