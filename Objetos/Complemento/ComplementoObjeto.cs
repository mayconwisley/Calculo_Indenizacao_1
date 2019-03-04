using Objetos.Empregado;

namespace Objetos.Complemento
{
    public class ComplementoObjeto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Tipo { get; set; }
        public EmpregadoObjeto Empregado { get; set; }

    }
}
