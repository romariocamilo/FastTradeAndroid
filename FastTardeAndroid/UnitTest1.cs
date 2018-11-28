using System;
using System.Diagnostics;
using FastTradeAndroid.Telas;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace FastTradeAndroid
{
    [TestClass]
    public class TestesPlanilhaCotacao
    {
        [TestMethod]
        [Priority(1)]
        public void VisualizarPlanilhaCotacaoDetalhada()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.VisualizarPlanilhaCotacaoDetalhada();
        }

        [TestMethod]
        [Priority(2)]
        public void VisualizarPlanilhaCotacaoResumida()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.VisualizarPlanilhaCotacaoResumida();
        }

        //Nesse cenário é necessário implementar o scroll para valida a planilha criada
        [TestMethod]
        [Priority(3)]
        public void AdicionarPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.AdicionarPlanilhaCotacao("Planilha 2");
        }

        [TestMethod]
        [Priority(4)]
        public void TrocaPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.TrocaPlanilhaCotacao("PLANILHA QUINTA3");
        }

        [TestMethod]
        [Priority(5)]
        public void RenomearPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.RenomearPlanilhaCotacao("NovaPlanilha", "NovoNome");
        }

        [TestMethod]
        [Priority(6)]
        public void ExcluirPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.ExcluirPlanilhaCotacao("PlanilhaParaExcluir");
        }

        [TestMethod]
        [Priority(7)]
        public void AdicionaAtivosPlanilha()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.AdicionaAtivosPlanilha("PLANILHA ROMARIO2");
        }

        [TestMethod]
        [Priority(8)]
        public void ExcluirAtivoPlanilha()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.ExcluirAtivoPlanilha();
        }
    }

    [TestClass]
    public class TestesGraficoCotacao
    {
        [TestMethod]
        [Priority(1)]
        public void AcessoGraficoCotacao()
        {
            GraficoCotacao oGraficoCotacao = new GraficoCotacao();
            oGraficoCotacao.AcessoGraficoCotacao();
        }

        [TestMethod]
        [Priority(2)]
        public void AcessoGraficoExpandido()
        {
            GraficoCotacao oGraficoCotacao = new GraficoCotacao();
            oGraficoCotacao.AcessoGraficoExpandido();
        }
    }

    [TestClass]
    public class TestesResumoAtivo
    {
        [TestMethod]
        [Priority(1)]
        public void AcessoResumoAtivo()
        {
            ResumoAtivo oResumoAtivo = new ResumoAtivo();
            oResumoAtivo.AcessoResumoAtivo("PETR4");
        }
    }

    [TestClass]
    public class TestesLivroDeOfertas
    {
        [TestMethod]
        [Priority(1)]
        public void AcessoOfertasDetalhadas()
        {
            LivroDeOfertas oResumoAtivo = new LivroDeOfertas();
            oResumoAtivo.AcessoOfertasDetalhadas("PETR4", "Ofertas Detalhadas");
        }

        [TestMethod]
        [Priority(1)]
        public void AcessoOfertasAgregadas()
        {
            LivroDeOfertas oResumoAtivo = new LivroDeOfertas();
            oResumoAtivo.AcessoOfertasDetalhadas("PETR4", "Ofertas Agregadas");
        }
    }

    //[TestClass]
    //public class UnitTest2
    //{
    //    [TestMethod]
    //    public void FluxoLogin()
    //    {
    //        //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
    //        Login oLogin = new Login();
    //        oLogin.LoginCorreto();
    //    }

    //    [TestMethod]
    //    public void FluxoPesquisaRapidoAtivo()
    //    {
    //        //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
    //        ConsultaRapida oConsultaRapida = new ConsultaRapida();
    //        oConsultaRapida.FluxoPesquisaRapidoAtivo("VULC3");
    //    }

    //    //Carteira Ausente Fast 1.11
    //    [TestMethod]
    //    public void FluxoVisualizaSaldo()
    //    {
    //        //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
    //        Carteira oCarteira = new Carteira();
    //        oCarteira.VisualizaSaldo();
    //    }
    //}

}
