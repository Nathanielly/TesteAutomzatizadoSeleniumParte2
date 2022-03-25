﻿using OpenQA.Selenium;
using System;
using System.Threading;
using Xunit;
using OpenQA.Selenium.Support.UI;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
   
    public class NovoLeilaoPO
    {
        private IWebDriver driver;

        //estratégia de localização dos campos
        private By byInputTitulo;
        private By byInputDescricao;
        private By byInputCategoria;
        private By byInputValorInicial;
        private By byInputImagem;
        private By byInputInicioPregao;
        private By byInputTerminoPregao;


        public NovoLeilaoPO(IWebDriver driver)
        {
            this.driver = driver;

            //inicializar as estrategias de localização
            byInputTitulo = By.Id("Titulo");
            byInputDescricao = By.Id("Descricao");
            byInputCategoria = By.XPath("/html/body/form/div/div[1]/div/div[1]/div[3]/div[1]/div/ul/li[2]");
            byInputValorInicial = By.Id("ValorInicial");
            byInputImagem = By.Id("ArquivoImagem");
            byInputInicioPregao = By.Id("InicioPregao");
            byInputTerminoPregao = By.Id("TerminoPregao");

           
        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Leiloes/Novo");
        }

        public void PreencherFormulario(string titulo, string descricao, decimal valor, string imagem, DateTime inicioPregao, DateTime terminoPregao)
        {
            driver.FindElement(byInputTitulo).SendKeys(titulo);
            driver.FindElement(byInputDescricao).SendKeys(descricao);
            driver.FindElement(By.ClassName("select-wrapper")).Click();
            Thread.Sleep(1000);
            driver.FindElement(byInputCategoria).Click();
            driver.FindElement(byInputValorInicial).SendKeys(Convert.ToString(valor));
            driver.FindElement(byInputImagem).SendKeys(imagem);
            driver.FindElement(byInputInicioPregao).SendKeys(Convert.ToString(inicioPregao));
            driver.FindElement(byInputTerminoPregao).SendKeys(Convert.ToString(terminoPregao));

           
        }


    }
}