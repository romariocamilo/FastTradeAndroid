using System;
using System.Diagnostics;
using FastTradeAndroid.Telas;
using FastTradeAndroid.TestesMetodos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace FastTradeAndroid
{
    [TestClass]
    public class TestesLogin
    {
        [TestMethod]
        [Priority(1)]
        public void LoginCorreto()
        {
            Login oLogin = new ConsultaRapida();
            oLogin.LoginCorreto();
        }

        [TestMethod]
        [Priority(1)]
        public void LoginIncorreto()
        {
            Login oLogin = new ConsultaRapida();
            oLogin.LoginIncorreto();
        }
    }

    [TestClass]
    public class TestesPlanilhaCotacao
    {
        static string dataAtual = DateTime.Now.ToLocalTime().ToString();
        static string nomeCliente = "Romario";
        string ativoDosTestes = "PETR4";
        string nomeApresentacao = nomeCliente + ": " + dataAtual;

        [TestMethod]
        [Priority(1)]
        public void VisualizarPlanilhaCotacaoDetalhada()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.VisualizarPlanilhaCotacaoDetalhada(ativoDosTestes);
        }

        [TestMethod]
        [Priority(2)]
        public void VisualizarPlanilhaCotacaoResumida()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.VisualizarPlanilhaCotacaoResumida(ativoDosTestes);
        }

        //Nesse cenário é necessário implementar o scroll para valida a planilha criada
        [TestMethod]
        [Priority(3)]
        public void AdicionarPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.AdicionarPlanilhaCotacao(nomeApresentacao);     
        }

        [TestMethod]
        [Priority(4)]
        public void TrocaPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.TrocaPlanilhaCotacao(nomeApresentacao);
        }

        [TestMethod]
        [Priority(5)]
        public void RenomearPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.RenomearPlanilhaCotacao(nomeApresentacao, "Planilha Renomeada");
        }

        [TestMethod]
        [Priority(6)]
        public void ExcluirPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.ExcluirPlanilhaCotacao("Planilha Para Excluir");
        }

        [TestMethod]
        [Priority(7)]
        public void AdicionaAtivosPlanilha()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.AdicionaAtivosPlanilha(nomeApresentacao, ativoDosTestes);
        }

        [TestMethod]
        [Priority(8)]
        public void ExcluirAtivoPlanilha()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.ExcluirAtivoPlanilha(ativoDosTestes);
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
            oGraficoCotacao.AcessoGraficoExpandido("PETR4");
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
        [Priority(2)]
        public void AcessoOfertasAgregadas()
        {
            LivroDeOfertas oResumoAtivo = new LivroDeOfertas();
            oResumoAtivo.AcessoOfertasAgregadas("PETR4", "Ofertas Agregadas");
        }
    }

    [TestClass]
    public class TestesConsultaRapida
    {
        [TestMethod]
        [Priority(1)]
        public void AcessoConsultaRapida()
        {
            ConsultaRapida oConsultaRapida = new ConsultaRapida();
            oConsultaRapida.ConsultaRapidoAtivo("PETR4", "CMIG4");
        }
    }

    [TestClass]
    public class TestesNoticias
    {
        [TestMethod]
        [Priority(1)]
        public void ConsultarNoticias()
        {
            Noticias oNoticias = new Noticias();
            oNoticias.PesquisaNoticia("PETR44444");
        }
    }

    //Essa TestClass é usada somente para testar os metodos comuns
    [TestClass]
    public class TesteDeMetodos
    {
        [TestMethod]
        [Priority(1)]
        public void TesteMetodos()
        {
            TestesUnitarios oTestesUnitarios = new TestesUnitarios();
            //oTestesUnitarios.teste("opa");

            oTestesUnitarios.teste2("petr4");
        }
    }
}
