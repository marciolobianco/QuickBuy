using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagemValidacao { get; set; }

        protected List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>); }
        }
        private void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validade();

        protected bool ehValido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
