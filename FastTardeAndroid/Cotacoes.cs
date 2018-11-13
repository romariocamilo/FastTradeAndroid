using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class Cotacoes : Login
    {
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/arrowIcon")]
        IWebElement btnExpandirListas;

        public void FluxoInserirNovaLista()
        {
            LoginCorreto();
            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();
        }
    }
}
