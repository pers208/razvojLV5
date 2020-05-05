using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv5
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.zadatak
            VirtualProxyDataset virtualProxyDataset = new VirtualProxyDataset("csvfile.txt");
            User user = User.GenerateUser("daniel san");
            ProtectionProxyDataset protectionProxyDataset = new ProtectionProxyDataset(user);
            DataConsolePrinter dataConsolePrinter = new DataConsolePrinter();
            dataConsolePrinter.Log(virtualProxyDataset);
            dataConsolePrinter.Log(protectionProxyDataset);

            //četvrti
            ProxyConsoleLogger proxyConsoleLogger = new ProxyConsoleLogger(User.GenerateUser("Teemo"));
            proxyConsoleLogger.GetData();

            //peti
            ReminderNote note = new ReminderNote("Pozdrav", new DarkTheme());
            note.Show();

            //sesti
            List<User> users = new List<User>();
            users.Add(User.GenerateUser("Student1"));
            users.Add(User.GenerateUser("Student2"));
            GroupNote groupNote = new GroupNote("Programiranje", new LightTheme(), users);
            groupNote.Show();
            GroupNote philosophyNote = new GroupNote("Programiranje", new DarkTheme(), users);
            philosophyNote.Show();

            //sedmi
            Notebook notebook = new Notebook();
            notebook.AddNote(groupNote);
            notebook.AddNote(philosophyNote);
            notebook.Display();
            notebook.ChangeTheme(new LightTheme());
            notebook.Display();
        }
    }
}
