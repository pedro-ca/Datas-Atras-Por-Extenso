using System;

namespace DatasAtrasExtenso
{
    public class DataPassadoExtenso
    {
        private DateTime dataInicial;
        private DateTime dataFinal;
        private TimeSpan diferencaDatas;
        private double diferencaDias;
        private double diferencaSegundos;


        public DataPassadoExtenso(DateTime dataInicial, DateTime dataFinal)
        {
            this.dataInicial = dataInicial;
            this.dataFinal = dataFinal;
            this.diferencaDatas = dataFinal - dataInicial;

            diferencaDias = diferencaDatas.TotalDays;
            diferencaSegundos = diferencaDatas.Seconds;     //deveria estar pegando horas, minutos e segundos juntos. atualmente pegando só segundos
        }

        public string ConverterParaExtenso()
        {
            string dataExtenso = "";

            int diasInteiros = Convert.ToInt32(diferencaDias);
            dataExtenso += ConverteDias(diasInteiros);

            if (diferencaDatas.Seconds > 0)
            {
                int segundosInteiros = Convert.ToInt32(diferencaDatas.Seconds);
                dataExtenso += ConverteDias(diasInteiros);
            }

            dataExtenso += "atrás";
            return dataExtenso;
        }

        private string ConverteDias(int diasInteiros)
        {
            string diasParaExtenso = "";
            int anosInteiros = diasInteiros / 365;
            diasInteiros %= 365;

            int mesesInteiros = diasInteiros / 30;
            diasInteiros %= 30;

            int semanasInteiras = diasInteiros / 7;
            diasInteiros %= 7;

            if (anosInteiros > 0)
            {
                if (anosInteiros > 9)
                    diasParaExtenso += ReceberDezenas(anosInteiros.ToString());
                else
                    diasParaExtenso += ReceberUnidades(anosInteiros.ToString());

                if (anosInteiros == 1)
                    diasParaExtenso += "ano ";
                else
                    diasParaExtenso += "anos ";
            }

            if (mesesInteiros > 0)
            {
                if (!string.IsNullOrEmpty(diasParaExtenso))
                    diasParaExtenso += "e ";

                diasParaExtenso += ReceberUnidades(mesesInteiros.ToString());
                if (mesesInteiros == 1)
                    diasParaExtenso += "mes ";
                else
                    diasParaExtenso += "meses ";
            }

            if (semanasInteiras > 0)
            {
                if (!string.IsNullOrEmpty(diasParaExtenso))
                    diasParaExtenso += "e ";

                if (semanasInteiras == 1)
                    diasParaExtenso += "uma semana ";
                else if (semanasInteiras == 2)
                    diasParaExtenso += "duas semanas ";
                else
                    diasParaExtenso += ReceberUnidades(semanasInteiras.ToString())+"semanas ";
            }

            if (diasInteiros > 0)
            {
                if (!string.IsNullOrEmpty(diasParaExtenso))
                    diasParaExtenso += "e ";

                diasParaExtenso += ReceberUnidades(diasInteiros.ToString());
                if (diasInteiros == 1)
                    diasParaExtenso += "dia ";
                else
                    diasParaExtenso += "dias ";
            }

            return diasParaExtenso;
        }

        public string ConverterSegundos(int segundosExtenso)
        {
            string dataParaExtenso = "";
            int horasExtenso = segundosExtenso / 60;
            segundosExtenso %= 60;

            int mintuosExtenso = segundosExtenso / 60;
            segundosExtenso %= 60;

            if (horasExtenso > 0)
            {
                if (horasExtenso > 9)
                    dataParaExtenso += ReceberDezenas(horasExtenso.ToString());
                else
                    dataParaExtenso += ReceberUnidades(horasExtenso.ToString());

                if (horasExtenso == 1)
                    dataParaExtenso += "hora ";
                else
                    dataParaExtenso += "horas ";
            }

            if (mintuosExtenso > 0)
            {
                if (!string.IsNullOrEmpty(dataParaExtenso))
                    dataParaExtenso += "e ";

                dataParaExtenso += ReceberUnidades(mintuosExtenso.ToString());
                if (mintuosExtenso == 1)
                    dataParaExtenso += "minutos ";
                else
                    dataParaExtenso += "minuto ";
            }

            if (segundosExtenso > 0)
            {
                if (!string.IsNullOrEmpty(dataParaExtenso))
                    dataParaExtenso += "e ";

                dataParaExtenso += ReceberUnidades(segundosExtenso.ToString());
                if (segundosExtenso == 1)
                    dataParaExtenso += "segundo ";
                else
                    dataParaExtenso += "segundo ";
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
