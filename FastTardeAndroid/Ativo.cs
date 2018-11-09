using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
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
        IWebElement iconePesquisaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/autocompleteAsset")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup")]
        IWebElement framePrincipal;




        public void PesquisaAtivo()
        {
            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(iconePesquisaAtivo));
            iconePesquisaAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys("PETRH165");
            campoPesquisaAtivo.SendKeys(Keys.Down);
            campoPesquisaAtivo.Click();


        }
    }
}
