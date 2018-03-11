using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



class EntryPointDDM
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromTheDropDownMenu;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);


        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropMenuElements));

        Console.WriteLine("The third option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu.Click();

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));
        Thread.Sleep(4000);

        for (int i = 1; i <= 4; i++) //Takes all the values of the DDM and outputs them
        {
            dropMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child("+ i +")";
            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropMenuElements));

            Console.WriteLine("The "+ i +" option from the drop down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));
        }

        Thread.Sleep(10000);

        driver.Quit();
        
    }
}