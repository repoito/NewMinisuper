using Microsoft.EntityFrameworkCore;
using ProyectoFinalAPI.Data;
using ProyectoFinalAPI.Models;
using ProyectoFinalAPI.Repositories.IRepository;

namespace ProyectoFinalAPI.Repositories
{
    public class EmpleadoRepository : Repository<Empleadoo>, IEmpleadoRepository
    {
        private readonly AppDbContext _db;

        public EmpleadoRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Empleadoo> GetEmpleadoo(int Id, string Nombre)
        {
            return await _db.Empleados.FirstOrDefaultAsync(u => u.Id == Id && u.Nombre == Nombre);
        }
    }
}
