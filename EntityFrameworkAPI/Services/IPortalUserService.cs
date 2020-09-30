using System.Collections.Generic;
using System.Linq;
using EntityFrameworkAPI.Model;

namespace EntityFrameworkAPI.Services
{
    public interface IPortalUserService
    {
        IEnumerable<PortalUser> getPortalUser();

        IQueryable<PortalUser> getPortalUserById(int id);
        PortalUser addPortalUser(PortalUser portalUser);
        PortalUser updatePortalUser(PortalUser portalUser);
        PortalUser deletePortalUser(int id);
    }
}
