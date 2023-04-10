using System.ComponentModel.DataAnnotations;

namespace Greenployee.Model
{
    public class OrdemServico:BaseClass
    {
        [StringLength(15)]
        public string nrOrdem { get; set; } = string.Empty;
        [StringLength(60)]
        public string nmCliente { get; set; } = string.Empty;
        [StringLength(20)]
        public string nrTelefone { get; set;} = string.Empty;
        [StringLength(15)]
        public string flSituacao { get; set; } = string.Empty;
        [StringLength(15)]
        public string dsFormaPagamento { get; set; } = string.Empty;
        [StringLength(100)]
        public string dsEndereco { get; set; } = string.Empty;
        public bool flEntrega { get; set; }
        public DateTime dtOrdem { get; set; }
        public int idFuncionario { get; set; }

        // Necessário criar um objeto do tipo da chave estrangeira
        //public Pessoa? Funcionario { get; set; }



    }
}
