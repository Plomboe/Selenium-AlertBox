using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    
    //Can't use IWebElement, since it isn't an element. Can't find from "inspect element"
    static IAlert alert;
    
    /* To see if you actually selected the textbox, select an element you can ONLY see after
       the textbox has been clicked on */
    static IWebElement image;


    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        //This takes the text out of the alert box, to display the textbox text 
        Console.WriteLine(alert.Text);

        alert.Accept();

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("The alert was successfuly accepted and I can see the image!");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Something went wrong!!");
        }

        Thread.Sleep(3000);

        driver.Quit();

    }
}

