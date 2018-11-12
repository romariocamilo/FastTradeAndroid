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
        public void Login()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Login oLogin = new Login();
            oLogin.LoginCorreto();
        }

        [TestMethod]
        public void BuscaAtivo()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Ativo oAtivo = new Ativo();
            oAtivo.PesquisaAtivo();
        }

        [TestMethod]
        public void VisualizarSaldo()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Carteira oCarteira = new Carteira();
            oCarteira.VisualizaSaldo();
        }
    }
}
