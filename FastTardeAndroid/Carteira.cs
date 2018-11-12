using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class Carteira : Login
    {
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/navigationWallet")]
        IWebElement menuCarteira;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/toggleVision")]
        IWebElement btnVisualizarSaldo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/itemWalletBovespa")]
        IWebElement scrollAtivos;

        

        public void VisualizaSaldo()
        {
            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(menuCarteira));
            menuCarteira.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnVisualizarSaldo));
            btnVisualizarSaldo.Click();
        }

        //Metodo Anderson, testar quando serviço voltar
        //public void DragAndDrop(IWebElement elemento, int posicaoX = 0, int posicaoY = 0)
        //{
        //    actions.ClickAndHold(elemento)
        //           .MoveToElement(elemento, posicaoX, posicaoY)
        //           .Release()
        //           .Build()
        //           .Perform();
        //}
    }
}
