using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuario pode ter um ou nenhum pedido
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagemValidacao();

            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Crítica - Email não foi informado!");

            if (string.IsNullOrEmpty(Senha))
                AdicionarCritica("Crítica - Senha não foi informada!");
        }
    }
}
