using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    //abstract - quer dizer que a classe não será instanciada
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> MensagensValidacao { get => _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        protected void LimparMensagemValidacao() => MensagensValidacao.Clear();
        protected void AdicionarCritica(string mensagem)
        {
            MensagensValidacao.Add(mensagem);
        }

        public abstract void Validate();
        /// <summary>
        /// Se não tiver nenhuma mensagem de validação.
        /// </summary>
        protected bool EhValido { get => !MensagensValidacao.Any(); }
    }
}
