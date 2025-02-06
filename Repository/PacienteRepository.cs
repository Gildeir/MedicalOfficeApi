using MedicalOfficeApi.Context;
using MedicalOfficeApi.Model.Entities;
using MedicalOfficeApi.Repository.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace MedicalOfficeApi.Repository
{
    public class PacienteRepository : BaseRepository, IPacienteRepository
    {
        private readonly MediaOfficeContext _context;

        public PacienteRepository(MediaOfficeContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Paciente>> Get()
        {
            return await _context.Pacientes.ToListAsync();
        }

        public async Task<Paciente> GetById(int id)
        {
            return await _context.Pacientes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> Delete(int id)
        {
            var remove = await _context.Pacientes.FirstOrDefaultAsync(x => x.Id == id);

            if (remove is not null)
            {
                _context.Pacientes.Remove(remove);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<Paciente> Create(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
            return paciente;
        }

        public async Task<Paciente> Update(Paciente paciente)
        {
            _context.Pacientes.Update(paciente);

            await _context.SaveChangesAsync();

            return paciente;
        }
    }
}
