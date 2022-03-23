using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    public class DashboardInteressadaPO
    {
        private IWebDriver driver;
        private By byLogoutLink;
        private By byMeuPerfilLink;


        public DashboardInteressadaPO(IWebDriver driver)
        {
            this.driver = driver;
            byLogoutLink = By.Id("logout");
            byMeuPerfilLink = By.Id("meu-perfil");
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
