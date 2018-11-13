using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.Enums;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class PesquisaAtivo : Login
    {
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/searchMenu")]
        IWebElement iconePesquisaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/autocompleteAsset")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup")]
        IWebElement frame;

        public void FluxoPesquisaRapidoAtivo()
        {
            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(iconePesquisaAtivo));
            iconePesquisaAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys("PETR4");
            Thread.Sleep(2000);

            TouchAction acaoClique = new TouchAction(driver);
            acaoClique.Tap(445, 474).Perform();

            #region OPÇÕES ANDERSON
            //driver.Keyboard.PressKey("VALE3");
            //driver.Keyboard.PressKey(Keys.Down);

            //Actions act = new Actions(driver);
            //act.SendKeys("VALE3").KeyDown(Keys.Enter).Perform();

            //    elemento = WebDriverWait(chromeDriver, 10).until(ec.element_to_be_clickable((By.XPATH, '//*[@id="fieldFluxoAprovacao"]/div[1]/div[1]/div/div/div/input')))
            //elemento.send_keys(nome, Keys.ARROWDOWN, Keys.TAB)

            //Dictionary<String, Object> pars = new Dictionary<String, Object>();
            //pars.Add("keySequence", "DOWN");
            //driver.ExecuteScript("mobile:presskey", pars);

            #endregion

        }
    }
}
