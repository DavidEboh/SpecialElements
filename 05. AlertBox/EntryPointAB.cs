using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


class EntryPointAB
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert; //nothing to inspect
    static IWebElement image;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();

        Console.WriteLine(alert.Text); //Outout the text in the console

        alert.Accept(); //Clicks okay to the alert box

        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));

        //if something goes wrong and the alert can't be accepted
        //get exception with the try catch block
        try
        {


            if (image.Displayed)
            {
                Console.WriteLine("The alert was succesfully accepted. Image seen");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Something went wrong");
        }


        Thread.Sleep(3000);


        driver.Quit();
    }
}

