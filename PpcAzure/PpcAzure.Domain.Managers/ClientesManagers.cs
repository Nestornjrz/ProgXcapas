using PpcAzure.Domain.Db;
using PpcAzure.Domain.Dto;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PpcAzure.Domain.Managers
{
    public class ClientesManagers
    {
        public static async Task<List<ClienteDto>> GetAllList()
        {
            using (var context = new CapasDbEntities("LoqueSea", true))
            {
                var listado = await context.Clientes.Select(s => new ClienteDto()
                {
                    ClienteID = s.ClienteID,
                    Nombre = s.Nombre,
                    Apellido = s.Apellido
                }).ToListAsync();
                return listado;
            }
        }
    }
}
