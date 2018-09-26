namespace TodoApi.Models
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco[] Enderecos { get; set; } 
    }
}
