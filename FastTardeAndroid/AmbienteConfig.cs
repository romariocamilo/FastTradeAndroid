using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class AmbienteConfig
    {
        public AppiumDriver<AndroidElement> Configuracao(string appPackage, string appActivity)
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            AppiumDriver<AndroidElement> driver;

            string deviceName = "H9AZB600Z372GYZ";
            string platformDesktop = "Windows";
            string platFormNameTest = "Android";
            string automationName = "Appium";

            capabilities.SetCapability("deviceName", deviceName);
            capabilities.SetCapability(CapabilityType.Platform, platformDesktop);
            capabilities.SetCapability("appPackage", appPackage);
            capabilities.SetCapability("appActivity", appActivity);
            capabilities.SetCapability("platFormName", platFormNameTest);
            capabilities.SetCapability("Appium", automationName);

            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(120));
            return driver;
        }
    }
}
