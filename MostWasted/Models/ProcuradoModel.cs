using System.ComponentModel.DataAnnotations;

namespace MostWanted.Models
{
    public class ProcuradoModel
    {
        [Key]
        public int ProcuradoId { get; set; }
        public string? NomeAgencia { get; set; }
        public string? NomeProcurado { get; set; }
        public string? FotoProcurado { get; set; }
        public string? DataNascimento { get; set; }
        public string? LugarNascimento { get; set; }
        public string? Nacionalidade { get; set; }
        public string? LinguaFalada { get; set; }
        public string? Idade { get; set; }
        public string? CorCabelo { get; set; }
        public string? CorOlhos { get; set; }
        public string? Sexo { get; set; }
        public string? Raca { get; set; }
        public string? DescricaoCorporal { get; set; }
        public string? DescricaoRosto { get; set; }
        public int Recompensa { get; set; }
        public string? Acusacao { get; set; }
    }
}
