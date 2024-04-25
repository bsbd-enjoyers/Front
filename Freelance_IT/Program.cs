using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Freelance_IT;
using Freelance_IT.Classes;

namespace Freelance_IT
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var back_client = new Network.BackendClient();

            //var hello = client.checkLoginFree("shit");

            var client = new Client();
            client.login = "artem";
            client.email = "lol@kek.ru";
            client.phone = "88005553535";
            client.fullname = "artem sh";

/*            var register = back_client.registerClient(client, "300$");

            Console.WriteLine("####################");

            Console.WriteLine(register.Result);

            Console.WriteLine("####################");*/

            var check = back_client.checkLoginOccupied("artem");

            Console.WriteLine("####################");

            Console.WriteLine(check.Result);

            Console.WriteLine("####################");

            back_client.login("artem", "300$");

            Console.WriteLine("####################");


            var info = back_client.getMyInfo();

            Console.WriteLine("####################");

            Console.WriteLine(info.Result);

            Console.WriteLine("####################");
            //Application.Run(new AboutMeMasterForm());
            //Application.Run(new Forms.MainForm());
            //Application.Run(new ClientHandleOrderForm());
        }
    }
}
