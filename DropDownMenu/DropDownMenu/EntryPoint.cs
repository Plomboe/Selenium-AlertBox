
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropDownMenu;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        //Gets current value selected by drop down menu
        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        //Find the third element
        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElement));

        //Finds the value of the third element, and displays it
        Console.WriteLine("The third option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));

        //Click on the third option
        elementFromTheDropDownMenu.Click();

        //Display the clicked third option
        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));
        Thread.Sleep(3000);

        //This gets you all values from the drop down menu (4 items)
        for (int i = 1; i<=4; i++)
        {
            dropDownMenuElement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElement));

            Console.WriteLine("The " + i + " option from the drop down menu is " + elementFromTheDropDownMenu.GetAttribute("value"));
        }
        Thread.Sleep(15000);

        driver.Quit();
    }
}

