﻿namespace MedicalOfficeApi.Model.Entities
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataHorario { get; set; }
        public int Status { get; set; }
        public decimal Preco { get; set; }
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }
    }
}
