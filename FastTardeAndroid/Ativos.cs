using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
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
    class Ativos : Login
    {
        #region Instânciando elementos das telas mobile
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

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.LinearLayout[3]/android.widget.RelativeLayout/android.widget.TextView")]
        IWebElement btnEditaPlanilha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/coach_mark_hand_button")]
        IWebElement btnOkEditarPlanilha;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.support.v4.view.ViewPager/android.widget.FrameLayout/android.widget.RelativeLayout/android.support.v7.widget.RecyclerView/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.LinearLayout")]
        IWebElement primeiroElementoDaListaDeAtivos;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.support.v4.view.ViewPager/android.widget.FrameLayout/android.widget.RelativeLayout/android.support.v7.widget.RecyclerView/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.LinearLayout[5]")]
        IWebElement destinoElementoUm;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[2]/android.widget.TextView")]
        IWebElement minhaLista2;

        #endregion


        public void AdicionaAtivo()
        {
            EscolheAtivo("IBOV");
            EscolheAtivo("IBXX");
            EscolheAtivo("IMOB");
            AdicionaAtivoLista2();
        }

        public void AdicionaAtivoRepetido()
        {
            EscolheAtivo("IBOV");
            EscolheAtivo("IBOV");

            espera.Until(ExpectedConditions.ElementToBeClickable(alertaAtivoRepetido));
            Thread.Sleep(3000);
            alertaAtivoRepetido.Click();
        }

        //public void RemoveAtivo()
        //{
        //    Actions nova = new Actions(driver);

        //    espera.Until(ExpectedConditions.ElementToBeClickable(subMenuAtivo));
        //    subMenuAtivo.Click();

        //    espera.Until(ExpectedConditions.ElementToBeClickable(btnEditaPlanilha));
        //    btnEditaPlanilha.Click();

        //    espera.Until(ExpectedConditions.ElementToBeClickable(btnOkEditarPlanilha));
        //    btnOkEditarPlanilha.Click();
        //    espera.Until(ExpectedConditions.ElementToBeClickable(btnOkEditarPlanilha));
        //    btnOkEditarPlanilha.Click();
        //    espera.Until(ExpectedConditions.ElementToBeClickable(btnOkEditarPlanilha));
        //    btnOkEditarPlanilha.Click();
        //    espera.Until(ExpectedConditions.ElementToBeClickable(btnOkEditarPlanilha));
        //    btnOkEditarPlanilha.Click();
        //    espera.Until(ExpectedConditions.ElementToBeClickable(btnOkEditarPlanilha));
        //    btnOkEditarPlanilha.Click();
        //}

        public void EscolheAtivo(string ativo)
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(subMenuAtivo));
            subMenuAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(opcaoAdicionaAtivo));
            opcaoAdicionaAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoTextoAtivo));
            campoTextoAtivo.SendKeys(ativo);
            botaoAdicionaAtivo.Click();
        }

        public void AdicionaAtivoLista2()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(minhaLista2));
            minhaLista2.Click();
            EscolheAtivo("VULC3");
            EscolheAtivo("IBRA");
            EscolheAtivo("IMAT");
            EscolheAtivo("BITCOIN");
        }
    }
}
