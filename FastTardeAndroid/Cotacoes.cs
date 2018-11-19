using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
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

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/recyclerListUser")]
        IWebElement framePlanilhas;
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

        #region Elementos para renomear e excluir planilhas
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/editItemList")]
        IWebElement btnRenomearPlanilha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/deleteItemList")]
        IWebElement btnExcluirPlanilha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/yesDelete")]
        IWebElement btnConfirmacaoExclusaoSim;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/noDelete")]
        IWebElement btnNegacaoExclusaoNao;
        #endregion

        #region Elementos para excluir ativo da planilha
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup")]
        IWebElement ativoRemovido;
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
            }

        }

        public void RenomearPlanilhaCotacao(string nomeNovaPlanilha, string nomeAlteradoPlanilha)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();
            LoginCorreto();

            Thread.Sleep(2000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            //Nesse tratamento caso não haja uma planilha para renomear o teste cria uma.
            try
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                oMetodosComuns.LongPressFrameDirecao(driver, segundaPlanilhaCotacao, true, false, 50);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnRenomearPlanilha));
                btnRenomearPlanilha.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomeAlteradoPlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();
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
                oMetodosComuns.LongPressFrameDirecao(driver, segundaPlanilhaCotacao, true, false, 50);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnRenomearPlanilha));
                btnRenomearPlanilha.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomeAlteradoPlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();
            }
        }

        public void ExcluirPlanilhaCotacao(string nomeNovaPlanilha)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();
            TouchAction novaAcao = new TouchAction(driver);
            LoginCorreto();

            Thread.Sleep(1000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            //Nesse tratamento caso não haja uma planilha para renomear o teste cria uma.
            try
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                oMetodosComuns.LongPressFrameDirecao(driver, segundaPlanilhaCotacao, true, false, 50);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirPlanilha));
                btnExcluirPlanilha.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnNegacaoExclusaoNao));
                btnNegacaoExclusaoNao.Click();

                //Aqui o sistema não estava encontranto o elemento btnExcluirPlanilha por esse motivo fiz clica na tela
                Thread.Sleep(1000);
                novaAcao.Tap(925, 504, 2).Perform();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnConfirmacaoExclusaoSim));
                btnConfirmacaoExclusaoSim.Click();
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
                oMetodosComuns.LongPressFrameDirecao(driver, segundaPlanilhaCotacao, true, false, 50);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirPlanilha));
                btnExcluirPlanilha.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnNegacaoExclusaoNao));
                btnNegacaoExclusaoNao.Click();

                //Aqui o sistema não estava encontranto o elemento btnExcluirPlanilha por esse motivo fiz clica na tela
                Thread.Sleep(1000);
                novaAcao.Tap(925, 504, 2).Perform();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnConfirmacaoExclusaoSim));
                btnConfirmacaoExclusaoSim.Click();
            }
        }

        public void AdicionaAtivosPlanilha()
        {
            LoginCorreto();

            //Ciclo para adicionar ativos
            espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
            btnAdicionaAtivo.Click();

            SelecionaAtivo("PETR4", ativoPetr4);
            SelecionaAtivo("VALE3", ativoVale3);
            SelecionaAtivo("VULC3", ativoVulc3);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivoDaLista));
            btnAdicionaAtivoDaLista.Click();
        }

        //ESSA OPÇÃO AINDA NÃO ESTA DISPONÍVEL NO APP
        public void ReordenaAtivosPlanilha()
        {
            //ESSA OPÇÃO AINDA NÃO ESTA DISPONÍVEL NO APP
        }

        public void ExcluirAtivoPlanilha()
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();
            TouchAction novaAcao = new TouchAction(driver);
            LoginCorreto();


            espera.Until(ExpectedConditions.ElementToBeClickable(ativoRemovido));
            oMetodosComuns.LongPressFrameDirecao(driver, ativoRemovido, true, false, 20);
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
        public void SelecionaAtivo(string nomeAtivo, IWebElement elementoAtivo)
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys(nomeAtivo);

            espera.Until(ExpectedConditions.ElementToBeClickable(ativoVale3));
            elementoAtivo.Click();
        }
    }
}
