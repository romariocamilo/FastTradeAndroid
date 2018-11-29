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

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/YesDelete")]
        IWebElement btnNegacaoExclusaoNao;
        #endregion

        #region Elementos para excluir ativo da planilha
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup")]
        IWebElement ativoRemovido;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/floatingActionButtonDelete")]
        IWebElement btnExcluirAtivo;
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
            MetodosComuns oMetodosComuns = new MetodosComuns();
            LoginCorreto();

            Thread.Sleep(3000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
            btnCriarNovaLista.Click();

            espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
            campoNomeNovaPlanilha.SendKeys(nomePlanilhaCotacao);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
            btnSalvar.Click();

            //DAQUI EM DIANTE COMEÇA OS TESTES DO SCROLL

            Thread.Sleep(1000);
            oMetodosComuns.ScrollParaListaDePlanilhas(driver, "br.com.cedrotech.fastmobile:id/listName");
        }

        //var lista OK
        public void TrocaPlanilhaCotacao(string nomePlanilha)
        {
            LoginCorreto();

            Thread.Sleep(3000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            try
            {
                //espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));

                var listaDePlanilhas = driver.FindElementsById("br.com.cedrotech.fastmobile:id/listName");
                var planilhaInserida = listaDePlanilhas.FirstOrDefault(p => p.Text == nomePlanilha.ToUpperInvariant());

                espera.Until(ExpectedConditions.ElementToBeClickable(planilhaInserida));
                planilhaInserida.Click();
            }
            catch
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
                btnCriarNovaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomePlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();

                //espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));

                var listaDePlanilhas = driver.FindElementsById("br.com.cedrotech.fastmobile:id/listName");
                var planilhaInserida = listaDePlanilhas.FirstOrDefault(p => p.Text == nomePlanilha.ToUpperInvariant());

                espera.Until(ExpectedConditions.ElementToBeClickable(planilhaInserida));
                planilhaInserida.Click();
            }

        }

        //var lista OK
        public void RenomearPlanilhaCotacao(string nomeDaPlanilha, string novoNomeDaPlanilha)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();
            LoginCorreto();

            Thread.Sleep(3000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            //Nesse tratamento caso não haja uma planilha para renomear o teste cria uma.
            try
            {
                var listaDePlanilhas = driver.FindElementsById("br.com.cedrotech.fastmobile:id/listName");
                var planilhaSelecionada = listaDePlanilhas.FirstOrDefault(lp => lp.Text.ToUpperInvariant() == nomeDaPlanilha.ToUpperInvariant());

                espera.Until(ExpectedConditions.ElementToBeClickable(planilhaSelecionada));
                oMetodosComuns.LongPressPosicoesFixas(driver, planilhaSelecionada.Location.X + 300, planilhaSelecionada.Location.Y, planilhaSelecionada.Location.X, planilhaSelecionada.Location.Y);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnRenomearPlanilha));
                btnRenomearPlanilha.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(novoNomeDaPlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();
            }
            catch
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
                btnCriarNovaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomeDaPlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();

                var listaDePlanilhas = driver.FindElementsById("br.com.cedrotech.fastmobile:id/listName");
                var planilhaSelecionada = listaDePlanilhas.FirstOrDefault(lp => lp.Text.ToUpperInvariant() == nomeDaPlanilha.ToUpperInvariant());

                espera.Until(ExpectedConditions.ElementToBeClickable(planilhaSelecionada));
                oMetodosComuns.LongPressPosicoesFixas(driver, planilhaSelecionada.Location.X + 300, planilhaSelecionada.Location.Y, 100, planilhaSelecionada.Location.Y);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnRenomearPlanilha));
                btnRenomearPlanilha.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(novoNomeDaPlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();
            }
        }

        public void ExcluirPlanilhaCotacao(string nomeNovaPlanilha)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();
            TouchAction novaAcao = new TouchAction(driver);
            LoginCorreto();

            Thread.Sleep(3000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            //Nesse tratamento caso não haja uma planilha para renomear o teste cria uma.
            try
            {
                //espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                //oMetodosComuns.LongPressPorElemento(driver, segundaPlanilhaCotacao, true, false, 50);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirPlanilha));
                btnExcluirPlanilha.Click();

                Thread.Sleep(1000);

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

                //espera.Until(ExpectedConditions.ElementToBeClickable(segundaPlanilhaCotacao));
                //oMetodosComuns.LongPressPorElemento(driver, segundaPlanilhaCotacao, true, false, 50);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirPlanilha));
                btnExcluirPlanilha.Click();

                Thread.Sleep(1000);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnConfirmacaoExclusaoSim));
                btnConfirmacaoExclusaoSim.Click();
            }
        }

        //var Lista OK
        public void AdicionaAtivosPlanilha(string nomePlanilha)
        {
            AdicionarPlanilhaCotacao(nomePlanilha);

            var listaDePlanilhas = driver.FindElementsById("br.com.cedrotech.fastmobile:id/listName");

            var planilhaInserida = listaDePlanilhas.FirstOrDefault(p => p.Text == nomePlanilha.ToUpperInvariant());
            planilhaInserida.Click();

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
        //public void ReordenaAtivosPlanilha()
        //{
        //    //ESSA OPÇÃO AINDA NÃO ESTA DISPONÍVEL NO APP
        //}

        public void ExcluirAtivoPlanilha()
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            try
            {
                LoginCorreto();

                Thread.Sleep(2000);
                espera.Until(ExpectedConditions.ElementToBeClickable(ativoRemovido));
                oMetodosComuns.LongPressPosicoesFixas(driver, 950, 760, 200, 760);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();
            }
            catch
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                SelecionaAtivo("PETR4", ativoPetr4);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivoDaLista));
                btnAdicionaAtivoDaLista.Click();

                Thread.Sleep(2000);

                espera.Until(ExpectedConditions.ElementToBeClickable(ativoRemovido));
                oMetodosComuns.LongPressPosicoesFixas(driver, 950, 760, 200, 760);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();
            }
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
