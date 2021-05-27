using System;
using System.Collections.Generic;
using System.Text;

namespace DatasAtrasExtenso
{
    public class DataPassadoExtenso
    {
        private DateTime dataInicial;
        private DateTime dataFinal;
        private TimeSpan diferencaDatas;
        private double diferencaDias;


        public DataPassadoExtenso(DateTime dataInicial, DateTime dataFinal)
        {
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.diferencaDatas = dataFinal - dataInicial;

            diferencaDias = diferencaDatas.TotalDays;
        }

        public string ConverterParaExtenso()
        {
            string dataExtenso = "";
            int diasInteiros = Convert.ToInt32(diferencaDias);

            dataExtenso += ConverteDias(diasInteiros);

            dataExtenso += "atrás";
            return dataExtenso;
        }

        private string ConverteDias(int diasInteiros)
        {
            string dataParaExtenso = "";
            int anosInteiros = diasInteiros / 365;
            diasInteiros %= 365;

            int mesesInteiros = diasInteiros / 30;
            diasInteiros %= 30;

            int semanasInteiras = diasInteiros / 7;
            diasInteiros %= 7;

            if (anosInteiros > 0)
            {
                if (anosInteiros > 9)
                    dataParaExtenso += ReceberDezenas(anosInteiros.ToString());
                else
                    dataParaExtenso += ReceberUnidades(anosInteiros.ToString());

                if (anosInteiros == 1)
                    dataParaExtenso += "ano ";
                else
                    dataParaExtenso += "anos ";
            }

            if (mesesInteiros > 0)
            {
                if (!string.IsNullOrEmpty(dataParaExtenso))
                    dataParaExtenso += "e ";

                dataParaExtenso += ReceberUnidades(mesesInteiros.ToString());
                if (mesesInteiros == 1)
                    dataParaExtenso += "mes ";
                else
                    dataParaExtenso += "meses ";
            }

            if (semanasInteiras > 0)
            {
                if (!string.IsNullOrEmpty(dataParaExtenso))
                    dataParaExtenso += "e ";

                if (semanasInteiras == 1)
                    dataParaExtenso += "uma semana ";
                else if (semanasInteiras == 2)
                    dataParaExtenso += "duas semanas ";
                else
                    dataParaExtenso += ReceberUnidades(semanasInteiras.ToString())+"semanas ";
            }

            if (diasInteiros > 0)
            {
                if (!string.IsNullOrEmpty(dataParaExtenso))
                    dataParaExtenso += "e ";

                dataParaExtenso += ReceberUnidades(diasInteiros.ToString());
                if (diasInteiros == 1)
                    dataParaExtenso += "dia ";
                else
                    dataParaExtenso += "dias ";
            }

            return dataParaExtenso;
        }

        private string ReceberUnidades(string numero)
        {
            switch (numero)
            {
                case "1":
                    return "um ";
                case "2":
                    return "dois ";
                case "3":
                    return "três ";
                case "4":
                    return "quatro ";
                case "5":
                    return "cinco ";
                case "6":
                    return "seis ";
                case "7":
                    return "sete ";
                case "8":
                    return "oito ";
                case "9":
                    return "nove ";
                default:
                    return "";
            }
        }

        private string ReceberDezenas(string numero)
        {
            switch (numero)
            {
                case "10":
                    return "dez ";
                case "11":
                    return "onze ";
                case "12":
                    return "doze ";
                case "13":
                    return "treze ";
                case "14":
                    return "catorze ";
                case "15":
                    return "quinze ";
                case "16":
                    return "dezesseis ";
                case "17":
                    return "dezessete ";
                case "18":
                    return "dezoito ";
                case "19":
                    return "dezenove ";
                case "20":
                    return "vinte ";
                case "30":
                    return "trinta ";
                case "40":
                    return "quarenta ";
                case "50":
                    return "cinquenta ";
                case "60":
                    return "sessenta ";
                case "70":
                    return "setenta ";
                case "80":
                    return "oitenta ";
                case "90":
                    return "noventa ";

                default:
                    if (double.Parse(numero) > 0)
                    {
                        return ReceberDezenas(numero.Substring(0, 1) + "0") + "e " + ReceberUnidades(numero.Substring(1));
                    }
                    return "";
            }
        }
    }
}
