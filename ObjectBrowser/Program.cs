﻿using System;
using System.Windows;
using UOInterface;

namespace ObjectBrowser
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MainWindow window = new MainWindow();

            Client.UnhandledException += (s, e) => MessageBox.Show(e.ExceptionObject.ToString(), "Unhandled exception!");
            Client.ServerIP = 0x0100007F;
            Client.ServerPort = 2593;
            Client.PatchEncryption = true;
            Client.Start("C:\\UO\\Test\\client.exe");
            window.Title = "ObjectBrowser - Client " + Client.Version;

            new Application().Run(window);
        }
    }
}