using System.Collections.Generic;
using System.Linq;
using EntityFrameworkAPI.DataLayer;
using EntityFrameworkAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkAPI.Services
{
    public class PortalUserService : IPortalUserService
    {

        ApplicationDbContext _DbContext;

        public PortalUserService(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public PortalUser addPortalUser(PortalUser portalUser)
        {
            _DbContext.PortalUsers.Add(portalUser);
            _DbContext.SaveChanges();
            return portalUser;

        }

        public PortalUser deletePortalUser(int id)
        {
            //var portalUser = _DbContext.PortalUsers.FirstOrDefault(x => x.Id == id);
            //_DbContext.Entry(portalUser).State = EntityState.Deleted;
            //_DbContext.SaveChanges();

            var portalUser = (from p in _DbContext.PortalUsers
                              where p.Id == id
                              select p).FirstOrDefault();
            _DbContext.Entry(portalUser).State = EntityState.Deleted;
            _DbContext.SaveChanges();
            return portalUser;

        }

        public IEnumerable<PortalUser> getPortalUser()
        {
            // var portalUser = _DbContext.PortalUsers.ToList();
            var portalUser = from p in _DbContext.PortalUsers
                             select p;
            return portalUser;
        }

        public IQueryable<PortalUser> getPortalUserById(int id)
        {
            //var portalUser = _DbContext.PortalUsers.FirstOrDefault(x => x.Id == id);
            IQueryable<PortalUser> portalUser = from p in _DbContext.PortalUsers
                                                where p.Id == id
                                                select p;
            return portalUser;

        }

        public PortalUser updatePortalUser(PortalUser portalUser)
        {
            _DbContext.Entry(portalUser).State = EntityState.Modified;
            _DbContext.SaveChanges();
            return portalUser;
        }
    }
}
