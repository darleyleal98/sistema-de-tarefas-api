namespace SistemaDeTarefas.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        // ? -> Indica que poderá aceitar valores nulos
        public string? Nome { get; set; }
        public string? Email { get; set; }
    }
}
