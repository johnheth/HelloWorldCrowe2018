using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using API_Portable;

namespace HelloWorldCrowe2018
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface version using api - currently using "console" for output as requested
            App thisApp = new App();
            String outputMethod = System.Configuration.ConfigurationManager.AppSettings["outputTo"].ToString();
            switch (outputMethod)
            {
                case "webapps":
                    //code for windows apps work - replace FutureFeature with similar code for console section
                    thisApp.setBehavior(new WebApp());
                    thisApp.setOutput("Hello World"); FutureFeature();
                    break;
                case "mobileapps":
                    //code for mobileapps work - replace FutureFeature with similar code for console section
                    thisApp.setBehavior(new MobileApp());
                    thisApp.setOutput("Hello World"); FutureFeature();
                    break;
                case "windowsservices":
                    //code for windowsservices work - replace FutureFeature with similar code for console section
                    thisApp.setBehavior(new DatabaseApp());
                    thisApp.setOutput("Hello World");
                    FutureFeature();
                    break;
                case "console":
                    thisApp.setBehavior(new ConsoleApp());
                    thisApp.setOutput("Hello World");
                    //thisApp.WriteMessage();
                    Console.WriteLine(thisApp.getText());
                    //press enter or other key to exit screen so you can view the Console Window
                    Console.ReadKey();
                    break;
                default:
                    thisApp.setBehavior(new ConsoleApp());
                    thisApp.setOutput("Hello World");
                    //thisApp.WriteMessage();
                    Console.WriteLine(thisApp.getText());
                    //press enter or other key to exit screen so you can view the Console Window
                    Console.ReadKey();
                    break;
            }
        }

        public static void FutureFeature()
        {
            throw new NotImplementedException();
        }

    }
}
