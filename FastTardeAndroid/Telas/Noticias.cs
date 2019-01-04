using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastTradeAndroid.Telas
{
    class Noticias: Login
    {
        #region Menus

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/navigationNews")]
        IWebElement menuNoticias;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/navigationMenu")]
        IWebElement menuMenu;

        #endregion

        #region Botões para sair do sistema

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/exitMenu")]
        IWebElement btnSair;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/positiveButton")]
        IWebElement btnConfirmacaoSim;
        
        #endregion

        public void PesquisaNoticia(string tagNoticia)
        {
            LoginCorreto();
            MetodosComuns oMetodosComuns = new MetodosComuns();

            try
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(menuNoticias));
                menuNoticias.Click();

                Thread.Sleep(3000);

                //Aqui o sistema pesquisa uma notícia que contenha o parâmetro no título e se a pesquisa é infinita ou não
                IWebElement elementoSelecionado = oMetodosComuns.CapturaNoticiaDaLista(driver, tagNoticia, "br.com.cedrotech.fastmobile.dev:id/newsTitle", null, true);
                
                //Se existe clica na notícia
                if (elementoSelecionado != null)
                {
                    elementoSelecionado.Click();
                }
                //Se não sai do sistema
                else
                {
                    menuMenu.Click();

                    espera.Until(ExpectedConditions.ElementToBeClickable(btnSair));
                    btnSair.Click();

                    espera.Until(ExpectedConditions.ElementToBeClickable(btnConfirmacaoSim));
                    btnConfirmacaoSim.Click();
                }
            }
            catch
            {
                //Aqui o sistema pesquisa uma notícia que contenha o parâmetro no título e se a pesquisa é infinita ou não
                IWebElement elementoSelecionado = oMetodosComuns.CapturaNoticiaDaLista(driver, tagNoticia, "br.com.cedrotech.fastmobile.dev:id/newsTitle", null, true);

                //Se existe clica na notícia
                if (elementoSelecionado != null)
                {
                    elementoSelecionado.Click();
                }
                //Se não sai do sistema
                else
                {
                    menuMenu.Click();

                    espera.Until(ExpectedConditions.ElementToBeClickable(btnSair));
                    btnSair.Click();

                    espera.Until(ExpectedConditions.ElementToBeClickable(btnConfirmacaoSim));
                    btnConfirmacaoSim.Click();
                }
            }
        }
    }
}
