using System;

namespace Objetos.Empregado
{
    public class EmpregadoObjeto
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public DateTime Admissao { get; set; }
        public DateTime Demissao { get; set; }
        public decimal Media { get; set; }
        public int Base { get; set; }

    }
}
