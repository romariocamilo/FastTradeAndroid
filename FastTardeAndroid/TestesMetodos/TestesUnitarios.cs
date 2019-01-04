using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastTradeAndroid.TestesMetodos
{
    class TestesUnitarios : Login
    {
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

        #region Elementos para adicionar novo ativo
        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButton")]
        IWebElement btnAdicionaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/autocompleteQuotation")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButtonAddQuote")]
        IWebElement btnAdicionaAtivoDaLista;

        #endregion

        public void teste(string nomeDaLista)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            LoginCorreto();
            try
            {
                oMetodosComuns.HabilitaRenomearExcluirPlanilha(driver, oMetodosComuns.CapturaElementoDaLista(driver, nomeDaLista, "br.com.cedrotech.fastmobile.dev:id/listName"));
            }
            catch
            {
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirListas));
                btnExpandirListas.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnCriarNovaLista));
                btnCriarNovaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(campoNomeNovaPlanilha));
                campoNomeNovaPlanilha.SendKeys(nomeDaLista);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnSalvar));
                btnSalvar.Click();

                oMetodosComuns.HabilitaRenomearExcluirPlanilha(driver, oMetodosComuns.CapturaElementoDaLista(driver, nomeDaLista, "br.com.cedrotech.fastmobile.dev:id/listName"));
            }
        }

        public void teste2(string nomeAtivo)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            LoginCorreto();
            try
            {
                oMetodosComuns.HabilitaExclusaoAtivosDaPlanilha(driver, oMetodosComuns.CapturaElementoDaLista(driver, nomeAtivo, "br.com.cedrotech.fastmobile.dev:id/quoteSimbol"));
            }
            catch
            {
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                oMetodosComuns.AddAtivoNaPlanilhaCotacaoAtual(driver, nomeAtivo);
                oMetodosComuns.HabilitaExclusaoAtivosDaPlanilha(driver, oMetodosComuns.CapturaElementoDaLista(driver, nomeAtivo, "br.com.cedrotech.fastmobile.dev:id/quoteSimbol"));
            }
        }
    }
}
