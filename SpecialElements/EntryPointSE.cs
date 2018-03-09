using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class EntryPointSE
{
    static IWebDriver driver = new ChromeDriver(); //driver needs to be made static
    static IWebElement textBox; 

    static void Main()
    {
        string url = "http://testing.todorvachev.com/special-elements/text-input-field/";

        driver.Navigate().GoToUrl(url);
        textBox = driver.FindElement(By.Name("username"));
        textBox.SendKeys("Test text"); //Sends specific string of text to Text Box

        Thread.Sleep(3000); //3 second pause
        //textBox.Clear(); // Clears Text Box
        Console.WriteLine(textBox.GetAttribute("value")); //Whatever is written in textbox will go under the attribute value
        Console.WriteLine(textBox.GetAttribute("maxlength")); //The maximum number of text allowed in the text box will be printed on the console
        Thread.Sleep(3000); //3 second pause

        driver.Quit();
    }
}