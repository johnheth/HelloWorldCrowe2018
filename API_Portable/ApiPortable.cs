using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace API_Portable
{

    //This class is available to add to code later for supporting mobile apps, 
    //web apps, console apps or windows services
    public interface IAppType
    {
        void SetOutput(string message);
        string GetText();
        void WriteMessage();
    }

    public class ConsoleApp : IAppType
    {
        public string ConsoleText;
        public string GetText()
        {
            return this.ConsoleText;
        }
        public void WriteMessage()
        {
            //Console.WriteLine(ConsoleText.ToString()); - will not work console writeline- placed in console app code
        }
        public void SetOutput(string message)
        {
            this.ConsoleText = message;
        }
    }

    public class DatabaseApp : IAppType
    {
        public string DatabaseText;
        public string GetText()
        {
            return this.DatabaseText;
        }
        public void WriteMessage()
        {
            //To Do
            //Database connection string code here
            //Database code for writing to database here
        }
        public void SetOutput(string message)
        {
            this.DatabaseText = message;
        }
    }
    public class MobileApp : IAppType
    {
        public string MobileText;
        public string GetText()
        {
            return this.MobileText;
        }
        public void WriteMessage()
        {
            //To Do
            //Mobile Xamarin code here
            //Mobile code for writing to app storyboard or view here
        }
        public void SetOutput(string message)
        {
            this.MobileText = message;
        }
    }
    public class WebApp : IAppType
    {
        public string WebText;
        public string GetText()
        {
            return this.WebText;
        }
        public void WriteMessage()
        {
            //To Do
            //Database connection string code here
            //Database code for writing to database here
        }
        public void SetOutput(string message)
        {
            this.WebText = message;
        }
    }
    public class App
    {
        IAppType behavior;

        public void setBehavior(IAppType behavior)
        {
            this.behavior = behavior;
        }
        public IAppType getBehavior()
        {
            return behavior;
        }
        public void setOutput(string message)
        {
            behavior.SetOutput(message);
        }
        public string getText()
        {
            return behavior.GetText();
        }
        public void WriteMessage()
        {
            behavior.WriteMessage();
        }
    }
}