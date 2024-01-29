using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace Automation_ML
{

    public class MercadoLibre
    {

        private IWebDriver driver;
  
        public MercadoLibre(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AbrirPaginaPrincipal()
        {
            driver.Navigate().GoToUrl("https://www.mercadolibre.com.uy/");
            driver.Manage().Window.Maximize();
        }

        public void BuscarProducto(string producto)
        {
            IWebElement searchInput =  driver.FindElement(By.CssSelector("[id=\"cb1-edit\"]"));
            searchInput.SendKeys(producto);
            searchInput.SendKeys(Keys.Enter);
        }

        public void SeleccionarProducto(string frase)
        {
            IWebElement targetProduct = null;

            foreach(IWebElement item in driver.FindElements(By.CssSelector(".ui-search-item__title")))
            {
                if(item.Text.ToLower().Contains(frase))
                {
                    targetProduct = item;
                    break;
                }
            }

            if(targetProduct != null)
            {
                Console.WriteLine("Producto con la frase: '" + targetProduct.Text + "' encontrado!!");
            }
            else
            {
                Console.WriteLine("Error: el producto con la frase: '" + targetProduct.Text +"' no fue encontrado");


            }




        }







    }
}
