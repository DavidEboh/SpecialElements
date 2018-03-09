using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPointCB
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "1";

        driver.Navigate().GoToUrl(url);
        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));
        // This selector will change to match the proper element used in Line 13

        /*
        if (checkBox.GetAttribute("checked") == "true") //Checks to see if the checkBox is checked
        // Will either return true or nothing at all
        {
            Console.WriteLine("The Check Box is checked"); //Checked
        }   
        else
        {
            Console.WriteLine("The Check Box is not checked"); //Not Checked
        }
        */

        Console.WriteLine(checkBox.GetAttribute("value"));

        option = "3";
        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));
        Console.WriteLine(checkBox.GetAttribute("value"));

        checkBox.Click();

        Thread.Sleep(5000);

        driver.Quit();



    }

}

