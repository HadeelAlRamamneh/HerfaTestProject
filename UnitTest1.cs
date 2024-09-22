using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void TestSuccessRegister()
        //{
        //    //    IWebDriver driver = new ChromeDriver();//instance webdriver
        //    //    driver.Manage().Window.Maximize();//open chrom 
        //    //    driver.Navigate().GoToUrl("https://localhost:44349/Auth/RegisterUser"); //navigate to spacific page 
        //    //    Thread.Sleep(10000);//sloly water after in melesecond be run 
        //    //    driver.Quit();//close chrom 

        //    //instance webdriver
        //     IWebDriver driver = new ChromeDriver();
        //    //open chrom 
        //    driver.Manage().Window.Maximize();
        //    //navigate url
        //    driver.Navigate().GoToUrl("https://localhost:44349/Auth/RegisterUser");
        //    //Locate a web element on the webpage via locators in selenium
        //    By firstname = By.XPath("//div/input[@id='Fname']");
        //    By Lastname = By.XPath("//div/input[@id='Lname']");
        //    By male = By.XPath("//div/input[@value='M']");
        //    By Female = By.XPath("//div/input[@value='F']");
        //    By birthdate = By.XPath("//div/input[@id='Dateofbirth']");
        //    By phonenumber = By.XPath("//div/input[@name='Phonenumber']");
        //    By email = By.XPath("//div/input[@name='Email']");
        //    By image = By.XPath("//div/input[@name='ImageFileUser']");
        //    By password = By.XPath("//div/input[@id='myPass']");
        //    By confirmPassword = By.XPath("//div/input[@id='myPass2']");
        //    By SubmitButton = By.XPath("//div/button[@type='submit']");

        //    Thread.Sleep(5000);
        //    //Perform one or more user actions on the element.
        //    driver.FindElement(firstname).SendKeys("Hadeel");
        //    driver.FindElement(Lastname).SendKeys("Mohammad");
        //    driver.FindElement(Female).Click();
        //    driver.FindElement(birthdate).SendKeys("30-11-2001");
        //    driver.FindElement(phonenumber).SendKeys("07935373423");
        //    driver.FindElement(email).SendKeys("Hadeel@gmail.com");
        //    driver.FindElement(image).SendKeys("D:\\picture\\hadeel.jpg");
        //    driver.FindElement(password).SendKeys("123456");
        //    driver.FindElement(confirmPassword).SendKeys("123456");
        //    driver.FindElement(SubmitButton).Click();
        //    Thread.Sleep(2000);
        //    //Preload the expected output/browser response to the action
        //    var expectedURL = "https://localhost:44349/Auth/Login";
        //    var actualURL = driver.Url;
        //    Assert.AreEqual(expectedURL, actualURL, "Actual URL not equal the expected URL");
        //    Console.WriteLine("Test Completed Successfully");
        //    driver.Quit();

        //[TestMethod]
        //public void TestFailedRegister_invalidEmail()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl("https://localhost:44349/Auth/RegisterUser");
        //    By firstName = By.XPath("//div/input[@id='Fname']");
        //    By lastName = By.XPath("//div/input[@id='Lname']");
        //    By male = By.XPath("//div/input[@value='M']");
        //    By Female = By.XPath("//div/input[@value='F']");
        //    By birthdate = By.XPath("//div/input[@id='Dateofbirth']");
        //    By phonenumber = By.XPath("//div/input[@name='Phonenumber']");
        //    By email = By.XPath("//div/input[@name='Email']");
        //    By image = By.XPath("//div/input[@name='ImageFileUser']");
        //    By password = By.XPath("//div/input[@id='myPass']");
        //    By confirmPassword = By.XPath("//div/input[@id='myPass2']");
        //    By SubmitButton = By.XPath("//div/button[@type='submit']");
        //    Thread.Sleep(5000);
        //    driver.FindElement(firstName).SendKeys("Raghad");
        //    driver.FindElement(lastName).SendKeys("Mohammad");
        //    driver.FindElement(Female).Click();
        //    driver.FindElement(birthdate).SendKeys("03-03-2000");
        //    driver.FindElement(phonenumber).SendKeys("07935373423");
        //    driver.FindElement(email).SendKeys("Raghad1gmail.com");
        //    driver.FindElement(image).SendKeys("C:\\Users\\b.alhassoun.ext\\Downloads\\blob.jpg");
        //    driver.FindElement(password).SendKeys("123456");
        //    driver.FindElement(confirmPassword).SendKeys("123456");
        //    driver.FindElement(SubmitButton).Click();
        //    Thread.Sleep(2000);
        //    var expectedURL = "https://localhost:44349/Auth/RegisterUser";
        //    var actualURL = driver.Url;
        //    Assert.AreEqual(expectedURL, actualURL, "Actual URL not equal the expected URL");
        //    Console.WriteLine("Test Completed Successfully");
        //    driver.Quit();
        //}


        //day2
        //the first inhancment of the code  add try and catch 
        //[TestMethod]
        //public void TestSuccessRegister()
        //{
        //    IWebDriver driver = new ChromeDriver();
        //    try
        //    {
        //        //instance webdriver

        //        //open chrom 
        //        driver.Manage().Window.Maximize();
        //        //navigate url
        //        driver.Navigate().GoToUrl("https://localhost:44349/Auth/RegisterUser");
        //        //Locate a web element on the webpage via locators in selenium
        //        By firstname = By.XPath("//div/input[@id='Fname']");
        //        By Lastname = By.XPath("//div/input[@id='Lname']");
        //        By male = By.XPath("//div/input[@value='M']");
        //        By Female = By.XPath("//div/input[@value='F']");
        //        By birthdate = By.XPath("//div/input[@id='Dateofbirth']");
        //        By phonenumber = By.XPath("//div/input[@name='Phonenumber']");
        //        By email = By.XPath("//div/input[@name='Email']");
        //        By image = By.XPath("//div/input[@name='ImageFileUser']");
        //        By password = By.XPath("//div/input[@id='myPass']");
        //        By confirmPassword = By.XPath("//div/input[@id='myPass2']");
        //        By SubmitButton = By.XPath("//div/button[@type='submit']");

        //        Thread.Sleep(5000);
        //        //Perform one or more user actions on the element.
        //        driver.FindElement(firstname).SendKeys("Hadeel");
        //        driver.FindElement(Lastname).SendKeys("Mohammad");
        //        driver.FindElement(Female).Click();
        //        driver.FindElement(birthdate).SendKeys("30-11-2001");
        //        driver.FindElement(phonenumber).SendKeys("07935373423");
        //        driver.FindElement(email).SendKeys("Hadeel@gmail.com");
        //        driver.FindElement(image).SendKeys("D:\\picture\\hadeel.jpg");
        //        driver.FindElement(password).SendKeys("123456");
        //        driver.FindElement(confirmPassword).SendKeys("123456");
        //        driver.FindElement(SubmitButton).Click();
        //        Thread.Sleep(2000);
        //        //Preload the expected output/browser response to the action
        //        var expectedURL = "https://localhost:44349/Auth/Login";
        //        var actualURL = driver.Url;
        //        Assert.AreEqual(expectedURL, actualURL, "Actual URL not equal the expected URL");
        //        Console.WriteLine("Test Completed Successfully");
        //    }
        //    catch (Exception ex)
        //    {

        //        driver.Quit();
        //    }
        //    finally
        //    {
        //        driver.Quit();
        //    }


        //}










































    }
}