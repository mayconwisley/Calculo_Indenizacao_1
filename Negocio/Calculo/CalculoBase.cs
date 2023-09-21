using System;

namespace Negocio.Calculo
{
    public class CalculoBase
    {
        //Calculo valor da indenização sem as verbas adicionais
        public static decimal Indenizacao(decimal media, int diasBase, int diasEstabilidade)
        {
            decimal vlrIndenizacao = (media / diasBase) * diasEstabilidade;
            vlrIndenizacao = Math.Round(vlrIndenizacao, 2);
            return vlrIndenizacao;
        }
        //Calculo 13º Salario
        public static decimal DecimoTerceiro(decimal media, int diasEstabilidade)
        {
            decimal meses = diasEstabilidade / 30;
            decimal dias = diasEstabilidade - (Math.Floor(meses) * 30);

            if (dias >= 15)
            {
                return _ = Math.Round((media / 12) * (meses + 1), 2);
            }
            else
            {
                return _ = Math.Round((media / 12) * meses, 2);
            }
        }
        //Calculo Ferias
        public static decimal Ferias(decimal media, int diasEstabilidade)
        {
            decimal meses = diasEstabilidade / 30;
            decimal dias = diasEstabilidade - (Math.Floor(meses) * 30);

            if (dias >= 15)
            {
                return _ = Math.Round((media / 12) * (meses + 1), 2);
            }
            else
            {
                return _ = Math.Round((media / 12) * meses, 2);
            }
        }
        //Calculo de 1 terço sobre a ferias
        public static decimal TercoFerias(decimal valorFerias)
        {
            return _ = Math.Round(valorFerias / 3, 2);
        }
        //Calculo de 8% FGTS
        public static decimal FGTS8(decimal valorEstabilidade, decimal decimoTerceiro)
        {
            return _ = Math.Round((valorEstabilidade + decimoTerceiro) * 0.08M, 2);
        }
        //Calculo de 40% FGTS
        public static decimal FGTS40(decimal FGTS8)
        {
            return _ = Math.Round(FGTS8 * 0.40M, 2);
        }
        //Soma dos Valores a receber na indenização
        public static decimal Total(decimal indenizacao, decimal decimoTerceiro, decimal Ferias, decimal tercoFerias, decimal fgts8, decimal fgts40, decimal complemento)
        {
            return _ = Math.Round(indenizacao + decimoTerceiro + Ferias + tercoFerias + fgts8 + fgts40 + complemento, 2);
        }
    }
}
