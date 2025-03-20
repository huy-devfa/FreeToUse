using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

public class BrowserHelper
{
    public IWebDriver driver;

    public BrowserHelper()
    {
        var options = new ChromeOptions();
        options.AddArgument("--start-maximized");  // Mở toàn màn hình
        options.AddArgument("--disable-notifications");  // Tắt thông báo popup
        options.AddArgument("--disable-blink-features=AutomationControlled"); // Giảm khả năng bị phát hiện

        driver = new ChromeDriver(options);
    }

    public void OpenUrl(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    public void LoginHotmail(string email, string password)
    {
        driver.Navigate().GoToUrl("https://outlook.live.com/owa/");
        Thread.Sleep(3000); // Đợi trang tải

        driver.FindElement(By.XPath("//*[@id=\"c-shellmenu_custom_outline_newtab_signin_bhvr100_right\"],'Sign in')]")).Click(); // Nhấn nút "Sign in"
        Thread.Sleep(2000);

        driver.FindElement(By.Name("loginfmt")).SendKeys(email); // Nhập email
        driver.FindElement(By.Id("idSIButton9")).Click(); // Nhấn nút tiếp theo
        Thread.Sleep(2000);

        driver.FindElement(By.Name("passwd")).SendKeys(password); // Nhập mật khẩu
        driver.FindElement(By.Id("idSIButton9")).Click(); // Nhấn nút đăng nhập
        Thread.Sleep(3000);

        try
        {
            driver.FindElement(By.Id("idSIButton9")).Click(); // Nếu có nút "Yes" lưu đăng nhập, nhấn Yes
        }
        catch { }

        Console.WriteLine("✅ Đăng nhập Hotmail thành công!");
    }

    public void CloseBrowser()
    {
        driver.Quit();
    }
}
