using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using static System.Net.Mime.MediaTypeNames;



namespace TestAutomation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Set up ChromeDriver
            using (IWebDriver driver = new ChromeDriver())
            {
                // Navigate to a website
                driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

                // Maximize the browser window
                driver.Manage().Window.Maximize();

                var checkBox = driver.FindElement(By.XPath("//table[@id='productTable']/tbody/tr[2]"));

                var pt = driver.FindElement(By.XPath("//table[@id='productTable']"));

                var table = driver.FindElement(By.XPath("//table[@id='productTable']"));

                var rowncol = table.FindElements(By.XPath(".//tbody/tr"));
                var checkboxes = new List<IWebElement>();

                var cbSunday = table.FindElement(By.XPath("//label[normalize-space()='Sunday']"));
                
                if(!cbSunday.Selected)
                {

                    cbSunday.Click();
                }
                Thread.Sleep(10000);

                var simpleAlert = driver.FindElement(By.XPath("(//button[normalize-space()='Simple Alert'])[1]"));

                simpleAlert.Click();

                // Switch to the alert
                IAlert alert = driver.SwitchTo().Alert();

                // Get alert text (optional)
                string alertText = alert.Text;
                Console.WriteLine("Alert text: " + alertText);

                // Accept the alert (click "OK")
                alert.Accept();


                var pg2 = driver.FindElement(By.XPath("//a[normalize-space()='2']"));
                pg2.Click();

                Thread.Sleep(10000);

                var doubleclick = driver.FindElement(By.XPath("//button[normalize-space()='Copy Text']"));

                // Create an instance of the Actions class
                Actions actions = new Actions(driver);

                // Perform the double-click action on the button
                actions.DoubleClick(doubleclick).Perform();

                Thread.Sleep(10000);

                var sortedlist = driver.FindElements(By.XPath("//select[@id='animals']"));

                // Extract texts from the elements into a list
                List<string> textList = new List<string>();
                foreach (IWebElement element in sortedlist)
                {
                    textList.Add(element.Text);
                }
                // Display the extracted texts
                Console.WriteLine("Extracted texts:");
                foreach (var text in textList)
                {
                    Console.WriteLine(text);
                }

                // Create a sorted copy of the list
                List<string> sortedList = new List<string>(textList);
                sortedList.Sort();

                // Check if the original list is sorted
                bool isSorted = textList.SequenceEqual(sortedList);

                // Output the result
                if (isSorted)
                {
                    Console.Write("The texts are sorted.");
                }
                else
                {
                    Console.Write("The texts are not sorted.");
                }


                // Locate the elements for drag and drop
                var sourceElement = driver.FindElement(By.XPath("//p[normalize-space()='Drag me to my target']")); // Replace with your source selector
                var targetElement = driver.FindElement(By.XPath("//div[@id='droppable']")); // Replace with your target selector


                // Perform the drag and drop action
                actions.DragAndDrop(sourceElement, targetElement).Perform();
                Thread.Sleep(10000);
                /*
                foreach (var row in rowncol)
            {
                var checkbox = row.FindElement(By.XPath(".//input[@type='checkbox']"));
                checkboxes.Add(checkbox);
                */
                //var cells = row.FindElements(By.TagName("td"));

                //var cb = row.FindElement(By.CssSelector("input.rowCheckbox"));

                //foreach (var cell in cells)
                //{
                //

                //      if (cb.Selected)
                //    {
                //      Console.Write("Yes Its CHecked");
                //}
                //}

                /*int count = 0;
                foreach (var checkbox in checkboxes)
                {
                    count++;
                    if (count == 2)
                    {
                        checkBox.Click();

                        Console.Write("Yes Its Checked");
                        break;
                    }
                }
                Thread.Sleep(10000);
                checkboxes.Clear();

                foreach (var row in rowncol)
                {
                    var checkbox = row.FindElement(By.XPath(".//input[@type='checkbox']"));
                    checkboxes.Add(checkbox);

                    //var cells = row.FindElements(By.TagName("td"));

                    //var cb = row.FindElement(By.CssSelector("input.rowCheckbox"));

                    //foreach (var cell in cells)
                    //{
                    //

                    //      if (cb.Selected)
                    //    {
                    //      Console.Write("Yes Its CHecked");
                    //}
                    //}
                }

                foreach (var checkbox in checkboxes)
                {
                    if (checkbox.Selected)
                    {
                        Console.Write("Yes Its CHecked");
                    }
                }
                */
                var country = driver.FindElement(By.XPath("//select[@id='country']"));

                var selectElement = new SelectElement(country);

                var options = selectElement.Options;
                
                int itemCount = options.Count();

                Console.Write("ItemCount: " + itemCount);

                var table1 = driver.FindElement(By.XPath("//div[@id='HTML1']"));

                var rows = table1.FindElements(By.XPath(".//tbody/tr"));

                foreach (var row in rows)
                {
                    var cells = row.FindElements(By.TagName("td"));

                    foreach (var cell in cells)
                    {
                        Console.Write(cell.Text + " ");
                    }
                }
            }
        }
    }
}
