using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class Menu
    {
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/changeEmailMenu")]
        public IWebElement btnAlterarEmail { private set; get; }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/changePassMenu")]
        public IWebElement btnAlterarSenha { private set; get; }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/sendFeedbackMenu ")]
        public IWebElement btnEnviarFeedBack { private set; get; }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/changeThemeMenu")]
        public IWebElement btnTemaEscuro { private set; get; }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/exitMenu")]
        public IWebElement btnSair { private set; get; }

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/themeSwith")]
        public IWebElement btnTema { private set; get; }
    }
}
