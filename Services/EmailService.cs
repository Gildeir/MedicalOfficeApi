namespace MedicalOfficeApi.Services
{
    public class EmailService : IEmailService
    {
        public string EnviarEmail(string email)
        {
            string ok = "Email enviado com sucesso";

            return $"Mensagem: {email}, {ok}";
        }
    }
}
