using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.App.src.Actions
{
    public class ClickElement
    {
        string chromeDrivePath = "";
        ChromeOptions chromeOptions = new ChromeOptions();
        //chromeOptions.AddArgument("--headless");
        string searchValue = "";

        public ClickElement(string value)
        {
            this.searchValue = value;
        }

        public ClickElement() { }

        public void Navigate()
        {

            using (ChromeDriver driver = new ChromeDriver(chromeDrivePath, chromeOptions))
            {

                string url = "https://www.google.com/";
                driver.Navigate().GoToUrl(url);

                IWebElement searchBox = driver.FindElement(By.Id("APjFqb"));
                searchBox.SendKeys(this.searchValue);

                System.Threading.Thread.Sleep(300);

                IWebElement element = driver.FindElement(By.Name("btnK"));
                element.Click();


                Console.WriteLine("Pressione alguma tecla para fechar o nvageador");
                Console.ReadKey();

                driver.Quit();
            }
        }

    }
}
