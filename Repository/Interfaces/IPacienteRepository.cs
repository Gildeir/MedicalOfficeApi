using MedicalOfficeApi.Model.Entities;

namespace MedicalOfficeApi.Repository.Interfaces
{
    public interface IPacienteRepository
    {
        Task<IEnumerable<Paciente>> Get(); 
        Task<Paciente?> GetById(int id); 
        Task<Paciente> Create(Paciente paciente); 
        Task<Paciente> Update(Paciente paciente); 
        Task<bool> Delete(int id); 
    }
}
