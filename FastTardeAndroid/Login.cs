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
            driver = Configuracao("br.com.cedrotech.fastmobile", "br.com.cedrotech.fastmobile.splash.SplashActivity");
            espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/userNameEditText")]
        IWebElement campoLogin;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/passwordEditText")]
        IWebElement campoSenha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/loginButton")]
        IWebElement botaoLogin;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/skipFingerprint")]
        IWebElement botaoDigitalDepois;


        public void LoginCorreto()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(campoLogin));
            campoLogin.SendKeys("caiocosta");
            driver.HideKeyboard();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoSenha));
            campoSenha.SendKeys("102030");
            driver.HideKeyboard();

            espera.Until(ExpectedConditions.ElementToBeClickable(botaoLogin));
            botaoLogin.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(botaoDigitalDepois));
            botaoDigitalDepois.Click();

            //RESOLUÇÃO DO ANDERSON - CRIANDO PROPRIO SCROLL
            //driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().resourceId(android:id/content))"));
            //driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).flingToEnd(1)"));
        }
    }
}
