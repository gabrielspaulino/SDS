using System;
using System.Collections.Generic;
using System.Text;

namespace TP13
{
    public class Voo
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public string Horario { get; set; }
        public string Compania { get; set; }
        public string Operando { get; set; }

        public Voo() { }

        public Voo(string origem, string destino, string horario, string compania, string operando)
        {
            this.Origem = origem;
            this.Destino = destino;
            this.Horario = horario;
            this.Compania = compania;
            this.Operando = operando;
        }
    }
}
