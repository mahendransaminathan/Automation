using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up ChromeDriver
            using (IWebDriver driver = new ChromeDriver())
            {
                // Navigate to a website
                driver.Navigate().GoToUrl("https://vbdace.com/");

                                // Maximize the browser window
                driver.Manage().Window.Maximize();

                IWebElement signin = driver.FindElement(By.XPath("(//a[normalize-space()='Sign In'])[1]"));
                signin.Click();

                IWebElement EmailId = driver.FindElement(By.XPath("(//input[@placeholder='Enter E-mail Id'])[1]"));

                // Enter text into the text box
                EmailId.SendKeys("mahendransaminathen@gmail.com");

                Thread.Sleep(5000); // Time in milliseconds
                IWebElement pwd = driver.FindElement(By.XPath("(//input[@placeholder='Enter password'])[1]"));

                // Enter text into the text box
                pwd.SendKeys("Saminathan1");

                Thread.Sleep(5000); // Time in milliseconds

                IWebElement login = driver.FindElement(By.XPath("(//button[normalize-space()='Login'])[1]"));
                login.Click();

                Thread.Sleep(5000); // Time in milliseconds

                // Select an option by visible text
                //selectElement.SelectByText("Idli Cooker"); // Replace with the option you want to select
                // Finding an element by ID and clicking it
                IWebElement element = driver.FindElement(By.XPath("(//h1[@class='product-title'][normalize-space()='Idly Cooker'])[1]"));
                element.Click();

                // Perform actions (like finding elements, clicking, etc.)
                Console.WriteLine("Page title is: " + driver.Title);

                Thread.Sleep(5000); // Time in milliseconds
                IWebElement element1 = driver.FindElement(By.XPath("(//button[normalize-space()='Add to Cart'])[1]"));
                element1.Click();

                


                Thread.Sleep(5000); // Time in milliseconds
                IWebElement Cart = driver.FindElement(By.XPath("(//a[@href='/cart'])[1]"));
                Cart.Click();

                Thread.Sleep(5000); // Time in milliseconds

                IWebElement co = driver.FindElement(By.XPath("(//button[normalize-space()='Proceed to checkout'])[1]"));
                co.Click();

                Thread.Sleep(5000); // Time in milliseconds

                IWebElement Pay = driver.FindElement(By.XPath("(//button[@id='checkout-pay-button'])[1]"));
                Pay.Click();

                IWebElement name = driver.FindElement(By.XPath("(//p[@id='error-for-TextField1'])[1]"));

                string fieldText = name.Text;
                // Get the text from the field
                

                // Print the text to the console
                Console.WriteLine("Text in the field: " + fieldText);


                IWebElement Dace = driver.FindElement(By.XPath("(//img)[2]"));
                Dace.Click();

                Thread.Sleep(5000); // Time in milliseconds

                IWebElement ArrowRight = driver.FindElement(By.XPath("(//img[@alt='Arrow Right'])[1]"));
                ArrowRight.Click();

                Thread.Sleep(5000); // Time in milliseconds

                IWebElement Products = driver.FindElement(By.XPath("(//a[normalize-space()='Products'])[1]"));
                //Products.Click();

                // Create an Actions instance
                Actions actions = new Actions(driver);

                // Hover over the menu item
                actions.MoveToElement(Products).Perform();

                // Create a WebDriverWait instance
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                // Wait for the dropdown options to be visible
                //var options = wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("dropdown-item"))); // Change the selector

                // Click the desired option
                /*foreach (var option in options)
                {
                    if (option.Text.Equals("Tableware")) // Change to your desired item text
                    {
                        option.Click();
                        break;
                    }
                }*/
                // Select an item by visible text
                //dropdown.SelectByIndex(1); // Change to the visible text of the option you want to select


                IWebElement tw = driver.FindElement(By.XPath("(//a[normalize-space()='Tableware'])[1]"));
                tw.Click();

                Thread.Sleep(5000); // Time in milliseconds

                // Close the browser
                driver.Quit();
            }

        }
    }
}
