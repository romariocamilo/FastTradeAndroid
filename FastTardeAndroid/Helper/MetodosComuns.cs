﻿using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class MetodosComuns : AmbienteConfig
    {
        //Esse método clica em uma posição de origem da tela e arrasta para a posição destino
        public void LongPressPosicoesFixas(AppiumDriver<AndroidElement> driver, int posicaoOrigemX = 0, int posicaoOrigemY = 0, int posicaoDestinoX = 0, int posicaoDestinoY = 0)
        {
            TouchAction touchAction = new TouchAction(driver);
            touchAction
            .Press(posicaoOrigemX, posicaoOrigemY)
            .Wait(2000)
            .MoveTo(posicaoDestinoX, posicaoDestinoY)
            .Release()
            .Perform();
        }

        //Esse método efetual um scrool no final de uma lista disponível
        public void ScrollParaListasPlanilhas(AppiumDriver<AndroidElement> driver, string seletorIdDoElemento = null, string seletorClassDoElemento = null)
        {
            //Nesse else o método captura o elemento da lista pela seletor Id
            if (seletorIdDoElemento != null)
            {
                var validador = true;

                while (validador)
                {
                    var lista = driver.FindElementsById(seletorIdDoElemento);
                    var elementOrigem = lista.LastOrDefault();
                    var elementoDestino = lista.FirstOrDefault();

                    var nomeElementoOrigem = elementOrigem.Text;
                    var nomeElementoDestino = elementoDestino.Text;

                    TouchAction touchAction = new TouchAction(driver);

                    Thread.Sleep(1000);

                    touchAction
                    .Press(elementOrigem.Location.X, elementOrigem.Location.Y)
                    .Wait(1000)
                    .MoveTo(elementoDestino.Location.X, elementoDestino.Location.Y)
                    .Release()
                    .Perform();

                    lista = driver.FindElementsById(seletorIdDoElemento);
                    elementOrigem = lista.LastOrDefault();
                    elementoDestino = lista.FirstOrDefault();

                    var nomeNovoElementoOrigem = elementOrigem.Text;
                    var nomeNovoElementoDestino = elementoDestino.Text;

                    if (nomeElementoOrigem == nomeNovoElementoOrigem && nomeElementoDestino == nomeNovoElementoDestino)
                    {
                        break;
                        validador = false;
                    }
                }
            }

            //Nesse else o método captura o elemento da lista pela seletor Class
            else if (seletorClassDoElemento != null)
            {
                var validador = true;

                while (validador)
                {
                    var lista = driver.FindElementsByClassName(seletorClassDoElemento);
                    var elementOrigem = lista.LastOrDefault();
                    var elementoDestino = lista.FirstOrDefault();

                    var nomeElementoOrigem = elementOrigem.Text;
                    var nomeElementoDestino = elementoDestino.Text;

                    TouchAction touchAction = new TouchAction(driver);

                    Thread.Sleep(1000);

                    touchAction
                    .Press(elementOrigem.Location.X, elementOrigem.Location.Y)
                    .Wait(1000)
                    .MoveTo(elementoDestino.Location.X, elementoDestino.Location.Y)
                    .Release()
                    .Perform();

                    lista = driver.FindElementsById(seletorIdDoElemento);
                    elementOrigem = lista.LastOrDefault();
                    elementoDestino = lista.FirstOrDefault();

                    var nomeNovoElementoOrigem = elementOrigem.Text;
                    var nomeNovoElementoDestino = elementoDestino.Text;

                    if (nomeElementoOrigem == nomeNovoElementoOrigem && nomeElementoDestino == nomeNovoElementoDestino)
                    {
                        break;
                        validador = false;
                    }
                }
            }
        }

        //Esse método captura um determinado elemento da lista e retorna o mesmo, os seletores disponíveis são Id e Class
        public IWebElement CapturaElementoDaLista(AppiumDriver<AndroidElement> driver, string nomeDoElemento, string seletorIdDoElemento = null, string seletorClassDoElemento = null)
        {
            //Nesse else o método captura o elemento da lista pela seletor Id
            if (seletorIdDoElemento != null)
            {
                IWebElement elementoCapturado = null;
                WebDriverWait espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                while (elementoCapturado == null)
                {
                    Thread.Sleep(2000);
                    var lista = driver.FindElementsById(seletorIdDoElemento);
                    var elementOrigem = lista.LastOrDefault();
                    var elementoDestino = lista.FirstOrDefault();

                    var nomeElementoOrigem = elementOrigem.Text;
                    var nomeElementoDestino = elementoDestino.Text;

                    elementoCapturado = lista.FirstOrDefault(e => e.Text.ToUpperInvariant() == nomeDoElemento.ToUpperInvariant());

                    if (elementoCapturado != null)
                    {
                        break;
                    }

                    Thread.Sleep(1000);
                    TouchAction touchAction = new TouchAction(driver);

                    touchAction
                    .Press(elementOrigem.Location.X, elementOrigem.Location.Y)
                    .Wait(1000)
                    .MoveTo(elementoDestino.Location.X, elementoDestino.Location.Y)
                    .Release()
                    .Perform();

                    lista = driver.FindElementsById(seletorIdDoElemento);
                    elementOrigem = lista.LastOrDefault();
                    elementoDestino = lista.FirstOrDefault();

                    var nomeNovoElementoOrigem = elementOrigem.Text;
                    var nomeNovoElementoDestino = elementoDestino.Text;

                    if (nomeElementoOrigem == nomeNovoElementoOrigem && nomeElementoDestino == nomeNovoElementoDestino)
                    {
                        break;
                    }
                }
                return elementoCapturado;
            }

            //Nesse else o método captura o elemento da lista pela seletor Class
            else if (seletorClassDoElemento != null)
            {
                IWebElement elementoCapturado = null;
                WebDriverWait espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                while (seletorClassDoElemento == null)
                {
                    Thread.Sleep(2000);
                    var lista = driver.FindElementsByClassName(seletorIdDoElemento);
                    var elementOrigem = lista.LastOrDefault();
                    var elementoDestino = lista.FirstOrDefault();

                    var nomeElementoOrigem = elementOrigem.Text;
                    var nomeElementoDestino = elementoDestino.Text;

                    elementoCapturado = lista.FirstOrDefault(e => e.Text.ToUpperInvariant() == nomeDoElemento.ToUpperInvariant());

                    if (elementoCapturado != null)
                    {
                        break;
                    }

                    Thread.Sleep(1000);
                    TouchAction touchAction = new TouchAction(driver);

                    touchAction
                    .Press(elementOrigem.Location.X, elementOrigem.Location.Y)
                    .Wait(1000)
                    .MoveTo(elementoDestino.Location.X, elementoDestino.Location.Y)
                    .Release()
                    .Perform();

                    lista = driver.FindElementsById(seletorIdDoElemento);
                    elementOrigem = lista.LastOrDefault();
                    elementoDestino = lista.FirstOrDefault();

                    var nomeNovoElementoOrigem = elementOrigem.Text;
                    var nomeNovoElementoDestino = elementoDestino.Text;

                    if (nomeElementoOrigem == nomeNovoElementoOrigem && nomeElementoDestino == nomeNovoElementoDestino)
                    {
                        break;
                    }
                }
                return elementoCapturado;
            }

            else
            {
                return null;
            }
        }

        //Esse método adiciona um ativo há planilha de cotação selecionada
        public void AddAtivoNaPlanilhaCotacaoAtual(AppiumDriver<AndroidElement> driver, string nomeAtivo)
        {
            WebDriverWait espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement campoPesquisaAtivo = driver.FindElementById("br.com.cedrotech.fastmobile.dev:id/autocompleteQuotation");

            espera.Until(ExpectedConditions.ElementToBeClickable(campoPesquisaAtivo));
            campoPesquisaAtivo.SendKeys(nomeAtivo);

            IWebElement elementoCapturado = CapturaElementoDaLista(driver, nomeAtivo, "br.com.cedrotech.fastmobile.dev:id/titleQuote");

            int posicaoXBtnAdicionarAtivo = 816 + elementoCapturado.Location.X;
            int posicaoYBtnAdicionarAtivo = 29 + elementoCapturado.Location.Y;

            Thread.Sleep(2000);
            driver.Tap(1, posicaoXBtnAdicionarAtivo, posicaoYBtnAdicionarAtivo, 2);

            IWebElement btnAdicionaAtivoDaLista = driver.FindElementById("br.com.cedrotech.fastmobile.dev:id/floatingActionButtonAddQuote");

            espera.Until(ExpectedConditions.ElementToBeClickable(btnAdicionaAtivoDaLista));
            btnAdicionaAtivoDaLista.Click();
        }

        public void HabilitaExclusaoAtivosDaPlanilha(AppiumDriver<AndroidElement> driver, IWebElement elemento)
        {
            TouchAction touchAction = new TouchAction(driver);
            touchAction
            .Press(elemento.Location.X + 400, elemento.Location.Y)
            .Wait(2000)
            .MoveTo(elemento.Location.X, elemento.Location.Y)
            .Release()
            .Perform();
        }

        public void HabilitaRenomearExcluirPlanilha(AppiumDriver<AndroidElement> driver, IWebElement elemento)
        {
            TouchAction touchAction = new TouchAction(driver);
            touchAction
            .Press(elemento.Location.X + 300, elemento.Location.Y)
            .Wait(2000)
            .MoveTo(100, elemento.Location.Y)
            .Release()
            .Perform();
        }

        public IWebElement CapturaNoticiaDaLista(AppiumDriver<AndroidElement> driver, string tagDaNoticia, string seletorIdDoElemento = null, string seletorClassDoElemento = null, bool loop = false)
        {
            int contador = 0;
            int breakLoopNoticias = 20;

            //Nesse else o método captura o elemento da lista pela seletor Id
            if (seletorIdDoElemento != null)
            {
                IWebElement elementoCapturado = null;
                WebDriverWait espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                while (elementoCapturado == null)
                {
                    Thread.Sleep(2000);
                    var lista = driver.FindElementsById(seletorIdDoElemento);
                    var elementOrigem = lista.LastOrDefault();
                    var elementoDestino = lista.FirstOrDefault();

                    var nomeElementoOrigem = elementOrigem.Text;
                    var nomeElementoDestino = elementoDestino.Text;

                    elementoCapturado = lista.FirstOrDefault(e => e.Text.ToUpperInvariant().Contains(tagDaNoticia.ToUpperInvariant()));

                    if (elementoCapturado != null)
                    {
                        break;
                    }

                    Thread.Sleep(1000);
                    TouchAction touchAction = new TouchAction(driver);

                    touchAction
                    .Press(elementOrigem.Location.X, elementOrigem.Location.Y)
                    .Wait(1000)
                    .MoveTo(elementoDestino.Location.X, elementoDestino.Location.Y)
                    .Release()
                    .Perform();

                    lista = driver.FindElementsById(seletorIdDoElemento);
                    elementOrigem = lista.LastOrDefault();
                    elementoDestino = lista.FirstOrDefault();

                    var nomeNovoElementoOrigem = elementOrigem.Text;
                    var nomeNovoElementoDestino = elementoDestino.Text;

                    if (nomeElementoOrigem == nomeNovoElementoOrigem && nomeElementoDestino == nomeNovoElementoDestino)
                    {
                        break;
                    }

                    if(contador == breakLoopNoticias && loop == true)
                    {
                        break;
                    }

                    contador++;
                }
                return elementoCapturado;
            }

            //Nesse else o método captura o elemento da lista pela seletor Class
            else if (seletorClassDoElemento != null)
            {
                IWebElement elementoCapturado = null;
                WebDriverWait espera = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

                while (seletorClassDoElemento == null)
                {
                    Thread.Sleep(2000);
                    var lista = driver.FindElementsByClassName(seletorIdDoElemento);
                    var elementOrigem = lista.LastOrDefault();
                    var elementoDestino = lista.FirstOrDefault();

                    var nomeElementoOrigem = elementOrigem.Text;
                    var nomeElementoDestino = elementoDestino.Text;

                    elementoCapturado = lista.FirstOrDefault(e => e.Text.ToUpperInvariant() == tagDaNoticia.ToUpperInvariant());

                    if (elementoCapturado != null)
                    {
                        break;
                    }

                    Thread.Sleep(1000);
                    TouchAction touchAction = new TouchAction(driver);

                    touchAction
                    .Press(elementOrigem.Location.X, elementOrigem.Location.Y)
                    .Wait(1000)
                    .MoveTo(elementoDestino.Location.X, elementoDestino.Location.Y)
                    .Release()
                    .Perform();

                    lista = driver.FindElementsById(seletorIdDoElemento);
                    elementOrigem = lista.LastOrDefault();
                    elementoDestino = lista.FirstOrDefault();

                    var nomeNovoElementoOrigem = elementOrigem.Text;
                    var nomeNovoElementoDestino = elementoDestino.Text;

                    if (nomeElementoOrigem == nomeNovoElementoOrigem && nomeElementoDestino == nomeNovoElementoDestino)
                    {
                        break;
                    }

                    if (contador == breakLoopNoticias && loop == true)
                    {
                        break;
                    }

                    contador++;
                }
                return elementoCapturado;
            }

            else
            {
                return null;
            }
        }
    }
}

