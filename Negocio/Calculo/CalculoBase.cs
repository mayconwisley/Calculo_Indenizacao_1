using System;

namespace Negocio.Calculo
{
    public class CalculoBase
    {
        //Calculo valor da indenização sem as verbas adicionais
        public static decimal Indenizacao(decimal media, int diasBase, int diasEstabilidade)
        {
            decimal vlrIndenizacao = media / diasBase * diasEstabilidade;
            return vlrIndenizacao;
        }
        //Calculo 13º Salario
        public static decimal DecimoTerceiro(decimal media, int diasEstabilidade)
        {
            decimal meses = diasEstabilidade / 30;
            decimal dias = diasEstabilidade - (Math.Floor(meses) * 30);

            if (dias >= 15)
            {
                return _ = (media / 12) * (meses + 1);
            }
            else
            {
                return _ = (media / 12) * meses;
            }
        }
        //Calculo Ferias
        public static decimal Ferias(decimal media, int diasEstabilidade)
        {
            decimal meses = diasEstabilidade / 30;
            decimal dias = diasEstabilidade - (Math.Floor(meses) * 30);

            if (dias >= 15)
            {
                return _ = (media / 12) * (meses + 1);
            }
            else
            {
                return _ = (media / 12) * meses;
            }
        }
        //Calculo de 1 terço sobre a ferias
        public static decimal TercoFerias(decimal valorFerias)
        {
            return _ = valorFerias / 3;
        }
        //Calculo de 8% FGTS
        public static decimal FGTS8(decimal valorEstabilidade, decimal decimoTerceiro)
        {
            return _ = (valorEstabilidade + decimoTerceiro) * 0.08M;
        }
        //Calculo de 40% FGTS
        public static decimal FGTS40(decimal FGTS8)
        {
            return _ = FGTS8 * 0.40M;
        }
        //Soma dos Valores a receber na indenização
        public static decimal Total(decimal indenizacao, decimal decimoTerceiro, decimal Ferias, decimal tercoFerias, decimal fgts8, decimal fgts40, decimal complemento)
        {
            return _ = indenizacao + decimoTerceiro + Ferias + tercoFerias + fgts8 + fgts40 + complemento;
        }
    }
}
