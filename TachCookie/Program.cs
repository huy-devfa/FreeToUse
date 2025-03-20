using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TachCookie
{
    internal static class Program
    {



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            var browser = new BrowserHelper();

            // Nhập email + mật khẩu của Hotmail
            string hotmailEmail = "your_hotmail@example.com";
            string hotmailPassword = "your_password";

            browser.LoginHotmail(hotmailEmail, hotmailPassword);

            Console.WriteLine("Nhấn Enter để đóng trình duyệt...");
            Console.ReadLine();

            browser.CloseBrowser();
        }
    }
}
