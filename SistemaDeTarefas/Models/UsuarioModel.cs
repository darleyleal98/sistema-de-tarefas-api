namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; } // ? -> Indica que poderá aceitar valores nulos
        public string? Email { get; set; }
    }
}
