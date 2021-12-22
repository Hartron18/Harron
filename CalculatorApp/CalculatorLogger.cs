using System;
using static System.Console;
using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static System.Environment;
using static System.IO.Path;


namespace CalculatorLogger
{


    public class Logger
    {
        private string CurrentDirectory{get; set;}

        private string FileName{get; set;}

        private string FilePath{get; set;}
        
        public Logger()
        {
           this.CurrentDirectory = Directory.GetCurrentDirectory();
           this.FileName = "Log.txt";
           this.FilePath = this.CurrentDirectory + "/" + this.FileName;
        
        }

        public void Log(string Message)
        {
            using (System.IO.StreamWriter w = System.IO.File.AppendText(this.FilePath))
            {
                w.WriteLine($"{DateTime.Now}: {Message}");
                w.WriteLine();
            }
        }     
            
    }
}

