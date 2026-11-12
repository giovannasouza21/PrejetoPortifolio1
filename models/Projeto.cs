using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace PrejetoPortifolio1.models
{
    public class Projeto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tecnologias { get; set; }
        public string LinkdeAcesso { get; set; }
        public string LinkdeVideo { get; set; }
        public string Imagem { get; set; }
        public int AlunoId { get; set; }
    }
}
