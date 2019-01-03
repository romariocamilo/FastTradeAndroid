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
    class GraficoCotacao : Login
    {
        #region Elementos para adicionar novo ativo

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButton")]
        IWebElement btnAdicionaAtivo;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/autocompleteQuotation")]
        IWebElement campoPesquisaAtivo;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.support.v7.widget.RecyclerView/android.view.ViewGroup[2]/android.widget.ImageView")]
        IWebElement ativoPetr4;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButtonAddQuote")]
        IWebElement btnAdicionaAtivoDaLista;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/quoteSimbol")]
        IWebElement btnAtivoLista;

        #endregion

        #region Elementos da tela de gráfico

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/close")]
        IWebElement btnFecharGrafico;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/lineChartOption")]
        IWebElement btnGraficoLinha;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/candleChartOption")]
        IWebElement btnGraficoColuna;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/oneDay")]
        IWebElement btnUmDia;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/fifteenDays")]
        IWebElement btnQuinzeDias;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/oneMonth")]
        IWebElement btnUmMes;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/sixMonths")]
        IWebElement btnSeisMeses;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/oneYear")]
        IWebElement btnUmAno;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/fullOption")]
        IWebElement btnExpandirGrafico;     

        #endregion

        #region Elementos para excluir ativo da planilha

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup/android.widget.FrameLayout[1]/android.view.ViewGroup/android.view.ViewGroup[2]/android.support.v7.widget.RecyclerView/android.view.ViewGroup[1]/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.view.ViewGroup")]
        IWebElement ativoRemovido;

        [FindsBy(How = How.Id, Using = "br.com.cedrotech.fastmobile.dev:id/floatingActionButtonDelete")]
        IWebElement btnExcluirAtivo;

        #endregion

        public void AcessoGraficoCotacao()
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            try
            {
                LoginCorreto();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAtivoLista));
                btnAtivoLista.Click();

                //Verificando gráfico do ativo em linha
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                //Verificando gráfico do ativo em coluna
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnGraficoColuna));
                btnGraficoColuna.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnFecharGrafico));
                btnFecharGrafico.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(ativoRemovido));
                oMetodosComuns.LongPressPosicoesFixas(driver, 950, 760, 200, 760);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();

            }
            catch
            {
                //Inserindo ativo
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivoDaLista));
                btnAdicionaAtivoDaLista.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAtivoLista));
                btnAtivoLista.Click();

                //Verificando gráfico do ativo em linha
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                //Verificando gráfico do ativo em coluna
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnGraficoColuna));
                btnGraficoColuna.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnFecharGrafico));
                btnFecharGrafico.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(ativoRemovido));
                oMetodosComuns.LongPressPosicoesFixas(driver, 950, 760, 200, 760);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();

            }
        }

        public void AcessoGraficoExpandido(string nomeDoAtivo)
        {
            MetodosComuns oMetodosComuns = new MetodosComuns();

            try
            {
                LoginCorreto();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                //btnAtivoLista.Click();

                var ativoSelecionado = oMetodosComuns.CapturaElementoDaLista(driver, nomeDoAtivo, "br.com.cedrotech.fastmobile.dev:id/quoteSimbol");
                ativoSelecionado.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirGrafico));
                btnExpandirGrafico.Click();

                //Verificando gráfico do ativo em linha
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                //Verificando gráfico do ativo em coluna
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnGraficoColuna));
                btnGraficoColuna.Click();
               
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirGrafico));
                btnExpandirGrafico.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnFecharGrafico));
                btnFecharGrafico.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(ativoRemovido));
                oMetodosComuns.LongPressPosicoesFixas(driver, 950, 760, 200, 760);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();
            }
            catch
            {
                //Inserindo ativo
                espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivo));
                btnAdicionaAtivo.Click();

                oMetodosComuns.AddAtivoNaPlanilhaCotacaoAtual(driver, nomeDoAtivo);

                //espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
                //campoPesquisaAtivo.SendKeys(nomeDoAtivo);

                var ativoSelecionado = oMetodosComuns.CapturaElementoDaLista(driver, nomeDoAtivo, "br.com.cedrotech.fastmobile.dev:id/quoteSimbol");
                ativoSelecionado.Click();

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirGrafico));
                btnExpandirGrafico.Click();

                //Verificando gráfico do ativo em linha
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmDia.Click();

                //Verificando gráfico do ativo em coluna
                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnGraficoColuna));
                btnGraficoColuna.Click();      

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnUmDia));
                btnUmMes.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnQuinzeDias));
                //btnQuinzeDias.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnSeisMeses));
                btnSeisMeses.Click();

                //Thread.Sleep(3000);
                //espera.Until(ExpectedConditions.ElementToBeClickable(btnUmAno));
                //btnUmAno.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnExpandirGrafico));
                btnExpandirGrafico.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(btnFecharGrafico));
                btnFecharGrafico.Click();

                Thread.Sleep(3000);
                espera.Until(ExpectedConditions.ElementToBeClickable(ativoRemovido));
                oMetodosComuns.LongPressPosicoesFixas(driver, 950, 760, 200, 760);

                espera.Until(ExpectedConditions.ElementToBeClickable(btnExcluirAtivo));
                btnExcluirAtivo.Click();
            }
        }
    }
}
