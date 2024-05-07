﻿using System;
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

            //var Order = Forms.ClientCreateOrderForm.createOrder();

            Application.Run(new Forms.MainForm());
        }
    }
}
