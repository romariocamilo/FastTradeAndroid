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
    class Listas : Login
    {
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[1]/android.widget.TextView")]
        IWebElement minhaLista1;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[2]/android.widget.TextView")]
        IWebElement minhaLista2;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[3]/android.widget.TextView")]
        IWebElement fixas;

        [FindsBy(How = How.Id, Using = "android:id/text1")]
        IWebElement menuFixa;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[1]")]
        IWebElement indiceBovespa;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[2]")]
        IWebElement cambio;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[3]")]
        IWebElement indicadores;

        [FindsBy(How = How.XPath, Using = "")]
        IWebElement ativoIndiceBovespa;


        public void SelecionandoLista()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(minhaLista1));
            minhaLista1.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(minhaLista2));
            minhaLista2.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(fixas));
            fixas.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(menuFixa));
            menuFixa.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(indiceBovespa));
            indiceBovespa.Click();

            menuFixa.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(cambio));
            cambio.Click();

            menuFixa.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(indicadores));
            indicadores.Click();

            menuFixa.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(bitcoin));
            bitcoin.Click();
        }

        public void ExibindoAtivoIndiceBovespa()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(fixas));
            fixas.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(menuFixa));
            menuFixa.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(indiceBovespa));
            indiceBovespa.Click();


        }
    }
}
