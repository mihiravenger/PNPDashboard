using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PNPDashboard.Server.Storage;
using PNPDashboard.Shared;
using PNPDashboard.Shared.Models;

namespace PNPDashboard.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AffiliateMappingController : ControllerBase
    {
        private readonly IRepository<AffiliateMapping> _earningRepository;
        public AffiliateMappingController(IRepository<AffiliateMapping> earningRepository)
        {
            _earningRepository = earningRepository;
        }

        [HttpGet]
        public IEnumerable<AffiliateMapping> Get()
        {
            return _earningRepository.GetAll()
                .OrderBy(AffiliateMapping => AffiliateMapping.CreatedDate);
        }
    }
}
