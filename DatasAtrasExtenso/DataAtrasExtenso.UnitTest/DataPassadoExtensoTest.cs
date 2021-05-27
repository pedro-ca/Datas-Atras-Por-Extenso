using NUnit.Framework;
using DatasAtrasExtenso;
using System;

namespace DataAtrasExtenso.UnitTest
{
    public class Tests
    {
        [TestCase]
        public void Deve_RetornarExtenso_UmDiaAtras()
        {
            DateTime dataInicial = new DateTime(2021,05,25);    // 25/05/2021
            DateTime dataFinal = new DateTime(2021,05,26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "um dia atrás";

            Assert.AreEqual(respostaEsperada,respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_DoisDiasAtras()
        {
            DateTime dataInicial = new DateTime(2021, 05, 24);    // 24/05/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "dois dias atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_UmaSemanaAtras()
        {
            DateTime dataInicial = new DateTime(2021, 05, 19);    // 19/05/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "uma semana atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_DuasSemanasAtras()
        {
            DateTime dataInicial = new DateTime(2021, 05, 12);    // 12/05/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "duas semanas atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_DuasSemanasUmDiaAtras()
        {
            DateTime dataInicial = new DateTime(2021, 05, 11);    // 19/05/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "duas semanas e um dia atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_DoisMesesDoisDiasAtras()
        {
            DateTime dataInicial = new DateTime(2021, 04, 24);    //24/04/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "um mes e dois dias atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_DoisMesesUmaSemanaAtras()
        {
            DateTime dataInicial = new DateTime(2021, 03, 19);    // 19/04/2021
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "dois meses e uma semana atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_UmAnoAtras()
        {
            DateTime dataInicial = new DateTime(2020, 05, 26);    //26/05/2020
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "um ano atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_UmAnoUmDiaAtras()
        {
            DateTime dataInicial = new DateTime(2020, 05, 25);    //26/05/2020
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "um ano e um dia atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_UmAnoUmaSemanaAtras()
        {
            DateTime dataInicial = new DateTime(2020, 05, 19);    //19/05/2011
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "um ano e uma semana atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_UmAnoDoisMesesDoisDiasAtras()
        {
            DateTime dataInicial = new DateTime(2020, 03, 24);    //24/04/2020
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "um ano e dois meses e três dias atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }

        [TestCase]
        public void Deve_RetornarExtenso_DezAnosAtras()
        {
            DateTime dataInicial = new DateTime(2011, 05, 26);    //26/05/2011
            DateTime dataFinal = new DateTime(2021, 05, 26);

            DataPassadoExtenso dataExtenso = new DataPassadoExtenso(dataInicial, dataFinal);

            string respostaAtual = dataExtenso.ConverterParaExtenso();
            string respostaEsperada = "dez anos atrás";

            Assert.AreEqual(respostaEsperada, respostaAtual);
        }
    }
}