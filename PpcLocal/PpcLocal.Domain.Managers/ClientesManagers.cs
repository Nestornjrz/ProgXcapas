using PpcLocal.Domain.Db;
using PpcLocal.Domain.Dto;

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

                }).ToListAsync();
                return listado;
            }
        }
    }
}
