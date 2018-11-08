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
            driver = Configuracao();
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
            //espera.Until(ExpectedConditions.ElementToBeClickable(botaoDigitalDepois));

            Actions c = new Actions(driver);

            //Thread.Sleep(2000);

            driver.FindElement(By.Id("android:id/content")).SendKeys(Keys.Down);
            driver.FindElement(By.Id("android:id/content")).SendKeys(Keys.PageDown);
            driver.FindElement(By.Id("android:id/content")).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.Id("android:id/content")).SendKeys(Keys.PageDown);            
            c.ClickAndHold(driver.FindElement(By.Id("br.com.cedrotech.fastmobile:id/layoutConstraintUser"))).MoveByOffset(1,500);


            //driver.FindElement(By.Id("br.com.cedrotech.fastmobile:id/elipse")).SendKeys(Keys.Down);

            //Actions c = new Actions(driver);

            //////c.ClickAndHold(simboloDigital).MoveByOffset(0, -500).Build().Perform();
            //c.ClickAndHold().MoveByOffset(0, -300).Release().Perform();
            ////Generic function for Scroll
            ////TouchAction actions = new TouchAction(driver);
            ////actions.Press(botaoDigitalDepois).Wait(5000).MoveTo().Release().Perform();
        }
    }
}
