using ProyectoFinalAPI.Models;

namespace ProyectoFinalAPI.Repositories.IRepository
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<Producto> Update(Producto entity);
    }
}
