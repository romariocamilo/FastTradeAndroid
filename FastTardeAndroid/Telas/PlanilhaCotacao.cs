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
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/fullView")]
        IWebElement visaoCompleta;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/shortView")]
        IWebElement visaoResumida;
        #endregion

        #region Elementos para adicionar nova planilha de cotação
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/arrowIcon")]
        IWebElement btnExpandirListas;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/createNewList")]
        IWebElement btnCriarNovaLista;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/editNameSelectedEditText")]
        IWebElement campoNomeNovaPlanilha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/saveEdit")]
        IWebElement btnSalvar;
        #endregion

        #region Elementos para adicionar novo ativo
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButton")]
        IWebElement btnAdicionaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/autocompleteQuotation")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[2]/android.widget.ImageView")]
        IWebElement ativoPetr4;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.ImageView")]
        IWebElement ativoVale3;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.ImageView")]
        IWebElement ativoVulc3;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButtonAddQuote")]
        IWebElement btnAdicionaAtivoDaLista;

        #endregion

        #region Elementos para renomear e excluir planilhas
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/editItemList")]
        IWebElement btnRenomearPlanilha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/deleteItemList")]
        IWebElement btnExcluirPlanilha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/yesDelete")]
        IWebElement btnConfirmacaoExclusaoSim;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/YesDelete")]
        IWebElement btnNegacaoExclusaoNao;
        #endregion

        #region Elementos para excluir ativo da planilha
        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup")]
        IWebElement ativoRemovido;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButtonDelete")]
        IWebElement btnExcluirAtivo;
        #endregion

        public void VisualizarPlanilhaCotacaoDetalhada(string nomeAtivo)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            LoginCorreto();

            Thread.Sleep(3000);

            var listaDeAtivos = driver.FindElementsById("br.com.cedrotech.fastmobile.dev:id/quoteSimbol");

            if (listaDeAtivos[0].Text == "")
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                oMetodosComuns.AddAtivoNaPlanilhaCotacaoAtual(driver, nomeAtivo);

                espera.Until(ExpectedConditions.ElementToBeClickable(visaoCompleta));
                visaoCompleta.Click();
            }
        }

        public void VisualizarPlanilhaCotacaoResumida(string nomeAtivo)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            LoginCorreto();

            Thread.Sleep(3000);

            var listaDeAtivos = driver.FindElementsById("br.com.cedrotech.fastmobile.dev:id/quoteSimbol");

            if (listaDeAtivos[0].Text == "")
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                oMetodosComuns.AddAtivoNaPlanilhaCotacaoAtual(driver, nomeAtivo);

                espera.Until(ExpectedConditions.ElementToBeClickable(visaoResumida));
                visaoResumida.Click();
            }
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

            Thread.Sleep(1000);
            IWebElement elementoCapturado = oMetodosComuns.CapturaElementoDaLista(driver, nomePlanilhaCotacao, "br.com.cedrotech.fastmobile.dev:id/listName");

            espera.Until(ExpectedConditions.ElementToBeClickable(elementoCapturado));
            elementoCapturado.Click();
        }

        public void TrocaPlanilhaCotacao(string nomePlanilha)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            LoginCorreto();

            Thread.Sleep(3000);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
            btnExpandirListas.Click();

            try
            {
                IWebElement elementoCapturado = oMetodosComuns.CapturaElementoDaLista(driver, nomePlanilha, "br.com.cedrotech.fastmobile.dev:id/listName");

                espera.Until(ExpectedConditions.ElementToBeClickable(elementoCapturado));
                elementoCapturado.Click();
            }
            catch
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
                btnCriarNovaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomePlanilha);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();

                IWebElement elementoCapturado = oMetodosComuns.CapturaElementoDaLista(driver, nomePlanilha, "br.com.cedrotech.fastmobile.dev:id/listName");

                espera.Until(ExpectedConditions.ElementToBeClickable(elementoCapturado));
                elementoCapturado.Click();
            }

        }

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
                var planilhaSelecionada = oMetodosComuns.CapturaElementoDaLista(driver, nomeDaPlanilha, "br.com.cedrotech.fastmobile.dev:id/listName");

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

                var planilhaSelecionada = oMetodosComuns.CapturaElementoDaLista(driver, nomeDaPlanilha, "br.com.cedrotech.fastmobile.dev:id/listName");

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

        public void ExcluirPlanilhaCotacao(string nomePlanilhaExcluida)
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
                var planilhaSelecionada = oMetodosComuns.CapturaElementoDaLista(driver, nomePlanilhaExcluida, "br.com.cedrotech.fastmobile.dev:id/listName");

                oMetodosComuns.LongPressPosicoesFixas(driver, planilhaSelecionada.Location.X + 300, planilhaSelecionada.Location.Y, 100, planilhaSelecionada.Location.Y);

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
                campoNomeNovaPlanilha.SendKeys(nomePlanilhaExcluida);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();

                var planilhaSelecionada = oMetodosComuns.CapturaElementoDaLista(driver, nomePlanilhaExcluida, "br.com.cedrotech.fastmobile.dev:id/listName");

                oMetodosComuns.LongPressPosicoesFixas(driver, planilhaSelecionada.Location.X + 300, planilhaSelecionada.Location.Y, 100, planilhaSelecionada.Location.Y);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirPlanilha));
                btnExcluirPlanilha.Click();

                Thread.Sleep(1000);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnConfirmacaoExclusaoSim));
                btnConfirmacaoExclusaoSim.Click();
            }
        }

        public void AdicionaAtivosPlanilha(string nomePlanilha, string nomeAtivo)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            AdicionarPlanilhaCotacao(nomePlanilha);

            espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
            btnAdicionaAtivo.Click();

            oMetodosComuns.AddAtivoNaPlanilhaCotacaoAtual(driver, nomeAtivo);
        }

        /*ESSA OPÇÃO AINDA NÃO ESTA DISPONÍVEL NO APP
        public void ReordenaAtivosPlanilha()
        {
            ESSA OPÇÃO AINDA NÃO ESTA DISPONÍVEL NO APP
        }*/

        public void ExcluirAtivoPlanilha(string nomeDoAtivo)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();
            LoginCorreto();

            try
            {
                Thread.Sleep(2000);
                IWebElement elementoCapturado = oMetodosComuns.CapturaElementoDaLista(driver, nomeDoAtivo, "br.com.cedrotech.fastmobile.dev:id/quoteSimbol");

                espera.Until(ExpectedConditions.ElementToBeClickable(elementoCapturado));
                oMetodosComuns.LongPressPosicoesFixas(driver, elementoCapturado.Location.X + 400, elementoCapturado.Location.Y, elementoCapturado.Location.X, elementoCapturado.Location.Y);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();
            }
            catch
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
                campoPesquisaAtivo.SendKeys(nomeDoAtivo);

                oMetodosComuns.AddAtivoNaPlanilhaCotacaoAtual(driver, nomeDoAtivo);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivoDaLista));
                btnAdicionaAtivoDaLista.Click();

                Thread.Sleep(2000);
                IWebElement elementoCapturado = oMetodosComuns.CapturaElementoDaLista(driver, nomeDoAtivo, "br.com.cedrotech.fastmobile.dev:id/quoteSimbol");

                espera.Until(ExpectedConditions.ElementToBeClickable(elementoCapturado));
                oMetodosComuns.LongPressPosicoesFixas(driver, elementoCapturado.Location.X + 400, elementoCapturado.Location.Y, elementoCapturado.Location.X, elementoCapturado.Location.Y);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();
            }
        }
    }
}
