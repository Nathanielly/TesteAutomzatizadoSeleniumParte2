using Alura.LeilaoOnline.Selenium.Fixtures;
using Alura.LeilaoOnline.Selenium.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xunit;

namespace Alura.LeilaoOnline.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoCriarLeilao
    {
        private IWebDriver driver;

        public AoCriarLeilao(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoLoginAdminAndInformacoesValidasDeveCadastrarLeilao()
        {
            //arrange
            var loginPO = new LoginPO(driver);
            loginPO.Visitar();
            loginPO.PreencheFormulario("admin@example.org", "123");
            loginPO.SubmeteFormulario();

            var novoLeilaoPO = new NovoLeilaoPO(driver);
            novoLeilaoPO.Visitar();

            
            novoLeilaoPO.PreencherFormulario("Leilão de coleção 1",
                                             "Teste Nath",
                                              1000,
                                             "D:\\Nath\\C\\Users\\Pictures\\Sample Pictures\\Koala.jpg",
                                              DateTime.Now.AddDays(20),
                                              DateTime.Now.AddDays(30));

            Thread.Sleep(1000);

            //act
            novoLeilaoPO.SubmeterFormulario();

            //assert
            Assert.Contains("Leilões cadastrados no sistema", driver.PageSource);

            Thread.Sleep(1000);
        }



    }
}
