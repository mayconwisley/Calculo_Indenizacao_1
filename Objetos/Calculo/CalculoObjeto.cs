using Objetos.Empregado;
using System;

namespace Objetos.Calculo
{
    public class CalculoObjeto
    {
        public int Id { get; set; }
        public string TipoCalculo { get; set; }
        public DateTime DataEstabilidade { get; set; }
        public int Dias { get; set; }
        public int MesEstabilidade { get; set; }
        public decimal ValorIndenizacao { get; set; }
        public decimal ValorDecimoTerceiro { get; set; }
        public decimal ValorFerias { get; set; }
        public decimal ValorTercoFerias { get; set; }
        public decimal FGTS8 { get; set; }
        public decimal FGTS40 { get; set; }
        public decimal ValorTotal { get; set; }
        public string Complemento { get; set; }
        public EmpregadoObjeto Empregado { get; set; }
    }
}
