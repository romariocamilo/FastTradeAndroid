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
    class ResumoAtivo : Login
    {
        #region Elementos para adicionar novo ativo

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/floatingActionButton")]
        IWebElement btnAdicionaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/autocompleteQuotation")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.ImageView")]
        IWebElement primeiroElementoDaPesquisa;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/floatingActionButtonAddQuote")]
        IWebElement btnAdicionaAtivoDaLista;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/quoteSimbol")]
        IWebElement ativosDaPlanilha;

        #endregion

        #region Elementos para excluir ativo da planilha

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup")]
        IWebElement ativoRemovido;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile:id/floatingActionButtonDelete")]
        IWebElement btnExcluirAtivo;

        #endregion

        public void AcessoResumoAtivo(string simboloDoAtivo)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            try
            {
                LoginCorreto();

                espera.Until(ExpectedConditions.ElementToBeClickable(ativosDaPlanilha));

                var listraDeAtivosDisponiveis = driver.FindElementsById("br.com.cedrotech.fastmobile:id/quoteSimbol");

                var ativoSelecionado = listraDeAtivosDisponiveis.FirstOrDefault(p => p.Text == simboloDoAtivo.ToUpperInvariant());
                ativoSelecionado.Click();
            }
            catch
            {
                //Inserindo ativo
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                SelecionaAtivo(simboloDoAtivo, primeiroElementoDaPesquisa);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivoDaLista));
                btnAdicionaAtivoDaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(ativosDaPlanilha));

                var listraDeAtivosDisponiveis = driver.FindElementsById("br.com.cedrotech.fastmobile:id/quoteSimbol");

                var ativoSelecionado = listraDeAtivosDisponiveis.FirstOrDefault(p => p.Text == simboloDoAtivo.ToUpperInvariant());
                ativoSelecionado.Click();
            }
        }

        public void SelecionaAtivo(string nomeAtivo, IWebElement elementoAtivo)
        {
            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys(nomeAtivo);

            espera.Until(ExpectedConditions.ElementToBeClickable(primeiroElementoDaPesquisa));
            elementoAtivo.Click();
        }
    }
}
