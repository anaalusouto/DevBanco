using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Conta
{
    public class ContaCriacaoDto
    {
        public string Numero { get; set; } //String por causa do zero à direita
        public string Agencia { get; set; }
        public float Saldo { get; set; }
        public string Condicao { get; set; }
        public bool Status { get; set; } = true;
    }

}
