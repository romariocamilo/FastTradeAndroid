using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class Ativos : Login
    {
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/active_item_header_button")]
        IWebElement subMenuAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/title")]
        IWebElement opcaoAdicionaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/dialog_add_active_autoCompleteTextView")]
        IWebElement campoTextoAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/dialog_add_active_button")]
        IWebElement botaoAdicionaAtivo;

        [FindsBy(How = How.Id, Using = "android:id/button1")]
        IWebElement alertaAtivoRepetido;
        

        public void AdicionaAtivo()
        {
            EscolheAtivo("IBOV");
            EscolheAtivo("IBXX");
            EscolheAtivo("IMOB");
        }

        public void EscolheAtivo(string ativo)
        {
            bool validacao = false;

            espera.Until(ExpectedConditions.ElementToBeClickable(subMenuAtivo));
            subMenuAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(opcaoAdicionaAtivo));
            opcaoAdicionaAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoTextoAtivo));
            campoTextoAtivo.SendKeys(ativo);
            botaoAdicionaAtivo.Click();

            //try
            //{
            //    espera.Until(ExpectedConditions.ElementIsVisible(By.Id("android:id/button1")));
            //    validacao = true;
            //}
            //catch
            //{
            //    validacao = false;
            //}

            //if (validacao)
            //{
            //    alertaAtivoRepetido.Click();
            //}
        }
    }
}
