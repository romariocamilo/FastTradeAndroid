﻿using OpenQA.Selenium;
using OpenQA.Selenium.Appium.MultiTouch;
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
    class ConsultaRapida : Login
    {
        #region Elementos da busca rápida de ativos"
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/searchMenu")]
        IWebElement iconePesquisaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/autocompleteAsset")]
        IWebElement campoPesquisaAtivo;
       
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/close")]
        IWebElement btnFechar;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/cancelQuery")]
        IWebElement btnCancelar;
        #endregion

        public void ConsultaRapidoAtivo(string nomeDoAtivo, string nomeDoAtivo2)
        {
            TouchAction acaoClique = new TouchAction(driver);

            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(iconePesquisaAtivo));
            iconePesquisaAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys(nomeDoAtivo);

            Thread.Sleep(2000);

            acaoClique.Tap(445, 474).Perform();

            Thread.Sleep(4000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnFechar));
            btnFechar.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys(nomeDoAtivo2);

            Thread.Sleep(2000);

            acaoClique = new TouchAction(driver);
            acaoClique.Tap(445, 474).Perform();

            Thread.Sleep(4000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnFechar));
            btnFechar.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnCancelar));
            btnCancelar.Click();
        }
    }
}
