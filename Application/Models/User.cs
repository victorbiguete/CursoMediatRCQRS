namespace CursoMediatRCQRS.Application.Models
{
    public class User
    {
        public Guid Id { get; init; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
    }
}
