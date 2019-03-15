using System;
using System.Collections.Generic;
using System.Text;
using Core.PageObject;
using OpenQA.Selenium;

namespace PageLibrary
{
    public class SideMenu : BaseComponent
    {
        public SideMenu(IWebDriver driver) : base(driver)
        {
            InitializeElements();
        }

        public WebElementProxy element1;

        void InitializeElements()
        {
            element1 = new WebElementProxy(driver, By.ClassName("blah"));
        }
    }
}
