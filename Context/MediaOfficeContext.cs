using MedicalOfficeApi.Configuration;
using MedicalOfficeApi.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalOfficeApi.Context
{
    public class MediaOfficeContext : DbContext
    {
        public MediaOfficeContext(DbContextOptions<MediaOfficeContext> options) : base (options)
        {
        }
        DbSet<AgendamentoModel> Agendamentos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Profissional> Profissionais { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Consulta>(new ConsultaConfiguration());
            modelBuilder.ApplyConfiguration<Especialidade>(new EspecialidadeConfiguration());
            modelBuilder.ApplyConfiguration<Paciente>(new PacienteConfiguration());
            modelBuilder.ApplyConfiguration<Profissional>(new ProfissionalConfiguration());
        }
    }
}
