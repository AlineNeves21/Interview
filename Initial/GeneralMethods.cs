using System;
using System.Text.RegularExpressions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Interview.Initial
{
    public class GeneralMethods : GlobalVariables
    {
        public void WriteText(string xpath, string value)
        {
            driver.FindElement(By.CssSelector(xpath)).SendKeys(value);
        }

        public void ClickElement(string xpath)
        {
            driver.FindElement(By.CssSelector(xpath)).Click();
        }

        public void ValidateData(string xpath, string value)
        {
            Assert.That(driver.FindElement(By.CssSelector(xpath)).Text, Does.Contain(value));
        }
    }
}
