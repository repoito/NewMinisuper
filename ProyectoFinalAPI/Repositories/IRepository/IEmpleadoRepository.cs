using ProyectoFinalAPI.Models;

namespace ProyectoFinalAPI.Repositories.IRepository
{
    public interface IEmpleadoRepository : IRepository<Empleadoo>
    {
        Task<Empleadoo> GetEmpleadoo(int Id, string Nombre);
    }
}
