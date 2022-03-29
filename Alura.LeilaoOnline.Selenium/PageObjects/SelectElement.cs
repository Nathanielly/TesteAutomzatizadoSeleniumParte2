using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.Selenium.PageObjects
{
    internal class SelectElement
    {
        private IWebElement selectElement;

        public SelectElement(IWebElement selectElement)
        {
            this.selectElement = selectElement;
        }

        public IEnumerable<object> Options { get; internal set; }

        internal void SelectByText(string v)
        {
            throw new NotImplementedException();
        }
    }
}