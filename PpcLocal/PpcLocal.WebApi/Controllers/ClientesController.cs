using PpcLocal.Domain.Dto;
using PpcLocal.Domain.Managers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace PpcLocal.WebApi.Controllers
{
    public class ClientesController : ApiController
    {
        [ResponseType(typeof(IEnumerable<ClienteDto>))]
        public async Task<IHttpActionResult> Get()
        {
            var listado = await ClientesManagers.GetAllList();
            if (listado == null)
            {
                return NotFound();
            }
            return Ok(listado);
        }
    }
}
