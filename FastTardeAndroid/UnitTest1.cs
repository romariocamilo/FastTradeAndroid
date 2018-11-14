using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace FastTradeAndroid
{
    [TestClass]
    public class PlanilhaCotacao
    {
        [TestMethod]
        public void VisualizarPlanilhaCotacaoDetalhada()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.VisualizarPlanilhaCotacaoDetalhada();
        }

        [TestMethod]
        public void VisualizarPlanilhaCotacaoResumida()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.VisualizarPlanilhaCotacaoResumida();
        }

        //Nesse cenário é necessário implementar o scroll para valida a planilha criada
        [TestMethod]
        public void AdicionarPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.AdicionarPlanilhaCotacao("Maiauma lista");
        }

        [TestMethod]
        public void TrocaPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.TrocaPlanilhaCotacao("novaplanilhaparateste");
        }

        [TestMethod]
        public void RenomearPlanilhaCotacao()
        {
            Cotacoes oCotacoes = new Cotacoes();
            oCotacoes.RenomearPlanilhaCotacao("teste");
        }
    }

    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void FluxoLogin()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Login oLogin = new Login();
            oLogin.LoginCorreto();
        }

        [TestMethod]
        public void FluxoPesquisaRapidoAtivo()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            ConsultaRapida oConsultaRapida = new ConsultaRapida();
            oConsultaRapida.FluxoPesquisaRapidoAtivo("VULC3");
        }

        //Carteira Ausente Fast 1.11
        [TestMethod]
        public void FluxoVisualizaSaldo()
        {
            //Aqui ocorrem os testes de login incorreto, login correto e logof sem corretora
            Carteira oCarteira = new Carteira();
            oCarteira.VisualizaSaldo();
        }
    }
}
