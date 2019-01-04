using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
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
            driver = Configuracao("br.com.cedrotech.fastmobile.dev", "br.com.cedrotech.fastmobile.splash.SplashActivity");
            espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/userNameEditText")]
        IWebElement campoLogin;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/passwordEditText")]
        IWebElement campoSenha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/loginButton")]
        IWebElement botaoLogin;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/skipFingerprint")]
        IWebElement botaoDigitalDepois;


        public void LoginCorreto()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(campoLogin));
            campoLogin.SendKeys("romariosouza");
            driver.HideKeyboard();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoSenha));
            campoSenha.SendKeys("102030");
            driver.HideKeyboard();

            espera.Until(ExpectedConditions.ElementToBeClickable(botaoLogin));
            botaoLogin.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(botaoDigitalDepois));
            botaoDigitalDepois.Click();
        }

        public void LoginIncorreto()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(campoLogin));
            campoLogin.SendKeys("usuarioincorreto");
            driver.HideKeyboard();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoSenha));
            campoSenha.SendKeys("102030");
            driver.HideKeyboard();

            espera.Until(ExpectedConditions.ElementToBeClickable(botaoLogin));
            botaoLogin.Click();
        }
    }
}
