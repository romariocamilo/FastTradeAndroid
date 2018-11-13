using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace FastTradeAndroid
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FluxoLogin()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Login oLogin = new Login();
            oLogin.LoginCorreto();
        }

        [TestMethod]
        public void FluxoPesquisaRapidoAtivo()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            PesquisaAtivo oAtivo = new PesquisaAtivo();
            oAtivo.FluxoPesquisaRapidoAtivo();
        }

        [TestMethod]
        public void FluxoVisualizaSaldo()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Carteira oCarteira = new Carteira();
            oCarteira.VisualizaSaldo();
        }

        [TestMethod]
        public void FluxoInserirNovaLista()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.FluxoInserirNovaLista();
        }
    }
}
