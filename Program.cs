using System;
using System.Diagnostics;

namespace CreateME
{
    internal class CreateME
    {
        static void Main(string[] args)
        {
            string user;
            string pass;
            Thread animate = new Thread(AnimatedName);
            animate.Start();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
      ______                                   __                __       __  ________ 
     /      \                                 /  |              /  \     /  |/        |
    /$$$$$$  | ______    ______    ______   _$$ | _     ______  $$  \   /$$ |$$$$$$$$/
    $$ |  $$/  /      \  /      \  /      \ / $$   |   /      \ $$$  \ /$$$ |$$ | __    
    $$ |      /$$$$$$  |/$$$$$$  | $$$$$$  |$$$$$$/   /$$$$$$  |$$$$  /$$$$ |$$    |
    $$ | __ $$ |  $$/ $$    $$ | /    $$ |  $$ | __ $$    $$ |$$ $$ $$/$$ |$$$$$/
    $$ \__ /  |$$ |      $$$$$$$$/ /$$$$$$$ |  $$ |/  |$$$$$$$$/ $$ |$$$/ $$ |$$ | _____ 
    $$    $$/ $$ |      $$       |$$    $$ |  $$  $$/ $$       |$$ | $/  $$ |$$       |
     $$$$$$/  $$/        $$$$$$$/  $$$$$$$/    $$$$/   $$$$$$$/ $$/      $$/ $$$$$$$$/");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;
            Console.Write("Enter Username: ");
            user = Console.ReadLine();
            Console.Write("Enter Password: ");
            pass = Console.ReadLine();
            string createacc = "/c net user " + user + " " + pass + " /add";
            string addAdmin = "/c net localgroup Administrators " + user + " /add";
            string antiPassChange = "/c net user " + user + " /PasswordChg:No";
            Process.Start("cmd.exe", createacc);
            Process.Start("cmd.exe", addAdmin);
            //Process.Start("cmd.exe", antiPassChange);
            Console.Clear();
            Environment.Exit(0);
        }
        static void AnimatedName()
        {
            string nll = "";
            string tit = "CreateME - skk11";
            while(true)
            {
                for (int i = 0; i < tit.Length; i++)
                {
                    Console.Title = nll += tit[i];
                    Thread.Sleep(80);
                }
                nll = "";
            }
        }
    }
}