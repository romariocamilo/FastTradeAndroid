using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
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
    class Login : AmbienteConfig
    {
        public AppiumDriver<AndroidElement> driver { protected get; set; }
        public WebDriverWait espera { protected get; set; } 

        public Login()
        {
            driver = Configuracao();
            espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/onboarding_market_button")]
        IWebElement tipoLogin;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/login_login_autoCompleteTextView")]
        IWebElement campoLogin;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/login_password_editText")]
        IWebElement campoSenha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/login_signIn_button")]
        IWebElement botaoLogin;

        [FindsBy(How = How.Id, Using = "android:id/button1")]
        IWebElement alertaAcessoInvalido;

        [FindsBy(How = How.ClassName, Using = "android.widget.ImageButton")]
        IWebElement menuFast;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/menu_logout")]
        IWebElement botaoSair;

        public void SuiteLoginLogof()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(tipoLogin));
            tipoLogin.Click();

            LoginIncorreto();
            LoginCorreto();
            Logof();
        }

        public void LoginIncorreto()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(campoLogin));
            campoLogin.SendKeys("usuarioinvalido");
            campoSenha.SendKeys("senhainvalida");
            botaoLogin.Click();
            espera.Until(ExpectedConditions.ElementToBeClickable(alertaAcessoInvalido));
            Thread.Sleep(2000);
            alertaAcessoInvalido.Click();
        }

        public void LoginCorreto()
        {
            campoLogin.SendKeys("caiocosta");
            campoSenha.SendKeys("102030");
            botaoLogin.Click();
            Thread.Sleep(3000);
        }

        public void Logof()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(menuFast));
            menuFast.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(botaoSair));
            botaoSair.Click();
            driver.CloseApp();
        }

        public void LoginFluxoCompleto()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(tipoLogin));
            tipoLogin.Click();

            campoLogin.SendKeys("caiocosta");
            campoSenha.SendKeys("102030");
            botaoLogin.Click();
        }
    }
}
