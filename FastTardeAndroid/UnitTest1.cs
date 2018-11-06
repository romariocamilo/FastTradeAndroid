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
        public void LoginLogofComCorretora()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Login logins = new Login();
            logins.SuiteLoginLogof();
        }

        [TestMethod]
        public void AdicionaAtivos()
        {
            //Aqui ocorre a inserção de ativos tanto na lista 1 quando na lista 2
            Ativos ativos = new Ativos();
            ativos.LoginFluxoCompleto();
            ativos.AdicionaAtivo();
            ativos.Logof();
        }

        [TestMethod]
        public void AdicionaAtivoRepetido()
        {
            Ativos ativos = new Ativos();
            ativos.LoginFluxoCompleto();
            ativos.AdicionaAtivoRepetido();
            ativos.Logof();
        }

        [TestMethod]
        public void SelecionandoLista()
        {
            Listas listas = new Listas();
            listas.LoginFluxoCompleto();
            listas.SelecionandoLista();
            listas.Logof();
        }
    }
}
