using OpenQA.Selenium;
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
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/searchMenu")]
        IWebElement iconePesquisaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/autocompleteAsset")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/lineChartOption")]
        IWebElement btnGraficoLinha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/candleChartOption")]
        IWebElement btnGraficoColuna;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/oneDay")]
        IWebElement btnUmDia;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/fifteenDays")]
        IWebElement btnQuinzeDias;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/sixMonths")]
        IWebElement btnSeisMeses;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/oneYear")]
        IWebElement btnUmAno;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/close")]
        IWebElement btnFechar;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/cancelQuery")]
        IWebElement btnCancelar;


        public void FluxoPesquisaRapidoAtivo(string ativo)
        {
            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(iconePesquisaAtivo));
            iconePesquisaAtivo.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys(ativo);

            Thread.Sleep(2000);

            TouchAction acaoClique = new TouchAction(driver);
            acaoClique.Tap(445, 474).Perform();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
            btnQuinzeDias.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
            btnSeisMeses.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
            btnUmAno.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnGraficoColuna));
            btnGraficoColuna.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
            btnUmDia.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
            btnQuinzeDias.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
            btnSeisMeses.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
            btnUmAno.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnFechar));
            btnFechar.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnCancelar));
            btnCancelar.Click();

            #region OPÇÕES ANDERSON

            //Dictionary<String, int> keycode = new Dictionary<String, int>();
            //keycode.Add("keycode", Keys.PageDown);
            //((IJavaScriptExecutor)driver).ExecuteScript("mobile: keyevent", keycode);

            //driver.Keyboard.PressKey("VALE3");
            //driver.Keyboard.PressKey(Keys.Down);

            //Actions act = new Actions(driver);
            //act.SendKeys("VALE3").KeyDown(Keys.Enter).Perform();

            //    elemento = WebDriverWait(chromeDriver, 10).until(ec.element_to_be_clickable((By.XPATH, '//*[@id="fieldFluxoAprovacao"]/div[1]/div[1]/div/div/div/input')))
            //elemento.send_keys(nome, Keys.ARROWDOWN, Keys.TAB)

            //Dictionary<String, Object> pars = new Dictionary<String, Object>();
            //pars.Add("keySequence", "DOWN");
            //driver.ExecuteScript("mobile:presskey", pars);

            // var list1 = driver.FindElementsByClassName("android.view.ViewGroup");
            // var list = driver.FindElementsByClassName("android.widget.android.widget.EditText");
            //foreach (var item in list)
            //{
            //  var x =  item.Text;

            //}

            #endregion

        }
    }
}
