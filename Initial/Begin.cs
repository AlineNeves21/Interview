using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Interview.Initial
{
    public class Begin : GeneralMethods
    {        

        [SetUp]
        public void InicioTeste()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com.br/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        [TearDown]
        public void FimDoTeste()
        {
            driver.Quit();

        }
    }
}