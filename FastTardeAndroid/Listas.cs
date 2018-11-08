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
        IWebElement opcoesFixas;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[1]")]
        IWebElement indiceBovespa;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[2]")]
        IWebElement cambio;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[3]")]
        IWebElement indicadores;

        [FindsBy(How = How.XPath, Using = "hierarchy/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.ListView/android.widget.CheckedTextView[4]")]
        IWebElement bitcoin;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.support.v4.view.ViewPager/android.widget.FrameLayout/android.widget.RelativeLayout/android.support.v7.widget.RecyclerView/android.widget.LinearLayout[2]/android.widget.FrameLayout/android.widget.LinearLayout")]
        IWebElement elementoPosicaoX;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/fragment_chart_button_line")]
        IWebElement linha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/fragment_chart_button_candle")]
        IWebElement candle;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/fragment_chart_button_interday")]
        IWebElement seisMeses;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/fragment_chart_button_intraday")]
        IWebElement diaCorrente;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[2]")]
        IWebElement outrasInformacoes;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.RelativeLayout/android.widget.ScrollView/android.widget.LinearLayout/android.widget.LinearLayout[2]/android.widget.LinearLayout/android.widget.HorizontalScrollView/android.widget.LinearLayout/android.support.v7.app.ActionBar.Tab[1]")]
        IWebElement graficos;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/fragment_chart_button_zoom")]
        IWebElement lupa;

        [FindsBy(How = How.Id, Using = "   br.com.cedrotech.fastmobile:id/activity_chart_details_name")]
        IWebElement btnFechaLupa;

        [FindsBy(How = How.Id, Using = "Navegar para cima")]
        IWebElement btnVoltar;


     

        public void SelecionandoLista()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(minhaLista1));
            minhaLista1.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(minhaLista2));
            minhaLista2.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(fixas));
            fixas.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(opcoesFixas));
            opcoesFixas.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(indiceBovespa));
            indiceBovespa.Click();

            opcoesFixas.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(cambio));
            cambio.Click();

            opcoesFixas.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(indicadores));
            indicadores.Click();

            opcoesFixas.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(bitcoin));
            bitcoin.Click();
        }

        public void ExibindoAtivoIndiceBovespa()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(fixas));
            fixas.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(opcoesFixas));
            opcoesFixas.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(indiceBovespa));
            indiceBovespa.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(elementoPosicaoX));
            elementoPosicaoX.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(candle));
            candle.Click();
            linha.Click();
            seisMeses.Click();
            diaCorrente.Click();
            outrasInformacoes.Click();
            graficos.Click();
            lupa.Click();
            btnFechaLupa.Click();
            btnVoltar.Click();


        }
    }
}
