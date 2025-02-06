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
    }
}
