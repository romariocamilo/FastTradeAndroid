using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastTradeAndroid
{
    class MetodosComuns : AmbienteConfig
    {
        public void LongPressPosicoesFixas(AppiumDriver<AndroidElement> driver, int posicaoOrigemX = 0, int posicaoOrigemY = 0, int posicaoDestinoX = 0, int posicaoDestinoY = 0)
        {
            TouchAction touchAction = new TouchAction(driver);
            touchAction
            .Press(posicaoOrigemX, posicaoOrigemY)
            .Wait(1000)
            .MoveTo(posicaoDestinoX, posicaoDestinoY)
            .Release()
            .Perform();
        }

        public void LongPressPorElemento(AppiumDriver<AndroidElement> driver, IWebElement elemento, bool eixoX, bool positivo, int quantidade)
        {
            TouchAction touchAction = new TouchAction(driver);

            if (eixoX)
            {
                if (positivo)
                {
                    touchAction
                   .Press(elemento)
                   .Wait(1000)
                   .MoveTo(elemento.Location.X + quantidade, elemento.Location.Y)
                   .Release()
                   .Perform();
                }
                else
                {
                    touchAction
                   .Press(elemento)
                   .Wait(1000)
                   .MoveTo(elemento.Location.X - quantidade, elemento.Location.Y)
                   .Release()
                   .Perform();
                }
            }
            else
            {
                if (positivo)
                {
                    touchAction
                   .Press(elemento)
                   .Wait(1000)
                   .MoveTo(elemento.Location.X, elemento.Location.Y + quantidade)
                   .Release()
                   .Perform();
                }
                else
                {
                    touchAction
                   .Press(elemento)
                   .Wait(1000)
                   .MoveTo(elemento.Location.X, elemento.Location.Y - quantidade)
                   .Release()
                   .Perform();
                }
            }
        }

        #region MétodoLongPressAnderson
        //public void LongPressFrameAtual(AppiumDriver<AndroidElement> driver, IWebElement elemento, int posicaoDestinoX = 0, int posicaoDestinoY = 0, ScrollDirection directionScroll = ScrollDirection.Horizontal, bool destinoPositivo = true)
        //{
        //    ///todo refinar metodo

        //    TouchAction touchAction = new TouchAction(driver);
        //    switch (directionScroll)
        //    {
        //        case ScrollDirection.Horizontal:
        //            if (destinoPositivo)
        //            {
        //                touchAction
        //                .Press(elemento)
        //                .Wait(1000)
        //                .MoveTo(elemento.Location.X + posicaoDestinoX, elemento.Location.Y)
        //                .Release()
        //                .Perform();
        //            }
        //            else
        //            {
        //                touchAction
        //                .Press(elemento)
        //                .Wait(1000)
        //                .MoveTo(elemento.Location.X - posicaoDestinoX, elemento.Location.Y)
        //                .Release()
        //                .Perform();
        //            }
        //            break;
        //        case ScrollDirection.Vertical:
        //            if (destinoPositivo)
        //            {
        //                touchAction
        //                .Press(elemento)
        //                .Wait(1000)
        //                .MoveTo(elemento.Location.X, elemento.Location.Y + posicaoDestinoY)
        //                .Release()
        //                .Perform();
        //            }
        //            else
        //            {
        //                touchAction
        //                .Press(elemento)
        //                .Wait(1000)
        //                .MoveTo(elemento.Location.X, elemento.Location.Y - posicaoDestinoY)
        //                .Release()
        //                .Perform();
        //            }
        //            break;
        //    }
        //}
        #endregion
    }
}

