using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace FastTradeAndroid
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void LoginCorreto()
        //{
        //    Login logins = new Login();
        //    logins.SuiteLoginLogof();
        //}

        [TestMethod]
        public void AdicionaAtivos()
        {
            Ativos ativos = new Ativos();
            ativos.LoginFluxoCompleto();
            ativos.RemoveAtivo();
            //ativos.Logof();
        }
    }
}
