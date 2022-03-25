using OpenQA.Selenium;
using System;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    internal class SelectElement
    {
        private IWebElement selectElement;

        public SelectElement(IWebElement selectElement)
        {
            this.selectElement = selectElement;
        }

        internal void SelectByText(string v)
        {
            throw new NotImplementedException();
        }
    }
}