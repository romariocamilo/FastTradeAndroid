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
    class Ativo : Login
    {
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/searchMenu")]
        IWebElement pesquisaAtivo;

        public void PesquisaAtivo()
        {
            LoginCorreto();
            espera.Until(ExpectedConditions.ElementToBeClickable(pesquisaAtivo));
            pesquisaAtivo.Click();
        }
    }
}
