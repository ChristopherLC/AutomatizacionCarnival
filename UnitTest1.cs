using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Inicializamos la instancia del driver de Selenium para el navegador Google Chrome
            using (IWebDriver wdriver = new ChromeDriver())
            {
                #region Inicio deL Navegador Chrome

                // Abrimos la página web de inicio se sesión
                wdriver.Navigate().GoToUrl("https://www.carnival.com/");
                Thread.Sleep(2000);
                // Maximizamos la ventana
                wdriver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                wdriver.Navigate().Refresh();
                Thread.Sleep(2000);

                #endregion

                #region Seleccionar y Buscar Viaje

                //Da un Clic en el botón Sail To
                IWebElement cmbSailtTo = wdriver.FindElement(By.Id("cdc-destinations"));
                Thread.Sleep(4000);
                HighlightElementInAction(cmbSailtTo, wdriver);
                Thread.Sleep(4000);
                cmbSailtTo.Click();
                Thread.Sleep(4000);

                //Localiza los elementos de la lista Sail To
                IWebElement element = wdriver.FindElement(By.ClassName("cdc-filter-cols-wrapper"));
                HighlightElementInAction(element, wdriver);
                Thread.Sleep(2000);

                // Obtiene todos los elementos de tipo TagName li y selecciona la opción: The Bahamas
                IList<IWebElement> elements = element.FindElements(By.TagName("li"));
                foreach (IWebElement e in elements)
                {
                    System.Console.WriteLine(e.Text);
                    if (e.Text == "The Bahamas")
                    {
                        e.Click();
                    }

                }

                //Da clic en el botón Search Cruises
                IWebElement btnSearch = wdriver.FindElement(By.ClassName("cdc-filters-search-cta"));
                HighlightElementInAction(btnSearch, wdriver);
                Thread.Sleep(4000);
                btnSearch.Click();
                Thread.Sleep(4000);

                #endregion

                #region Desplegar listado de precios

                //Da un clic en el botón que despliega el listado de precios
                IWebElement btnPrecios = wdriver.FindElement(By.ClassName("vrgf-price-box__wrapper"));
                HighlightElementInAction(btnPrecios, wdriver);
                Thread.Sleep(4000);
                btnPrecios.Click();
                Thread.Sleep(4000);

                #endregion

                // Cierra el driver, y sus ventanas asociadas
                wdriver.Quit();
            }

        }

        [TestMethod]
        public void TestMethod2()
        {
            // Inicializamos la instancia del driver de Selenium para el navegador Google Chrome
            using (IWebDriver wdriver = new ChromeDriver())
            {

                #region Inicio deL Navegador Chrome

                // Abrimos la página web de inicio se sesión
                wdriver.Navigate().GoToUrl("https://www.carnival.com/");
                Thread.Sleep(2000);
                // Maximizamos la ventana
                wdriver.Manage().Window.Maximize();
                Thread.Sleep(2000);
                wdriver.Navigate().Refresh();
                Thread.Sleep(2000);

                #endregion

                #region Seleccionar y Buscar Viaje

                //Da un Clic en el botón Sail To
                IWebElement cmbSailtTo = wdriver.FindElement(By.Id("cdc-destinations"));
                Thread.Sleep(4000);
                HighlightElementInAction(cmbSailtTo, wdriver);
                Thread.Sleep(4000);
                cmbSailtTo.Click();
                Thread.Sleep(4000);

                //Localiza los elementos de la lista Sail To
                IWebElement element = wdriver.FindElement(By.ClassName("cdc-filter-cols-wrapper"));
                HighlightElementInAction(element, wdriver);
                Thread.Sleep(2000);

                // Obtiene todos los elementos de tipo TagName li y selecciona la opción: The Bahamas
                IList<IWebElement> elements = element.FindElements(By.TagName("li"));
                foreach (IWebElement e in elements)
                {
                    System.Console.WriteLine(e.Text);
                    if (e.Text == "The Bahamas")
                    {
                        e.Click();
                    }

                }

                //Da clic en el botón Search Cruises
                IWebElement btnSearch = wdriver.FindElement(By.ClassName("cdc-filters-search-cta"));
                HighlightElementInAction(btnSearch, wdriver);
                Thread.Sleep(4000);
                btnSearch.Click();
                Thread.Sleep(4000);

                #endregion                

                #region Seleccionar y Dar un clic en el primer cuadrante

                Thread.Sleep(2000);

                //Dar un clic en la etiqueta Carnival Freedom del primer cuadrante
                IWebElement itinerario = wdriver.FindElement(By.TagName("ccl-view-result-grid"));
                Thread.Sleep(2000);                
                IList<IWebElement> itinerarios = itinerario.FindElements(By.TagName("span"));   
                
                foreach (IWebElement i in itinerarios)
                {
                    System.Console.WriteLine(i.Text);
                    if (i.Text == "CARNIVAL FREEDOM")
                    {
                        i.Click();
                        break;
                    }
                    
                }
                Thread.Sleep(2000);
                #endregion

                #region Selecciona y Da clic en los botones de Learn More

                //Da clic en cada botón Learn More
                IWebElement learn = wdriver.FindElement(By.ClassName("daily-tiles"));
                Thread.Sleep(2000);
                IList<IWebElement> learnMore = learn.FindElements(By.ClassName("about-cta"));
                foreach (IWebElement u in learnMore)
                {
                    System.Console.WriteLine(u.Text);                    
                    if (u.FindElement(By.TagName("button")).Text == "Learn More")
                    {
                        u.Click();
                        Thread.Sleep(8000);                        
                    }                    
                }

                #endregion

                // Cierra el driver, y sus ventanas asociadas
                wdriver.Quit();
            }
                        
        }


        [TestMethod]
        public void TestMethod3()
        {
            // Inicializamos la instancia del driver de Selenium para el navegador Google Chrome
            using (IWebDriver wdriver = new ChromeDriver())
            {
                #region Inicio deL Navegador Chrome

                wdriver.Navigate().GoToUrl("https://www.carnival.com/cruise-search#?dest=bh&layout=grid&numAdults=2&pageNumber=1&pageSize=8&showBest=true&sort=fromprice&useSuggestions=true");
                Thread.Sleep(4000);
                // Maximizamos la ventana
                wdriver.Manage().Window.Maximize();
                Thread.Sleep(2000);

                #endregion

                #region Seleccionar y Dar un clic en el primer cuadrante

                Thread.Sleep(2000);

                //Dar un clic en la etiqueta Carnival Freedom del primer cuadrante
                IWebElement itinerario = wdriver.FindElement(By.TagName("ccl-view-result-grid"));
                Thread.Sleep(2000);


                IList<IWebElement> itinerarios = itinerario.FindElements(By.TagName("span"));

                foreach (IWebElement i in itinerarios)
                {
                    System.Console.WriteLine(i.Text);
                    if (i.Text == "CARNIVAL FREEDOM")
                    {
                        i.Click();
                        break;
                    }

                }
                Thread.Sleep(2000);

                #endregion

                #region Selecciona y Da clic en los botones de Learn More
                
                //Da clic en cada botón Learn More
                IWebElement learn = wdriver.FindElement(By.ClassName("daily-tiles"));
                Thread.Sleep(2000);                               
                
                IList<IWebElement> learnMore = learn.FindElements(By.ClassName("about-cta"));
                foreach (IWebElement u in learnMore)
                {
                    System.Console.WriteLine(u.Text);
                    if (u.FindElement(By.TagName("button")).Text == "Learn More")
                    {
                        u.Click();
                        Thread.Sleep(8000);
                    }
                } 
                #endregion

                // Cierra el driver, y sus ventanas asociadas
                wdriver.Quit();
            }


        }


        private IWebElement HighlightElementInAction(IWebElement element, IWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].style.border = '3px dotted blue'", element);
            return (element);
        }
    }
}
