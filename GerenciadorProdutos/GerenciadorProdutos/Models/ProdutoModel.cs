using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace GerenciadorProdutos.Models
{
    public class ProdutoModel
    {
        public Int64 Id { get; set; }
        [Required]
        public string CodigoDeBarras { get; set; }
        [Required]
        public string Descricao { get; set;}
        public DateTime DataDeValidade { get; set; }
        public DateTime DataDeRegistro { get; set; }
        public int Quantidade { get; set; }
        public decimal? Valor { get; set; }
        [MaybeNull]
        public string NomeDaFoto { get; set; }
        [MaybeNull]
        public byte[] Foto { get; set; }

        public bool Ativo { get; set; }




    }
}
