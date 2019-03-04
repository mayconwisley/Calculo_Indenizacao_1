using System;

namespace Negocio.Calculo
{
    public class CalculoBase
    {
        //Calculo valor da indenização sem as verbas adicionais
        public static decimal Indenizacao(decimal media, int diasBase, int diasEstabilidade)
        {
            decimal vlrIndenizacao = 0;
            vlrIndenizacao = (media / diasBase) * diasEstabilidade;
            return vlrIndenizacao;
        }
        //Calculo 13º Salario
        public static decimal DecimoTerceiro(decimal media, int diasBase, int diasEstabilidade)
        {
            try
            {
                decimal vlrDecimoTerceiro;
                decimal meses = diasEstabilidade / 30;
                decimal dias = diasEstabilidade - (Math.Floor(meses) * 30);

                if (dias >= 15)
                {
                    return vlrDecimoTerceiro = (media / 12) * (meses + 1);
                }
                else
                {
                    return vlrDecimoTerceiro = (media / 12) * meses;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Calculo Ferias
        public static decimal Ferias(decimal media, int diasBase, int diasEstabilidade)
        {
            try
            {
                decimal vlrFerias;
                decimal meses = diasEstabilidade / 30;
                decimal dias = diasEstabilidade - (Math.Floor(meses) * 30);

                if (dias >= 15)
                {
                    return vlrFerias = (media / 12) * (meses + 1);
                }
                else
                {
                    return vlrFerias = (media / 12) * meses;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Calculo de 1 terço sobre a ferias
        public static decimal TercoFerias(decimal valorFerias)
        {
            try
            {
                decimal vlrFeriasTerco;
                return vlrFeriasTerco = valorFerias / 3;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        //Calculo de 8% FGTS
        public static decimal FGTS8(decimal valorEstabilidade, decimal decimoTerceiro)
        {
            try
            {
                decimal vlrFGTS8;
                return vlrFGTS8 = (valorEstabilidade + decimoTerceiro) * 0.08M;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Calculo de 40% FGTS
        public static decimal FGTS40(decimal FGTS8)
        {
            try
            {
                decimal vlrFGTS40;
                return vlrFGTS40 = FGTS8 * 0.40M;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //Soma dos Valores a receber na indenização
        public static decimal Total(decimal indenizacao, decimal decimoTerceiro, decimal Ferias, decimal tercoFerias, decimal fgts8, decimal fgts40, decimal complemento)
        {
            decimal vlrTotal;
            return vlrTotal = indenizacao + decimoTerceiro + Ferias + tercoFerias + fgts8 + fgts40 + complemento;
        }
    }
}
