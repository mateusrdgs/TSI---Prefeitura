using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSI___Prefeitura.Helpers
{
    public class Debouncer
    {
        public event EventHandler debounceHandler = delegate { };
        public int tempoEsperaMilisegundos { get; set; }
        System.Threading.Timer tempoEspera;

        public Debouncer(int tempoEsperaMilissegundos = 800)
        {
            this.tempoEsperaMilisegundos = tempoEsperaMilissegundos;
            tempoEspera = new System.Threading.Timer(timer => debounceHandler(this, EventArgs.Empty));
        }

        public void TextChanged()
        {
            this.tempoEspera.Change(this.tempoEsperaMilisegundos, System.Threading.Timeout.Infinite);
        }
    }
}
