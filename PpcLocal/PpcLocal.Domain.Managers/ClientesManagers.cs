using PpcLocal.Domain.Db;
using PpcLocal.Domain.Dto;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PpcLocal.Domain.Managers
{
    public class ClientesManagers
    {
        public static async Task<List<ClienteDto>> GetAllList()
        {
            using (var context = new CapasDbEntities())
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
