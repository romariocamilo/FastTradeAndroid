using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
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
        public AppiumDriver<AndroidElement> Configuracao()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            AppiumDriver<AndroidElement> driver;

            string deviceName = "deviceName";
            string platformDesktop = "Windows";
            string appPackage = "br.com.cedrotech.fastmobile";
            string appActivity = "br.com.cedrotech.fastmobile.account.login.LoginActivity";
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
