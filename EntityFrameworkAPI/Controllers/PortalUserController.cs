using System.Collections.Generic;
using System.Linq;
using EntityFrameworkAPI.Model;
using EntityFrameworkAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PortalUserController : ControllerBase
    {

        private readonly IPortalUserService _portalUserService;

        public PortalUserController(IPortalUserService portalUserService)
        {
            _portalUserService = portalUserService;
        }


        [HttpGet]
        [Route("GetPortalUsers")]
        public IEnumerable<PortalUser> getPortalUser()
        {
            return _portalUserService.getPortalUser();
        }

        [HttpGet]
        [Route("GetPortalUserById")]
        public IQueryable<PortalUser> getPortalUserById(int id)
        {
            return _portalUserService.getPortalUserById(id);
        }

        [HttpPost]
        [Route("AddPortalUser")]
        public PortalUser addPortalUser(PortalUser portalUser)
        {
            return _portalUserService.addPortalUser(portalUser);
        }

        [HttpDelete]
        [Route("DeletePortalUser")]
        public PortalUser deletePortalUser(int id)
        {
            return _portalUserService.deletePortalUser(id);
        }

        [HttpPost]
        [Route("UpdatePortalUser")]
        public PortalUser updatePortalUser(PortalUser portalUser)
        {
            return _portalUserService.updatePortalUser(portalUser);
        }
    }
}
