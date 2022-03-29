using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class DashboardInteressadaPO
    {
        private IWebDriver driver;
        private By byLogoutLink;
        private By byMeuPerfilLink;
        private By bySelectCategorias;
        private By byInputTermo;
        private By byInputAndamento;
        private By byBotaoPesquisar;


        public DashboardInteressadaPO(IWebDriver driver)
        {
            this.driver = driver;
            byLogoutLink = By.Id("logout");
            byMeuPerfilLink = By.Id("meu-perfil");
            bySelectCategorias = By.ClassName("select-wrapper");
            //byInputTermo = By.;
            //byInputAndamento = By.;
            //byBotaoPesquisar = By.;


         }

        public void PesquisarLeiloes(List<string> categorias)
        {
            var selectWrapper = driver.FindElement(bySelectCategorias);
            selectWrapper.Click();

            Thread.Sleep(2000);

            var opcoes = selectWrapper.FindElements(By.CssSelector("li>span")).ToList();

            opcoes.ForEach(o =>
            {
                o.Click();
            });

            Thread.Sleep(2000);

            categorias.ForEach(categoria => 
            {
                opcoes 
                 .Where(o => o.Text.Contains(categoria))
                 .ToList()
                 .ForEach(o =>
                 {
                     o.Click();
                 });
               
            });

            selectWrapper.FindElement(By.TagName("li")).SendKeys(Keys.Tab);

            Thread.Sleep(8000);

        }

        public void EfetuarLogout()
        {
            var linkMeuperfil = driver.FindElement(byMeuPerfilLink);
            var linkLogout = driver.FindElement(byLogoutLink);

            IAction acaoLogout = new Actions(driver)
            //mover para o elemento pai(meu-perfil)
            .MoveToElement(linkMeuperfil)
            //mover para o link de logout
            .MoveToElement(linkLogout)
            //clicar no link de logout
            .Click()
            .Build();

            //executar a acao
            acaoLogout.Perform();

        }
    }
}
