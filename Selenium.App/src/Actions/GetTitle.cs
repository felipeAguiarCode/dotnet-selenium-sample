using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium.App.src.Actions
{
    public class GetTitle
    {
        string chromeDrivePath = "";
        ChromeOptions chromeOptions = new ChromeOptions();
        //chromeOptions.AddArgument("--headless");

        public void Navigate()
        {

            using (ChromeDriver driver = new ChromeDriver(chromeDrivePath, chromeOptions))
            {

                string url = "https://www.gran-turismo.com/br/";
                driver.Navigate().GoToUrl(url);

                string pageTitle = driver.Title;
                Console.WriteLine($"Titulo da página {pageTitle}");

                Console.WriteLine("Pressione alguma tecla para fechar o nvageador");
                Console.ReadKey();

                driver.Quit();
            }
        }

    }
}