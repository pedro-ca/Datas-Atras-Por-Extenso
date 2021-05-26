using NUnit.Framework;
using DatasAtrasExtenso;
using System;

namespace DataAtrasExtenso.UnitTest
{
    public class Tests
    {
        [TestCase]
        public void Test1()
        {
            DateTime dataInicial = new DateTime(2021,05,25);    // 25/05/2021
            DateTime dataFinal = new DateTime(2021,05,26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "um dia atrás";
            Assert.AreEqual(respostaAtual, respostaEsperada);
        }

        [TestCase]
        public void Test2()
        {
            DateTime dataInicial = new DateTime(2021, 05, 24);    // 24/05/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "dois dia atrás";
            Assert.AreEqual(respostaAtual, respostaEsperada);
        }

        [TestCase]
        public void Test3()
        {
            DateTime dataInicial = new DateTime(2021, 05, 19);    // 19/05/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "uma semanas atrás";
            Assert.AreEqual(respostaAtual, respostaEsperada);
        }

        [TestCase]
        public void Test4()
        {
            DateTime dataInicial = new DateTime(2021, 04, 19);    // 19/04/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "dois meses e uma semana atrás";
            Assert.AreEqual(respostaAtual, respostaEsperada);
        }

        [TestCase]
        public void Test5()
        {
            DateTime dataInicial = new DateTime(2021, 05, 25);    //24/04/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "dois meses e dois dias atrás";

            Assert.AreEqual(respostaAtual, respostaEsperada);
        }

        [TestCase]
        public void Test6()
        {
            DateTime dataInicial = new DateTime(2011, 05, 25);    //25/05/2011
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "dez anos atrás";

            Assert.AreEqual(respostaAtual, respostaEsperada);
        }
    }
}