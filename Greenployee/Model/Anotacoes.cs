using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Greenployee.Model
{
    public class Anotacoes:BaseClass
    {
        public DateTime dtAnotacao { get; set; }
        public DateTime dsMensagem { get; set; }

        [ForeignKey("Pessoa")]
        public int idPessoa { get; set; }   

    }
}
