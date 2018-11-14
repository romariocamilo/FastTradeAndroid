using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
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
    class Cotacoes : Login
    {
        #region Menus
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/navigationQuotations")]
        IWebElement menuCotacao;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/navigationNews")]
        IWebElement menuNoticia;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/navigationMenu")]
        IWebElement menuMenu;
        #endregion

        #region Tipo De Cotações
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/fullView")]
        IWebElement cotacaoCompleta;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/shortView")]
        IWebElement cotacaoResumida;
        #endregion

        #region Elementos para adicionar nova planilha de cotação
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/arrowIcon")]
        IWebElement btnExpandirListas;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/createNewList")]
        IWebElement btnCriarNovaLista;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/editNameSelectedEditText")]
        IWebElement campoNomeNovaPlanilha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/saveEdit")]
        IWebElement btnSalvar;
        #endregion

        #region Elemento para alteração da planilha de cotação
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.widget.FrameLayout[1]/android.view.ViewGroup")]
        IWebElement segundaPlanilhaCotacao;
        #endregion

        #region Elementos para adicionar novo ativo
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/floatingActionButton")]
        IWebElement btnAdicionaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/autocompleteQuotation")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[2]/android.widget.ImageView")]
        IWebElement ativoPetr4;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.ImageView")]
        IWebElement ativoVale3;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.ImageView")]
        IWebElement ativoVulc3;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/floatingActionButtonAddQuote")]
        IWebElement btnAdicionaAtivoDaLista;

        #endregion

        public void VisualizarPlanilhaCotacaoDetalhada()
        {
            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(cotacaoCompleta));
            cotacaoCompleta.Click();
        }

        public void VisualizarPlanilhaCotacaoResumida()
        {
            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(cotacaoResumida));
            cotacaoResumida.Click();
        }

        public void AdicionarPlanilhaCotacao(string nomePlanilhaCotacao)
        {
            LoginCorreto();
            
            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
            btnCriarNovaLista.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
            campoNomeNovaPlanilha.SendKeys(nomePlanilhaCotacao);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
            btnSalvar.Click();

        }

        public void TrocaPlanilhaCotacao(string nomeNovaPlanilha)
        {
            LoginCorreto();
            
            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            try
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                segundaPlanilhaCotacao.Click();
            }
            catch
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
                btnCriarNovaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomeNovaPlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                segundaPlanilhaCotacao.Click();

                //Ciclo para adicionar ativos
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                AdicionaAtivoNaPlanilha("PETR4", ativoPetr4);
                AdicionaAtivoNaPlanilha("VALE3", ativoVale3);
                AdicionaAtivoNaPlanilha("VULC3", ativoVulc3);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivoDaLista));
                btnAdicionaAtivoDaLista.Click();
            }

        }

        //EM IMPLEMENTAÇÃO
        public void RenomearPlanilhaCotacao(string nomeNovaPlanilha)
        {
            LoginCorreto();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            try
            {
                TouchAction novaAcao = new TouchAction(driver);
                
                espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                //segundaPlanilhaCotacao.Click();
                novaAcao.LongPress(1000, 500).MoveTo(500, 500).Release().Perform();
            }
            catch
            {
                TouchAction novaAcao = new TouchAction(driver);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
                btnCriarNovaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomeNovaPlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                //segundaPlanilhaCotacao.Click();
                //novaAcao.ClickAndHold(segundaPlanilhaCotacao).MoveByOffset(483, 483).Build();
                novaAca.LongPress(1000, 500).MoveTo(500, 500).Release().Perform();
                //500 500 destino
            }
        }


        //Acesso aos demais menus do sistema
        public void AcessarMenuCotações()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(menuCotacao));
            menuCotacao.Click();
        }

        public void AcessarMenuNoticias()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(menuNoticia));
            menuNoticia.Click();
        }

        public void AcessarMenuMenu()
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(menuMenu));
            menuMenu.Click();
        }

        //Esse método é usado para adicionar novos ativos.
        public void AdicionaAtivoNaPlanilha(string nomeAtivo, IWebElement elementoAtivo)
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys(nomeAtivo);

            espera.Until(ExpectedConditions.ElementToBeClickable(ativoVale3));
            elementoAtivo.Click();
        }
    }
}
