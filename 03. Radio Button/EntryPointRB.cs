using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



class EntryPointRB
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement radioButton;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string[] option = { "1", "3", "5" }; //An array of strings to hold the numbers for the elements(options for radio buttons)

        driver.Navigate().GoToUrl(url);
        for (int i = 0; i < option.Length; i++) //Take the 1st element & check if it's checked, and so on
        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(" + option[i] + ")"));

            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The " + (i+1) + " radio button is checked");
            }
            else
            {
                Console.WriteLine("This radio button is unchecked");
            };
        }


        driver.Quit();
    }



}

